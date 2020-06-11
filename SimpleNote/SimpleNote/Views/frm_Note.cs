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
using SimpleNote.Controllers;


namespace SimpleNote.Views
{
    public partial class frm_Note : Form
    {
        //private List<Notes> _listNotes;
        public User currentUser;
        public SaveFileDialog sfd;//instance of savefiledialog to save files       

        public OpenFileDialog ofd;//instance of openfiledialog to open files       

        public int index;
        public frm_Note(User user)
        {
            InitializeComponent();
            currentUser = user;
            sfd = new SaveFileDialog();

            ofd = new OpenFileDialog();

        }
        public frm_Note()
        {
            InitializeComponent();
            //string text_note;
        }

        private void frm_Note_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
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
            float size = float.Parse(this.comboBox_Size.SelectedItem.ToString()) * 1.0f;

            string t = this.richText_Note.SelectedText;
            if (t != "")
            {

                this.richText_Note.SelectionFont = new Font(font, size);
                this.richText_Note.SelectedText = t;
                return;
            }


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
            Note _note = new Note();
            var id = NoteController.getIDfromDB(this.currentUser.UserName);
            _note.ID = id;
            _note.Title_Note = this.textBox_TitleNote.Text;
            _note.RichTextNote = this.richText_Note.Text;
            _note.User_k = this.currentUser.UserName;



            // add bằng DB
            NoteController.AddNote(_note);

            this.textBox_TitleNote.ResetText();
            this.richText_Note.ResetText();
            DisplayNote();
        }
        
        private void DisplayNote()
        {
            List<Note> lstNote = NoteController.getAllNote(currentUser.UserName);
            this.listView_ListNote.Items.Clear();
            foreach (Note notess in lstNote)
            {
                ListViewItem Note = new ListViewItem(notess.ID.ToString());
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.Title_Note));
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.RichTextNote));
                this.listView_ListNote.Items.Add(Note);
            }
            //OpenFile();
        }

        private void listView_ListNote_Click(object sender, EventArgs e)
        {
            this.textBox_TitleNote.Text = this.listView_ListNote.SelectedItems[0].SubItems[1].Text.Trim();
            this.richText_Note.Text = this.listView_ListNote.SelectedItems[0].SubItems[2].Text.Trim();
        }

        private void insertImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Bitmap File| *.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(dlg.FileName);
                Clipboard.SetDataObject(img);
                DataFormats.Format df;
                df = DataFormats.GetFormat(DataFormats.Bitmap);
                if (this.richText_Note.CanPaste(df))
                    richText_Note.Paste(df);
            }

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Note _note = new Note();
            var id = NoteController.getIDfromDB(this.currentUser.UserName);
            _note.ID = id;
            _note.Title_Note = this.textBox_TitleNote.Text;
            _note.RichTextNote = this.richText_Note.Text;
            _note.User_k = this.currentUser.UserName;


            // lưu file
            sfd.Title = "Save As";

            sfd.Filter = "Text Document|*.txt";

            sfd.DefaultExt = "txt";

            sfd.ShowDialog();



            richText_Note.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);

            this.Text = sfd.FileName;

            // add bằng DB
            NoteController.AddNote(_note);

            this.textBox_TitleNote.ResetText();
            this.richText_Note.ResetText();
            DisplayNote();
        }
        private void OpenFile()

        {

            //putting title of openfiledialog to Open Document      

            ofd.Title = "Open Document";

            ofd.DefaultExt = "txt";     

            ofd.Filter = "Text Files|*.txt";//appliing filter   

            ofd.FileName = string.Empty;//setting filename box to blank       

            if (ofd.ShowDialog() == DialogResult.OK)

            {

                if (ofd.FileName == String.Empty)

                {

                    return;

                }

                else

                {

                    //reading or loading selected file into richtextbox      

                    string str = ofd.FileName;

                    this.richText_Note.LoadFile(str, RichTextBoxStreamType.PlainText);

                    this.Text = ofd.FileName;

                }

            }
        }

        private void richText_Note_TextChanged(object sender, EventArgs e)
        {
            String str = this.richText_Note.Text;
            /*if (str.Contains("*"))
            {

            }
            else
            {
                this.Text = str + "*";
            }*/

            // làm hastag
            int sel = this.richText_Note.SelectionStart;
            int line = this.richText_Note.GetLineFromCharIndex(sel) + 1;
            int col = sel - this.richText_Note.GetFirstCharIndexFromLine(line - 1) + 1;
            this.richText_Note.GetFirstCharIndexFromLine(col);
            
            if (str.StartsWith("#") && str.EndsWith(" "))
            {
                
                this.richText_Note.Font = new Font(this.richText_Note.Font.Name.ToString(),this.richText_Note.Font.Size , FontStyle.Bold);
                this.richText_Note.AppendText(this.richText_Note.Text);
                this.richText_Note.Font = new Font(this.richText_Note.Font.Name.ToString(), this.richText_Note.Font.Size, FontStyle.Regular);
            }
        }

        private void richText_Note_SelectionChanged(object sender, EventArgs e)
        {
            int sel = this.richText_Note.SelectionStart;
            int line = this.richText_Note.GetLineFromCharIndex(sel) + 1;
            int col = sel - this.richText_Note.GetFirstCharIndexFromLine(line - 1) + 1;

            this.toolStripLabel_Line.Text = "Line : " + line.ToString();
            this.toolStripLabel_Col.Text = "Col : " + col.ToString();
        }
    }
}
