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
    }
}