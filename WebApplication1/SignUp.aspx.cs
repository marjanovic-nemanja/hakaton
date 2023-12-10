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
    public partial class SignUp1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Profile/Guides.aspx");
            }
        }

        protected void btn_signup_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string sqlstring = "INSERT INTO Korisnik(Ime, Prezime, Email, Sifra) Values (@ime, @prezime, @email, @sifra)";
                SqlCommand cmd = new SqlCommand(sqlstring, connection);
                cmd.Parameters.AddWithValue("@ime", tbIme.Text);
                cmd.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@sifra", tbSifra.Text);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { }
                connection.Close();


                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(tbEmail.Text, false, 30);
                string encTicket = FormsAuthentication.Encrypt(ticket);

                HttpCookie loginCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                loginCookie.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(loginCookie);
                Session["email"] = tbEmail.Text;
            }
        }
    }
}