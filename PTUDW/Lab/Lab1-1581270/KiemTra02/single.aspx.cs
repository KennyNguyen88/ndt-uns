using KiemTra02.Code;
using KiemTra02.WUC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KiemTra02
{
    public partial class single : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RepeaterDetail_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                ShoppingCart cart = new ShoppingCart();
                int id = int.Parse(e.CommandArgument.ToString());
                cart.AddItem(id);

                ((WUC_header)Page.Master.FindControl("WUC_header")).UpdateCartItem();
            }
        }
        protected string isChecked(int stars, object rating)
        {
            double r = double.Parse(rating.ToString());
            if (stars == Math.Floor(r))
                return "checked";
            return "";
        }
    }
}