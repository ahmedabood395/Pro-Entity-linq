using LabDay1EFR.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDay1EFR
{
    public partial class InstructorShow : System.Web.UI.Page
    {
        ITIContext db = new ITIContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drp_dept.DataSource = db.departments.ToList();
                drp_dept.DataTextField = "name";
                drp_dept.DataValueField = "id";
                drp_dept.DataBind();

                drp_dept_SelectedIndexChanged(null, null);
            }
        }

        protected void gv_instructor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void drp_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(drp_dept.SelectedValue);
            gv_instructor.DataSource = db.instructors.Where(n => n.dept_id == id).ToList();
            gv_instructor.DataBind();
        }
    }
}