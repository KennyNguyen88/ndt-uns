using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using KiemTra02.Code;
using System.IO;

namespace KiemTra02
{
    public partial class Member : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MembershipUser user = Membership.GetUser();
            Guid userId = (Guid)user.ProviderUserKey;
            PTUDWEntities db = new PTUDWEntities();
            var address = (from a in db.UserAddresses where a.UserId == userId select a).SingleOrDefault<UserAddress>();

            if (address == null)
            {
                LabelFullName.Text = "Username";
                ImageUser.ImageUrl = "~/images/user/defaultuser.png";
            }
            else
            {
                LabelFullName.Text = address.Fullname;
                ImageUser.ImageUrl = "~/images/user/" + address.ImagePath;
            }

            
        }

        protected void LinkButtonLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            if (FileUploadUserImage.HasFile) {
                MembershipUser user = Membership.GetUser();
                string filename = user.ProviderUserKey + Path.GetExtension(FileUploadUserImage.FileName);
                string filepath = HttpContext.Current.Server.MapPath("~/images/user/" + filename);
                FileUploadUserImage.PostedFile.SaveAs(filepath);

                Guid userId = (Guid)user.ProviderUserKey;
                PTUDWEntities db = new PTUDWEntities();
                var address = (from a in db.UserAddresses where a.UserId == userId select a).SingleOrDefault<UserAddress>();
                address.ImagePath = filename;
                db.SaveChanges();

                ImageUser.ImageUrl = "~/images/user/" + address.ImagePath;
            }
        }
    }
}