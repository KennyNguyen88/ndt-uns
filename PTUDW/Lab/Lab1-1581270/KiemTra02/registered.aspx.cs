using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KiemTra02.Code;
using System.Web.Security;
namespace KiemTra02
{
    public partial class registered : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizardRegister_CreatedUser(object sender, EventArgs e)
        {
            MembershipUser user = Membership.GetUser(CreateUserWizardRegister.UserName);

            PTUDWEntities db = new PTUDWEntities();

            UserAddress address = new UserAddress();
            address.UserId = (Guid)user.ProviderUserKey;
            address.Fullname = CreateUserWizardRegister.UserName;
            address.ImagePath = "defaultuser.png";
            db.UserAddresses.Add(address);

            db.SaveChanges();
        }
    }
}