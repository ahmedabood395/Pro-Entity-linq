using LabDay1EFR.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDay1EFR
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ITIContext db = new ITIContext();

            int id = (int)Session["id"];
           
            GridView1.DataSource = db.instructors.Where(n => n.id == id).Select(n => new { ID = n.id, Name = n.name, Email = n.email, CV = n.cv, Photo = n.photo, Dept_id = n.dept_id,Dept_Name=n.department.name }).ToList();
            GridView1.DataBind();

            img.ImageUrl = db.instructors.Where(n => n.id == id).Select(n => n.photo).FirstOrDefault();
            HyperLink1.NavigateUrl = db.instructors.Where(n => n.id == id).Select(n => n.cv).FirstOrDefault();
        }
    }
}