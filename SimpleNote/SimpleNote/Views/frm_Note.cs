using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleNote.Views;

namespace SimpleNote.Views
{
    public partial class frm_Note : Form
    {
        public frm_Note()
        {
            InitializeComponent();
        }

        private void frm_Note_Load(object sender, EventArgs e)
        {
            foreach(FontFamily font in FontFamily.Families)
            {
                this.comboBox_TextStyle.Items.Add(font.Name.ToString());
            }    
        }

        private void comboBox_TextStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richText_Note.Font = new Font(this.comboBox_TextStyle.Font, this.richText_Note.Font.Style);
        }
    }
}
