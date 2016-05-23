using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace last_rest
{
    public partial class log_in : Form
    {
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS;database=rest;integrated security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        String original_username = "isds";
        String original_pass = "13577531@xX";
        public log_in()
        {
            InitializeComponent();
            groupBox1.Hide();
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select * from login",cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (username.Text == dr["username"].ToString() && password.Text == dr["password"].ToString() || username.Text == original_username && password.Text == original_pass)
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("تأكد من ادخال الاسم و كلمة المرور بطريقة صحيحة");
            }
            dr.Close();
            cn.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select * from login", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (oldname.Text == dr["username"].ToString() && oldpass.Text == dr["password"].ToString()) 
            {
                cn.Close();
                cn.Open();
                cmd = new SqlCommand("update login set username='" + newname.Text + "',password='" + newpass.Text + "' where username = '" + oldname.Text + "'",  cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("تم تغير كلمة المرور بنجاح");
            }

            else if( oldname.Text == original_username && oldpass.Text == original_pass)
            {
                cn.Close();
                cn.Open();
                cmd = new SqlCommand("delete from login", cn);
                cmd.ExecuteNonQuery();
                cmd=new SqlCommand("insert into login (username,password)values('" + newname.Text + "','" + newpass.Text + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم تغير كلمة المرور بنجاح");
            }
            else
            {
                MessageBox.Show("تأكد من ادخال الاسم و كلمة المرور بطريقة صحيحة");
            }
            dr.Close();
            cn.Close();
            //******************
            groupBox1.Hide();
            newname.Clear();
            newpass.Clear();
            oldname.Clear();
            oldpass.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            newname.Clear();
            newpass.Clear();
            oldname.Clear();
            oldpass.Clear();
        }


    }
}
