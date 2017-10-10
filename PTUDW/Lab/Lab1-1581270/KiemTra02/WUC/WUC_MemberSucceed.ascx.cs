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
    public partial class WUC_MemberSucceed : System.Web.UI.UserControl
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
    
    }
}