using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace KiemTra02.WUC
{
    public partial class WUC_MemberAddress : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MembershipUser user = Membership.GetUser();
            HiddenFieldUserId.Value = user.ProviderUserKey.ToString();
        }
    }
}