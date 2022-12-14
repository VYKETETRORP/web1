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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace AsgcSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String id = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //calculate usr age for inpute
            var timeSpan = DateTime.Now - dtpDob.Value;
            int age = new DateTime(timeSpan.Ticks).Year - 1;

            //SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbconection);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.dbconection);
            //String sql = "INSERT INTO tbStudent(Name,Sex) VALUES('"+ txtName.Text +"',N'"+comboSex.SelectedItem +"')";
            String sql = "INSERT INTO tbluser(Name,Sex,Dob,Address,Phone,Email,age) VALUES(@name,@sex,@dob,@address,@phone,@email,@age)";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@name", txtName.Text);
            cm.Parameters.AddWithValue("@sex", comboSex.SelectedItem);
            cm.Parameters.AddWithValue("@dob", dtpDob.Value);
            cm.Parameters.AddWithValue("@Address", txtAddress.Text);
            cm.Parameters.AddWithValue("@phone", txtPhone.Text);
            cm.Parameters.AddWithValue("@email", txtEmail.Text);
            cm.Parameters.AddWithValue("@age", age);


            con.Open();
            cm.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data has been save to database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Loaddata();
            //calll clear funtion 
            Cleartext();


        }
        private void Cleartext()
        {
            txtAddress.Text = null;
            txtEmail.Text = null;
            txtName.Text = null;
            txtPhone.Text = null;
            dtpDob.Value = DateTime.Now;
            comboSex.SelectedIndex = 0;
            txtName.Focus();

        }


        private int Age(DateTime _date)
        {
            var timeSpan = DateTime.Now - _date;
            int age = new DateTime(timeSpan.Ticks).Year - 1;
            return age;
        }
        private void SearchText(String _text)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.dbconection);
            String sql = "SELECT * FROM tbluser WHERE Name LIKE @name or phone LIKE @phone";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            cm.Parameters.AddWithValue("@name", '%' + _text + '%');
            cm.Parameters.AddWithValue("@phone", '%' + _text);
            con.Open();
            da.Fill(dt);
            con.Close();
            dgvshow.DataSource = dt;
        }

        private void Loaddata()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.dbconection);
            String sql = "SELECT * FROM tbluser";
            SqlCommand cm = new SqlCommand(sql, con);
            //SqlCommand cm = new SqlCommand("SELECT * FROM tbstudent", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
          dgvshow.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loaddata();
            comboSex.SelectedIndex = 0;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //var timeSpan = DateTime.Now - dtpDob.Value;
            //int age = new DateTime(timeSpan.Ticks).Year - 1;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.dbconection);
            String sql = "UPDATE tbluser SET Name=@name,Sex=@sex,Dob=@dob,Address=@add,Phone=@phone,Email=@email,age=@age WHERE Id=@id";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@name", txtName.Text);
            cm.Parameters.AddWithValue("@sex", comboSex.SelectedItem);
            cm.Parameters.AddWithValue("@dob", dtpDob.Value);
            cm.Parameters.AddWithValue("@add", txtAddress.Text);
            cm.Parameters.AddWithValue("@phone", txtPhone.Text);
            cm.Parameters.AddWithValue("@email", txtEmail.Text);
            cm.Parameters.AddWithValue("@age", Age(dtpDob.Value));
            cm.Parameters.AddWithValue("@id", id);
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();

            Loaddata();
            Cleartext();
            btnAdd.Enabled = true;
        }

        private void dgvshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvshow.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAddress.Text = dgvshow.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dgvshow.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtName.Text = dgvshow.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPhone.Text = dgvshow.Rows[e.RowIndex].Cells[5].Value.ToString(); ;
            dtpDob.Value = DateTime.Parse(dgvshow.Rows[e.RowIndex].Cells[3].Value.ToString());
            comboSex.SelectedItem = dgvshow.Rows[e.RowIndex].Cells[2].Value.ToString();
            btnAdd.Enabled = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            SearchText(textBox1.Text);
        }

        private void dgvshow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DialogResult result = MessageBox.Show("Do you want to Delete this record!", "infor", MessageBoxButtons.YesNo);

                id = dgvshow.Rows[e.RowIndex].Cells[0].Value.ToString();

                //MessageBox.Show(id);
                if (result == DialogResult.Yes)
                {

                    SqlConnection con = new SqlConnection(Properties.Settings.Default.dbconection);
                    String sql = "DELETE FROM tbluser WHERE Id=@id";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();

                    Loaddata();
                }

            }
        }
    }
}
