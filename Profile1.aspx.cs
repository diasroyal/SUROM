using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{

    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        String sConnString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        conn = new MySql.Data.MySqlClient.MySqlConnection(sConnString);
        if (Request.QueryString["msg"] == "update")
        {
            lblShow.Text = "Information Update Successfully";
        }
        if (!IsPostBack)
        {
            RequiredFieldValidator2.Visible = false;
            Label1.Visible = txtConfirm.Visible = false;
            txtUsername.Enabled = txtPassword.Enabled = btnChange.Enabled = false;
            int user_id = Convert.ToInt16(Session["ID"]);
            string query = "select * from users where id=" + user_id + "";
            MySql.Data.MySqlClient.MySqlDataReader dr = null;
            cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            dr = cmd.ExecuteReader();
            //  conn.Close();
            while (dr.Read())
            {
                txtUsername.Text = dr.GetString(1);
                txtPassword.Text = dr.GetString(2);
                txtFirst.Text = dr.GetString(3);
                txtMiddle.Text = dr.GetString(4);
                txtLast.Text = dr.GetString(5);
                txtAddress.Text = dr.GetString(6);
                txtEmail.Text = dr.GetString(7);
                txtContact.Text = dr.GetString(8);
            }
            conn.Close();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        int user_id = Convert.ToInt16(Session["ID"]);
        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "InsertUser";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@id", user_id));
        cmd.Parameters.Add(new SqlParameter("@username", (txtUsername.Text).Trim()));
        cmd.Parameters.Add(new SqlParameter("@Password", (txtPassword.Text).Trim()));
        cmd.Parameters.Add(new SqlParameter("@FName", (txtFirst.Text).Trim()));
        cmd.Parameters.Add(new SqlParameter("@MName", (txtMiddle.Text).Trim()));
        cmd.Parameters.Add(new SqlParameter("@LName", (txtLast.Text).Trim()));
        cmd.Parameters.Add(new SqlParameter("@Address", (txtAddress.Text).Trim()));
        cmd.Parameters.Add(new SqlParameter("@Email", (txtEmail.Text).Trim()));
        cmd.Parameters.Add(new SqlParameter("@Phone", (txtContact.Text).Trim()));
        cmd.Parameters.Add("@output", MySql.Data.MySqlClient.MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        conn.Open();
        int result = cmd.ExecuteNonQuery();
        conn.Close();
        Response.Redirect("Profile.aspx?msg=update");
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtFirst.Text = txtMiddle.Text = txtLast.Text = txtAddress.Text = txtEmail.Text = txtContact.Text = string.Empty;
    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        int userId = Convert.ToInt16(Session["ID"]);
        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "update users set password=@password where ID=" + userId + "";
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.Add(new SqlParameter("@password", (txtPassword.Text).Trim()));
        conn.Open();
        int result = cmd.ExecuteNonQuery();
        conn.Close();
        if (result > 0)
        {
            lblShow.Text = "Password Update Successfully";
            chkPassword.Checked = false;
            txtConfirm.Visible = Label1.Visible = false;
            btnChange.Enabled = false;
        }
    }
    protected void chkPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (chkPassword.Checked == true)
        {
            RegularExpressionValidator2.Visible = true;
            txtPassword.Enabled = btnChange.Enabled = true;
            txtConfirm.Visible = Label1.Visible = true;

        }
        if (chkPassword.Checked == false)
        {
            RegularExpressionValidator2.Visible = false;
            txtPassword.Enabled = btnChange.Enabled = false;
            txtConfirm.Visible = Label1.Visible = false;
        }
    }
}