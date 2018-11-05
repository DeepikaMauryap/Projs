using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loginpage
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string Authusername = "Deepika";
            string authPassword = "123456";

            string username = TextBox1.Text;
            string Pass = TextBox2.Text;


            if (username == Authusername && Pass == authPassword)
            {

                lblMsg.Text = "Welcome!" + Authusername;
            }
            else
            {
                lblMsg.Text = "Invalid Username/Password";
            }


        }
    }
}