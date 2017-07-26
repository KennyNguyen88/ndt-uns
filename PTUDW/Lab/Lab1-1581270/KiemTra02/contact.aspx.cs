using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KiemTra02.Code;
namespace KiemTra02
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // initialize the Captcha validation error label
                CaptchaErrorLabel.Text = "Incorrect CAPTCHA code!";
                CaptchaErrorLabel.Visible = false;
            }

            // setup client-side input processing
            ExampleCaptcha.UserInputID = CaptchaCode.ClientID;

            if (IsPostBack)
            {
                // validate the Captcha to check we're not dealing with a bot
                string userInput = CaptchaCode.Text;
                bool isHuman = ExampleCaptcha.Validate(userInput);
                CaptchaCode.Text = null; // clear previous user input

                if (isHuman)
                {
                    CaptchaErrorLabel.Visible = false;
                    PTUDWEntities db = new PTUDWEntities();
                    ContactMessage msg = new ContactMessage();
                    msg.Name = TextBoxName.Text;
                    msg.Email = TextBoxEmail.Text;
                    msg.Message = TextBoxMessage.Text;
                    msg.CheckStatus = false;
                    msg.SubmitDatetime = DateTime.Now;
                    db.ContactMessages.Add(msg);
                    db.SaveChanges();

                    LabelThongBao.Text = "Message is sent !";
                    LabelThongBao.CssClass = "text-info";
                }
                else
                {
                    CaptchaErrorLabel.Visible = true;
                    CaptchaErrorLabel.Text = "Captcha is not matched";                    
                    CaptchaErrorLabel.CssClass = "text-danger";
                }
            }

            
        }
    }
}