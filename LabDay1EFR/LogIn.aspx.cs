using LabDay1EFR.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDay1EFR
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            ITIContext db = new ITIContext();

            instructor ins = db.instructors.Where(n => n.name == txt_name.Text && n.passowrd == txt_password.Text).FirstOrDefault();
            if (ins != null)
            {
                Session.Add("id", ins.id);
                Response.Redirect("~/Profile.aspx");
            }
            else
                lbl_validate.Text = "Password and Name invalide";
        }
    }
}