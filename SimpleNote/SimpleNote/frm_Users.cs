using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace SimpleNote
{
    public partial class frm_Users : Form
    {
        public frm_Users()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void signin()
        {
            bool check1 = this.check_signin1();
            bool check2 = this.check_signin2();
            if(check1 || check2)
            {
                return;
            }    
        }
        private bool check_signin1()
        {
            if(this.textBox1.Text.Trim().Length==0)
            {
                this.errorProvider1.SetError(this.textBox1, "Need to fill in this box");
                MessageBox.Show("You do not fill the UserName !!! ");
                return true;
            }
            else
            {
                this.errorProvider1.Clear();
                return false;
            }
        }
        private bool check_signin2()
        {
            if (this.textBox2.Text.Trim().Length == 0)
            {
                this.errorProvider2.SetError(this.textBox2, "Need to fill in this box");
                MessageBox.Show("You do not fill the Password !!! ");
                return true;
            }
            else
            {
                this.errorProvider2.Clear();
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //signin();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K1VLFOB\MSSQLSERVERTD;Initial Catalog=USERS;Integrated Security=True");
            try
            {
                conn.Open();
                string nu = textBox1.Text;
                string pw = textBox2.Text;
                string sql = "select *from Users where NameUser = '" + nu + "' and Password = '" + pw + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()== true)
                {
                    MessageBox.Show("sign in already", "Esay to Note everything",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("sign in not already !!!","no no no", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR to connect the sever ");
            }
        }
    }
}
