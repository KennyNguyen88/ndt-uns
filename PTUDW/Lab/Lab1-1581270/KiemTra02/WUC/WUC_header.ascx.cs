using KiemTra02.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KiemTra02.WUC
{
    public partial class WUC_header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UpdateCartItem();
            }
        }

        protected void TextBoxKeyword_TextChanged(object sender, EventArgs e)
        {
            Search(Server.UrlEncode(TextBoxKeyword.Text));
        }

        protected void LinkButtonSearch_Click(object sender, EventArgs e)
        {
            Search(Server.UrlEncode(TextBoxKeyword.Text));            
        }

        protected void Search(String keyword)
        {
            String url = String.Format("~/Products.aspx?keyword={0}", keyword);
            Response.Redirect(url);
        }

        public void UpdateCartItem()
        {
            ShoppingCart cart = new ShoppingCart();
            LabelCartItemCount.Text = cart.TotalItemCount.ToString();
        }
    }
}