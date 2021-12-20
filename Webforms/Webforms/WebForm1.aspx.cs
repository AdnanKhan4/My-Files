using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webforms.ServiceReference1;

namespace Webforms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Service1Client service = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string phone = TxtPhone.Text;
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;
            bool isInsert = service.insert(name, phone, email, password);
            if (isInsert)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "callfunction", "alert('Saved Successfully')", true);
                GridView1.DataSource = null;
                GridView1.DataSource = service.getStudent();
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "callfunction", "alert('Error')", true);
            }
        }
    }
}