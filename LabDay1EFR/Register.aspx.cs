using LabDay1EFR.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDay1EFR
{
    public partial class Register : System.Web.UI.Page
    {
        ITIContext db = new ITIContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dr_dept.DataSource = db.departments.ToList();
                dr_dept.DataTextField = "name";
                dr_dept.DataValueField = "id";
                dr_dept.DataBind();
            }
        }

        protected void Btn_register_Click(object sender, EventArgs e)
        {
            string pathcv = $"~/files/{flup_cv.FileName}";
            string pathimg = $"~/images/{flup_img.FileName}";


            var nam = db.instructors.Where(n => n.name == txt_name.Text).FirstOrDefault();

            if (nam == null)
            {

                flup_cv.SaveAs(Server.MapPath(pathcv));
                flup_img.SaveAs(Server.MapPath(pathimg));

                instructor ins = new instructor();
                ins.name = txt_name.Text;
                ins.email = txt_email.Text;
                ins.passowrd = txt_password.Text;
                ins.cv = pathcv;
                ins.photo = pathimg;
                ins.dept_id = int.Parse(dr_dept.SelectedValue);
                ins.age = int.Parse(txt_age.Text);

                db.instructors.Add(ins);

                db.SaveChanges();
                txt_name.Text = txt_email.Text = txt_age.Text = lbl_name.Text = "";
            }
            else
                lbl_name.Text = "Name is Found";
        }
    }
}