using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SignIn1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Profile/Guides.aspx");
            }
        }

        protected void btn_signin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string sqlstring = "SELECT * FROM Korisnik WHERE Email = @email AND Sifra = @pass";
                SqlCommand cmd = new SqlCommand(sqlstring, connection);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@pass", tbPassword.Text);
                Session["email"] = tbEmail.Text;
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(reader["id"].ToString(), false, 30);
                        string encTicket = FormsAuthentication.Encrypt(ticket);

                        HttpCookie loginCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                        loginCookie.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(loginCookie);
                        Response.Redirect("~/Profile/Guides.aspx");
                    }
                    else
                    {
                        tbEmail.Text = "";
                        tbPassword.Text = "";
                    }
                }
                catch (Exception ex) { }

                connection.Close();
            }
        }
    }
}