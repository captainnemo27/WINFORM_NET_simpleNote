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
using SimpleNote.Views;
namespace SimpleNote
{
    public partial class frm_Users : Form
    {
        frm_Note formNote;
        public frm_Users()
        {
            InitializeComponent();
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
            if(this.text_NameUser.Text.Trim().Length==0)
            {
                this.errorProvider1.SetError(this.text_NameUser, "Need to fill in this box");
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
            if (this.text_Password.Text.Trim().Length == 0)
            {
                this.errorProvider2.SetError(this.text_Password, "Need to fill in this box");
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
            
            this.formNote = new frm_Note();
            this.formNote.Show();

        }
    }
}
