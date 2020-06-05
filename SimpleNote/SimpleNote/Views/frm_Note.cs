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
            string text_note;
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
            string font = this.comboBox_TextStyle.SelectedItem.ToString();
            float size = this.richText_Note.Font.Size;
            Font myfont = new Font(font, size);
            this.richText_Note.Font = myfont;
            
        }

        private void comboBox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = this.richText_Note.Font.Name;
            float size = float.Parse(this.comboBox_Size.SelectedItem.ToString())*1.0f;
            Font myfont = new Font(font, size);
            this.richText_Note.Font = myfont;
        }
    }
}
