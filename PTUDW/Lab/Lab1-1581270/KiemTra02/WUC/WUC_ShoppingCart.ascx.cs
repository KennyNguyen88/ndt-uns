using KiemTra02.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KiemTra02.WUC
{
    public partial class WUC_ShoppingCart : System.Web.UI.UserControl
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
            LabelTotalCost.Text = cart.TotalCost.ToString();
            LabelTotalCostHidden.Text = cart.TotalCost.ToString();
        }

        protected void RepeaterShoppingCart_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            ShoppingCart cart = new ShoppingCart();
            int id = int.Parse(e.CommandArgument.ToString());
            if(e.CommandName== "UpdateItem")
            {
                var txt = e.Item.FindControl("TextBoxQuantity") as TextBox;
                int quantity = int.Parse(txt.Text);
                cart.SetItemQuantity(id, quantity);
                
            }
            else if (e.CommandName == "RemoveItem")
            {
                cart.RemoveItem(id);
            }
            BindData();
            ((WUC_header)Page.Master.FindControl("WUC_header")).UpdateCartItem();
        }
    }
}