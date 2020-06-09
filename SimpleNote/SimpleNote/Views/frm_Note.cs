using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cake.Core.IO;
using SimpleNote.Views;
using SimpleNote.Models;

namespace SimpleNote.Views
{
    public partial class frm_Note : Form
    {
        private List<Notes> _listNotes;
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
            //foreach(var wordpad in richText_Note)
            
        }

        private void comboBox_TextStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = this.comboBox_TextStyle.SelectedItem.ToString();
            float size;
            if (comboBox_Size.SelectedItem == null)
                size = 12.0f;
            else
                size = float.Parse(this.comboBox_Size.SelectedItem.ToString()) * 1.0f;
            Font myfont = new Font(font, size);
            string t = this.richText_Note.SelectedText;
            if (t != "")
            {
                
                this.richText_Note.SelectionFont = new Font(font, size);
                this.richText_Note.SelectedText = t;
                return;
            }

        }

        private void comboBox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = this.richText_Note.Font.Name;
            float size = float.Parse(this.comboBox_Size.SelectedItem.ToString())*1.0f;
            
            string t = this.richText_Note.SelectedText;
            if (t != "")
            {
                
                this.richText_Note.SelectionFont = new Font(font, size);
                this.richText_Note.SelectedText = t;
                return;
            }
            //this.richText_Note.Font = myfont;

        }
        private void selectText()
        {
            string t = this.richText_Note.SelectedText;
            if (t != "")
            {
                string ffont = this.comboBox_TextStyle.SelectedItem.ToString();
                float size = float.Parse(this.comboBox_Size.SelectedItem.ToString()) * 1.0f;
                this.richText_Note.SelectionFont = new Font(ffont, size);
                this.richText_Note.AppendText(t);
                return;
            }
            
        }
        private void richText_Note_MouseEnter(object sender, EventArgs e)
        {
            var fC = new FontConverter();
            



        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notes _note = new Notes();
            _note.ID = 1;
            _note.Title_Note = this.textBox_TitleNote.Text;
            _note.Note = this.richText_Note.Text;

            //this._listNotes.Add(_note);
            ListViewItem Note = new ListViewItem(_note.ID.ToString());
            Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, _note.Title_Note.ToString()));
            Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, _note.Note.ToString()));
            this.listView_ListNote.Items.Add(Note);
            this.textBox_TitleNote.ResetText();
            this.richText_Note.ResetText();
        }
        // hasgtag

        /*private void saveNote()
        {
            var uri = new Uri(FilePath);
            webBrowser1.Navigate(uri);
            FileStream source = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            webBrowser1.DocumentStream = source;
        }*/
    }
}
