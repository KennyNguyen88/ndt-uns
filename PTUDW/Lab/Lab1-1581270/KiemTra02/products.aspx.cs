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
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sortExpression = country.SelectedValue;
            SortDirection sortDirection = SortDirection.Ascending;
            if (sortExpression == "AverageRating")
            {
                sortDirection = SortDirection.Descending;
            }
            ListViewProducts.Sort(sortExpression, sortDirection);
        }

        protected void country1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataPagerProducts.PageSize = int.Parse(country1.SelectedValue);
            DataPagerProducts.DataBind();
            ListViewProducts.DataBind();
        }

        protected void ListViewProducts_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                ShoppingCart cart = new ShoppingCart();
                int id = int.Parse(e.CommandArgument.ToString());
                cart.AddItem(id);

                ((WUC_header)Page.Master.FindControl("WUC_header")).UpdateCartItem();
            }
        }
    }
}