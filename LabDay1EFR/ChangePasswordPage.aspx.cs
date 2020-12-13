using LabDay1EFR.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDay1EFR
{
    public partial class ChangePasswordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            ITIContext db = new ITIContext();
            int id = (int)Session["id"];
            instructor ins = db.instructors.Where(n => n.id == id).FirstOrDefault();
            if (ins.passowrd == txt_oldpass.Text)
            {
                ins.passowrd = txt_newpass.Text;
                db.SaveChanges();
                Label1.Text = "";
            }
            else
                Label1.Text = "The Old Password Not Matched";
        }
    }
}