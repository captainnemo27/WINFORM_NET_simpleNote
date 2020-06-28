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
using System.Windows.Forms.VisualStyles;
using System.Threading;
using System.Drawing.Text;

namespace SimpleNote.Views
{
    public partial class frm_Note : Form
    {
        
        public User currentUser;
        public SaveFileDialog sfd;//instance of savefiledialog to save files       

        public OpenFileDialog ofd;//instance of openfiledialog to open files       
        Image imgflag;
        List<Image> _listImage;
        public int index;
        public string[] RTBRedoUndo;
        public int StackCount = 0;
        public int OldLength = 0;
        public int ChangeToSave = 5;
        public bool IsRedoUndo = false;
        public frm_Note(User user)
        {
            InitializeComponent();
            
            currentUser = user;
            toolStripLabel1.Text = " User : " + currentUser.UserName;
            DisplayNote();
            int size = 14;
            this.richText_Note.Font = new Font("Times New Roman", size);
            _listImage = new List<Image>();
            
        }
        public frm_Note()
        {
            
            InitializeComponent();
        }

        private void frm_Note_Load(object sender, EventArgs e)
        {

            for (int i = 0; i <= 120; i++)
            {
                comboBox_Size.Items.Add(i);
            }
            
            InstalledFontCollection listfont = new InstalledFontCollection();
            foreach (FontFamily font in listfont.Families)
            {
                comboBox_TextStyle.Items.Add(font.Name);
            }
            
        }

        private void comboBox_TextStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string font = this.comboBox_TextStyle.SelectedItem.ToString();
            float size;
            if (comboBox_Size.SelectedItem == null)
                size = 14.0f;
            else
                size = float.Parse(this.comboBox_Size.SelectedItem.ToString()) * 1.0f;
            Font myfont = new Font(font, size);
            string t = this.richText_Note.SelectedText;
            if (t != "")
            {

                this.richText_Note.Font = new Font(font, size);
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
                this.richText_Note.Font = new Font(font, size);
                this.richText_Note.SelectedText = t;
                return;
            }
            else
            {
                this.richText_Note.Font = new Font(font, size);
                return;
            }


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
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.Font));
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.Size.ToString()));
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.ColorBg));
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.ColorText));
                this.listView_ListNote.Items.Add(Note);
            }
            
            
        }
        private void DisplayNote_find(string title)
        {
            List<Note> lstNote = NoteController.getlistNote(title,currentUser.UserName);

            this.listView_ListNote.Items.Clear();
            foreach (Note notess in lstNote)
            {
                ListViewItem Note = new ListViewItem(notess.ID.ToString());
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.Title_Note));
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.RichTextNote));
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.Font));
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.Size.ToString()));
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.ColorBg));
                Note.SubItems.Add(new ListViewItem.ListViewSubItem(Note, notess.ColorText));
                this.listView_ListNote.Items.Add(Note);
            }
        }
        private void listView_ListNote_Click(object sender, EventArgs e)
        {
            this.textBox_TitleNote.Text = this.listView_ListNote.SelectedItems[0].SubItems[1].Text.Trim();
            this.richText_Note.Text = this.listView_ListNote.SelectedItems[0].SubItems[2].Text.Trim();
            this.richText_Note.Font = new Font(this.listView_ListNote.SelectedItems[0].SubItems[3].Text.Trim(),int.Parse(this.listView_ListNote.SelectedItems[0].SubItems[4].Text.Trim()));
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    using (FileStream stream = new FileStream(string.Format("{0}.jpg",
                this.listView_ListNote.SelectedItems[0].Text.Trim() + currentUser.UserName + i), FileMode.Open, FileAccess.Read))
                    {
                        imgflag = Image.FromStream(stream);
                        Clipboard.SetDataObject(imgflag);
                        DataFormats.Format df;
                        df = DataFormats.GetFormat(DataFormats.Bitmap);
                        if (this.richText_Note.CanPaste(df))
                            richText_Note.Paste(df);
                        this._listImage.Add(imgflag);
                    }
                }
                catch { }
            }
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
                imgflag = img;
            }
            
                this._listImage.Add(imgflag);
        }
        
        private void button_Add_Click(object sender, EventArgs e)
        {
            toolStripButton_loading.Visible = true;
            Note _note = new Note();
            var id = NoteController.getIDfromDB(this.currentUser.UserName);
            _note.ID = id;
            _note.Title_Note = this.textBox_TitleNote.Text;
            _note.RichTextNote = this.richText_Note.Text;
            _note.User_k = this.currentUser.UserName;
            _note.Size = int.Parse(this.richText_Note.Font.Size.ToString());
            _note.ColorText = this.richText_Note.ForeColor.ToString();
            _note.ColorBg = this.richText_Note.BackColor.ToString();
            _note.Font = this.richText_Note.Font.Name;
            
            if (_note.Title_Note == "")
            {
                _note.Title_Note = "Note " + id.ToString();
            }
            if(this._listImage.Count()>0)
            try
            {
                for (int i = 0; i < this._listImage.Count(); i++)
                {
                    this._listImage[i].Save(string.Format("{0}.jpg", id + _note.User_k + i));
                }
                this._listImage.Clear();
            }
            catch { }
            // add bằng DB
            if (NoteController.AddNote(_note))
            {
                MessageBox.Show("Add note secessfull ");
            }
            
            this.textBox_TitleNote.ResetText();
            this.richText_Note.ResetText();
            DisplayNote();
            toolStripButton_loading.Visible = false;
            resetRichText();
        }
        private void OpenFile()

        {
            toolStripButton_loading.Visible = true;
            //putting title of openfiledialog to Open Document      

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = ".txt|*.txt|.doc|*.doc";
            open.RestoreDirectory = true;
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                if(open.Filter == ".txt|*.txt")
                {
                    richText_Note.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richText_Note.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
                }
                
            }
            toolStripButton_loading.Visible = false;
        }

        private void richText_Note_TextChanged(object sender, EventArgs e)
        {
            String str = this.richText_Note.Text;
            

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

        private void openTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(int.Parse(this.listView_ListNote.SelectedItems[0].Text) >= 0)
            {
                NoteController.DeleteNote(currentUser, int.Parse(this.listView_ListNote.SelectedItems[0].Text));
                DisplayNote();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            toolStripButton_loading.Visible = true;
            try
            {
                if (int.Parse(this.listView_ListNote.SelectedItems[0].Text) >= 0)
                {
                    Note _note = new Note();
                    var id = int.Parse(this.listView_ListNote.SelectedItems[0].Text);
                    _note.ID = id;
                    _note.Title_Note = this.textBox_TitleNote.Text;
                    _note.RichTextNote = this.richText_Note.Text;
                    _note.User_k = this.currentUser.UserName;
                    _note.Size = int.Parse(this.richText_Note.Font.Size.ToString());
                    _note.ColorText = this.richText_Note.ForeColor.ToString();
                    _note.ColorBg = this.richText_Note.BackColor.ToString();
                    _note.Font = this.richText_Note.Font.Name;
                    if (_note.Title_Note == "")
                    {
                        _note.Title_Note = "Note " + id.ToString();
                    }
                    NoteController.SaveNote(_note);
                    DisplayNote();
                }
            }
            catch { }
            toolStripButton_loading.Visible = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.listView_ListNote.SelectedItems[0].Text) >= 0)
            {
                Note _note = new Note();
                var id = int.Parse(this.listView_ListNote.SelectedItems[0].Text);
                _note.ID = id;
                _note.Title_Note = this.textBox_TitleNote.Text;
                _note.RichTextNote = this.richText_Note.Text;
                _note.User_k = this.currentUser.UserName;
                _note.Size = int.Parse(this.richText_Note.Font.Size.ToString());
                _note.ColorText = this.richText_Note.ForeColor.ToString();
                _note.ColorBg = this.richText_Note.BackColor.ToString();
                _note.Font = this.richText_Note.Font.Name;
                NoteController.SaveNote(_note);
                DisplayNote();
            }

        }
        private void resetRichText()
        {
            this.richText_Note.ResetText();
            this.textBox_TitleNote.ResetText();
        }

        private void button_Newnote_Click(object sender, EventArgs e)
        {
            resetRichText();
            }


        private void coppyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richText_Note.Copy();   
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richText_Note.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richText_Note.Paste();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cr = new ColorDialog();

            if (cr.ShowDialog() == DialogResult.OK)

            {

                this.richText_Note.BackColor = cr.Color;

            }
        }

        private void button_ColorText_Click(object sender, EventArgs e)
        {
            ColorDialog cr = new ColorDialog();

            if (cr.ShowDialog() == DialogResult.OK)

            {

                this.richText_Note.ForeColor = cr.Color;

            }
        }
        public void FindNext(string str)//user defind function for Findig value into ichtextbox      

        //and perform search operaiton     

        {

            try

            {

                // int result = richTextBox1.Find(str, index, str.Length, RichTextBoxFinds.WholeWord);

                if (index == -1)

                {

                    MessageBox.Show("Word Search Complete");

                }

                else

                {

                    int starting = this.richText_Note.Text.IndexOf(str, index);

                    this.richText_Note.Select(starting, str.Length);

                    this.richText_Note.Focus();

                    index = starting + str.Length;

                }

            }

            catch (SystemException s)

            {

                MessageBox.Show(s.Message.ToString(), "Error message");

            }
            
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label4.Visible = true;
            this.textbox_findnote.Visible = true;

            this.button_findDone.Visible = true;
        }

       
        private void button_selectFont_Click(object sender, EventArgs e)
        {
            FontDialog selectFont = new FontDialog();
            selectFont.ShowDialog();
            string font = selectFont.Font.Name;
            var size = selectFont.Font.Size;
            var fontstyle = selectFont.Font.Style;
            this.richText_Note.Font = new Font(font, size, fontstyle);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = ".txt|*.txt|.doc|*.doc";
            save.RestoreDirectory = true;
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {   if(save.Filter == ".txt|*.txt")
                {
                    richText_Note.SaveFile(save.FileName, RichTextBoxStreamType.TextTextOleObjs);
                }
                else
                {
                    richText_Note.SaveFile(save.FileName, RichTextBoxStreamType.RichNoOleObjs);
                }
            }
            resetRichText();
        }

        private void button_findDone_Click(object sender, EventArgs e)
        {
            this.label4.Visible = false;
            this.textbox_findnote.Visible = true;
            DisplayNote();
            this.textBox_TitleNote.ResetText();
            this.button_findDone.Visible = false;
            

        }

        private void textbox_findnote_TextChanged(object sender, EventArgs e)
        {
            string title = this.textbox_findnote.Text;
            DisplayNote_find(title);
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.listView_ListNote.SelectedItems[0].Text) >= 0)
            {
                NoteController.DeleteNote(currentUser, int.Parse(this.listView_ListNote.SelectedItems[0].Text));
                DisplayNote();
            }
            MessageBox.Show("Delete note secessfull :)");
            resetRichText();
        }

        private void helpingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" you can contact with our email: thangdao2018@gmail.com");
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            FontStyle style = richText_Note.SelectionFont.Style;
            if (richText_Note.SelectionFont.Bold)
            {
                style = style & ~FontStyle.Bold;
            }
            else
            {
                style = style | FontStyle.Bold;
            }
            richText_Note.SelectionFont = new Font(richText_Note.SelectionFont, style);
        }

        private void toolStripButton_Italic_Click(object sender, EventArgs e)
        {
            FontStyle style = richText_Note.SelectionFont.Style;
            if (richText_Note.SelectionFont.Italic)
                style = style & ~FontStyle.Italic;
            else
                style = style | FontStyle.Italic;
            richText_Note.SelectionFont = new Font(richText_Note.SelectionFont, style);
        }

        private void toolStripButton_Underline_Click(object sender, EventArgs e)
        {
            FontStyle style = richText_Note.SelectionFont.Style;
            if (richText_Note.SelectionFont.Underline)
                style = style & ~FontStyle.Underline;
            else
                style = style | FontStyle.Underline;
            richText_Note.SelectionFont = new Font(richText_Note.SelectionFont, style);
        }

        private void toolStripButton_alignL_Click(object sender, EventArgs e)
        {
            richText_Note.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton_alignM_Click(object sender, EventArgs e)
        {
            richText_Note.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton_alignR_Click(object sender, EventArgs e)
        {
            richText_Note.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
