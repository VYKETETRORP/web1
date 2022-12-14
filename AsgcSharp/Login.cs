using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsgcSharp
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.dbconection);
        String sql;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            String _permission = null;
            sql = "SELECT * FROM tbUser1 WHERE username=@name AND password=@pass";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@name", txtname.Text);
            cm.Parameters.AddWithValue("@pass", txtpassword.Text);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    _permission = dr.GetValue(4).ToString();
                }
                MainFrm2 fm = new MainFrm2(txtname.Text, _permission);
                fm.Show();
            }
            else
            {
                msgboxFrm ms = new msgboxFrm();
                ms.lblmsg.Text = ("ឈ្មោះ​ ឬលេខសម្ងាត់មិនមានក្នុងប្រព័ន្ធ");
                ms.ShowDialog();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
