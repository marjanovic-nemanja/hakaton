using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication1.Profile
{
    public partial class Guides : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                DataTable drzava = new DataTable();

                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Drzava", con);
                    adapter.Fill(drzava);

                    ddlDrzava.DataSource = drzava;
                    ddlDrzava.DataTextField = "NazivDrzave";
                    ddlDrzava.DataValueField = "DrzavaId";
                    ddlDrzava.DataBind();
                    con.Close();
                }
                catch (Exception ex)
                {

                }


            }

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string sqlstring = "Select * FROM Korisnik WHERE Vodic = @vodic";
                SqlCommand cmd = new SqlCommand(sqlstring, connection);
                cmd.Parameters.AddWithValue("@vodic", 1);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    Panel panel1 = new Panel() { CssClass = "guide-card"};
                    Panel panel2 = new Panel() { CssClass = "left-profile"};
                    Panel panel3 = new Panel() { CssClass = "right-profile"};
                    Panel panel4 = new Panel() { CssClass = "card-bottom" };

                    panel1.Controls.Add(panel2);
                    panel1.Controls.Add(panel3);

                    var h4 = new HtmlGenericControl("h4") { InnerText = $"{reader["Ime"]} {reader["Prezime"]}" };
                    panel3.Controls.Add(h4);
                    var p1 = new HtmlGenericControl("p") { InnerText = $"30$" };
                    p1.Attributes.Add("class", "price");
                    var p2 = new HtmlGenericControl("p") { InnerHtml = $"{reader["Ocene"]} <img src='../Content/Images/star.png'>" };
                    p2.Attributes.Add("class", "rating");
                    var img = new HtmlGenericControl("img");
                    img.Attributes.Add("src", "../Content/Images/user.png");

                    panel2.Controls.Add(img);

                    panel4.Controls.Add(p1);
                    panel4.Controls.Add(p2);

                    panel3.Controls.Add(panel4);
                    guide.Controls.Add(panel1);
                    i++;
                    if (i == 9)
                    {
                        break;
                    }
                }
                connection.Close();
            }

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/Default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string sqlstring = "Insert INTO Korisnik VALUES (Vodic=@vodic) WHERE Ime = @ime";
                SqlCommand cmd = new SqlCommand(sqlstring, connection);
                cmd.Parameters.AddWithValue("@ime", Session["ime"].ToString());
                cmd.Parameters.AddWithValue("@vodic", 1);
                try
                {
                    cmd.ExecuteReader();
                    connection.Open();
                }
                catch (Exception ex) { }
                connection.Close();



            }
        }

        protected void ddlDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            guide.Controls.Clear();
            Panel panel1 = new Panel() { CssClass = "guide-card" };
            Panel panel2 = new Panel() { CssClass = "left-profile" };
            Panel panel3 = new Panel() { CssClass = "right-profile"};
            Panel panel4 = new Panel() { CssClass = "card-bottom" };

            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);

            var h4 = new HtmlGenericControl("h4") { InnerText = $"Marko Petrovic" };
            panel3.Controls.Add(h4);
            var p1 = new HtmlGenericControl("p") { InnerText = $"30$" };
            p1.Attributes.Add("class", "price");
            var p2 = new HtmlGenericControl("p") { InnerHtml = $"5 <img src='../Content/Images/star.png'>" };
            p2.Attributes.Add("class", "rating");
            var img = new HtmlGenericControl("img");
            img.Attributes.Add("src", "../Content/Images/iron.png");

            panel2.Controls.Add(img);

            panel4.Controls.Add(p1);
            panel4.Controls.Add(p2);

            panel3.Controls.Add(panel4);
            guide.Controls.Add(panel1);

            //////////////////////////////////////////////////////
            ///slika1.jpg
            ///
            
            Panel panel10 = new Panel() { CssClass = "guide-card" };
            Panel panel20 = new Panel() { CssClass = "left-profile" };
            Panel panel30 = new Panel() { CssClass = "right-profile" };
            Panel panel40 = new Panel() { CssClass = "card-bottom" };

            panel10.Controls.Add(panel20);
            panel10.Controls.Add(panel30);

            var h40 = new HtmlGenericControl("h4") { InnerText = $"Darko Djordjevic" };
            panel30.Controls.Add(h40);
            var p10 = new HtmlGenericControl("p") { InnerText = $"70$" };
            p10.Attributes.Add("class", "price");
            var p20 = new HtmlGenericControl("p") { InnerHtml = $"4.2 <img src='../Content/Images/star.png'>" };
            p20.Attributes.Add("class", "rating");
            var img0 = new HtmlGenericControl("img");
            img0.Attributes.Add("src", "../Content/Images/rok1.png");

            panel20.Controls.Add(img0);

            panel40.Controls.Add(p10);
            panel40.Controls.Add(p20);

            panel30.Controls.Add(panel40);
            guide.Controls.Add(panel10);



            //////////////////////////////////
            ///
            Panel panel100 = new Panel() { CssClass = "guide-card" };
            Panel panel200 = new Panel() { CssClass = "left-profile" };
            Panel panel300 = new Panel() { CssClass = "right-profile" };
            Panel panel400 = new Panel() { CssClass = "card-bottom" };

            panel100.Controls.Add(panel200);
            panel100.Controls.Add(panel300);

            var h400 = new HtmlGenericControl("h4") { InnerText = $"Petar Simeonovic" };
            panel300.Controls.Add(h400);
            var p100 = new HtmlGenericControl("p") { InnerText = $"55$" };
            p100.Attributes.Add("class", "price");
            var p200 = new HtmlGenericControl("p") { InnerHtml = $"3.9 <img src='../Content/Images/star.png'>" };
            p200.Attributes.Add("class", "rating");
            var img00 = new HtmlGenericControl("img");
            img00.Attributes.Add("src", "../Content/Images/deda.png");

            panel200.Controls.Add(img00);

            panel400.Controls.Add(p100);
            panel400.Controls.Add(p200);

            panel300.Controls.Add(panel400);
            guide.Controls.Add(panel100);

        }
    }
    }
