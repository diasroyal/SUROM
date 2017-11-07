using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

    public partial class Registration : System.Web.UI.Page
    {

        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        String qurstr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registerEventMethod(object sender, EventArgs e)
        {
            btnSave_Click();
        }
        protected void btnSave_Click()
        {
            String sConnString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(sConnString);
            conn.Open();
            qurstr = "INSERT INTO CarReviewDB.Users(username,Password,Fname,Mname,Lname,Address,Email,Phone)" + 
                "VALUES('"+ txtUsername.Text +"','"+ txtPassword.Text +"','"+ txtFirst.Text +"','"+ txtMiddle.Text +"','"+ txtLast.Text +"','"+ txtAddress.Text +"','"+txtEmail.Text +"','"+ txtContact.Text +"')";
           
            cmd = new MySql.Data.MySqlClient.MySqlCommand(qurstr, conn);
            cmd.ExecuteReader();
                     
            conn.Close();
            txtUsername.Text = txtPassword.Text = txtFirst.Text = txtMiddle.Text = txtLast.Text = txtAddress.Text = txtEmail.Text = txtContact.Text = "";   
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {

            txtUsername.Text = txtPassword.Text = txtFirst.Text = txtMiddle.Text = txtLast.Text = txtAddress.Text = txtEmail.Text = txtContact.Text = "";     
        }
    }
