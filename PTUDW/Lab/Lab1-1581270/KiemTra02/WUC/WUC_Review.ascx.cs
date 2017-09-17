using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using KiemTra02.Code;
namespace KiemTra02.WUC
{
    public partial class WUC_Review : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            RadioButtonList rating = (RadioButtonList)LoginViewReview.FindControl("RadioButtonListRating");
            TextBox subject = (TextBox)LoginViewReview.FindControl("TextBoxSubject");
            TextBox comment = (TextBox)LoginViewReview.FindControl("TextBoxComment");
            int productId = int.Parse(Request.QueryString["id"].ToString());

            MembershipUser user = Membership.GetUser();
            PTUDWEntities db = new PTUDWEntities();

            Review review = new Review();
            review.Username = user.UserName;
            review.ProductId = productId;

            review.Rating = int.Parse(rating.SelectedValue.ToString());
            review.Subject = subject.Text;
            review.Comment = comment.Text;
            review.Approved = true;
            review.PostedDatetime = DateTime.Now;

            db.Reviews.Add(review);
            db.SaveChanges();

            var product = (from p in db.Products where p.Id == productId select p).SingleOrDefault<Product>();
            var reviews = (from r in db.Reviews where r.ProductId == productId && r.Approved == true select r).ToList<Review>();

            product.TotalReviews = reviews.Count;
            
            product.AverageRating = reviews.Average(r => r.Rating).Value;
            
            db.SaveChanges();

            RepeaterReview.DataBind();
        }
        protected string UserImagePath(string username)
        {
            MembershipUser user = Membership.GetUser(username);
            Guid userId = (Guid)user.ProviderUserKey;
            PTUDWEntities db = new PTUDWEntities();
            var address = (from a in db.UserAddresses where a.UserId == userId select a).SingleOrDefault<UserAddress>();
            if (address != null)
                return "~/images/user/" + address.ImagePath;

            return "~/images/user/defaultuser.png";
        }
    }
}