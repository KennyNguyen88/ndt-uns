using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KiemTra02.Code;
using System.Web.Security;
namespace KiemTra02.WUC
{
    public partial class WUC_MemberCheckout : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        protected void BindData()
        {
            ShoppingCart cart = new ShoppingCart();
            RepeaterShoppingCart.DataSource = cart.Items;
            RepeaterShoppingCart.DataBind();
            LabelTotalPrice.Text = cart.TotalCost.ToString();
        }

        protected void ButtonPayNow_Click(object sender, EventArgs e)
        {
            MembershipUser user = Membership.GetUser();

            ShoppingCart cart = new ShoppingCart();

            Order order = new Order();
            order.UserId = (Guid)user.ProviderUserKey;
            order.OrderDatetime = DateTime.Now;
            order.OrderTotal = (double)cart.TotalCost;
            order.StatusId = 1;

            foreach(var item in cart.Items)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.ProductId = item.ProductId;
                orderDetail.Quantity = item.Quantity;
                orderDetail.UnitPrice = (double)item.UnitPrice;
                orderDetail.TotalPrice = (double)item.TotalPrice;
                order.OrderDetails.Add(orderDetail);
            }

            PTUDWEntities db = new PTUDWEntities();
            db.Orders.Add(order);
            db.SaveChanges();

            Response.Redirect("~/member/succeed.aspx");

        }
    }
}