using LabDay1EFR.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDay1EFR
{
    public partial class EditProfile : System.Web.UI.Page
    {
        ITIContext db = new ITIContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillName();

                drp_dept.DataSource = db.departments.ToList();
                drp_dept.DataTextField = "name";
                drp_dept.DataValueField = "id";
                drp_dept.DataBind();
            }
        }
        void fillName()
        {
            drp_select.DataSource = db.instructors.ToList();
            drp_select.DataTextField = "name";
            drp_select.DataValueField = "id";
            drp_select.DataBind();
        }

        protected void Btn_edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(drp_select.SelectedValue);

            txt_name.Text = db.instructors.Where(n => n.id == id).Select(n => n.name).FirstOrDefault();
            txt_Email.Text = db.instructors.Where(n => n.id == id).Select(n => n.email).FirstOrDefault();
            txt_age.Text = db.instructors.Where(n => n.id == id).Select(n => n.age).FirstOrDefault().ToString();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(drp_select.SelectedValue);

            string pathcv = $"~/files/{flup_cv.FileName}";
            string pathimg = $"~/images/{flup_img.FileName}";


            flup_cv.SaveAs(Server.MapPath(pathcv));
            flup_img.SaveAs(Server.MapPath(pathimg));

            instructor ins = db.instructors.Where(n => n.id == id).FirstOrDefault();
            ins.name = txt_name.Text;
            ins.email = txt_Email.Text;
            ins.age = int.Parse(txt_age.Text);
            ins.cv = pathcv;
            ins.photo = pathimg;

            db.SaveChanges();

            fillName();

            txt_name.Text = txt_Email.Text = txt_age.Text = "";
        }

        protected void Btn_pass_Click(object sender, EventArgs e)
        {
            int id = int.Parse(drp_select.SelectedValue);
            Session.Add("id", id);
            Response.Redirect("~/ChangePasswordPage.aspx");
        }
    }
}