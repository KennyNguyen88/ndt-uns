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
    public partial class WUC_MemberOrders : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MembershipUser user = Membership.GetUser();
                Guid userid = (Guid)user.ProviderUserKey;

                PTUDWEntities db = new PTUDWEntities();
                var query = (from o in db.Orders where o.UserId == userid orderby o.OrderDatetime descending select o).ToList<Order>();
                RepeaterOrder.DataSource = query;
                RepeaterOrder.DataBind();
            }
        }

        protected string toCurrency(string money)
        {


            return String.Format("{0}", Double.Parse(money).ToString("c2"));
        }
    }
}