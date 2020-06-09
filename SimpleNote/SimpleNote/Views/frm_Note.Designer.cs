namespace SimpleNote.Views
{
    partial class frm_Note
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Note));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView_ListNote = new System.Windows.Forms.ListView();
            this.column_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Title_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioButton_Regular = new System.Windows.Forms.RadioButton();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.comboBox_TextStyle = new System.Windows.Forms.ComboBox();
            this.textBox_TitleNote = new System.Windows.Forms.TextBox();
            this.richText_Note = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1139, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(52, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView_ListNote);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton_Regular);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_Size);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_TextStyle);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox_TitleNote);
            this.splitContainer1.Panel2.Controls.Add(this.richText_Note);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1050, 555);
            this.splitContainer1.SplitterDistance = 469;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView_ListNote
            // 
            this.listView_ListNote.AllowColumnReorder = true;
            this.listView_ListNote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Id,
            this.column_Title_Note,
            this.column_Note});
            this.listView_ListNote.GridLines = true;
            this.listView_ListNote.HideSelection = false;
            this.listView_ListNote.Location = new System.Drawing.Point(3, 278);
            this.listView_ListNote.Name = "listView_ListNote";
            this.listView_ListNote.Size = new System.Drawing.Size(463, 261);
            this.listView_ListNote.TabIndex = 3;
            this.listView_ListNote.UseCompatibleStateImageBehavior = false;
            this.listView_ListNote.View = System.Windows.Forms.View.Details;
            this.listView_ListNote.Click += new System.EventHandler(this.listView_ListNote_Click);
            // 
            // column_Id
            // 
            this.column_Id.Text = "ID";
            this.column_Id.Width = 38;
            // 
            // column_Title_Note
            // 
            this.column_Title_Note.Text = "Title";
            // 
            // column_Note
            // 
            this.column_Note.Text = "Note";
            this.column_Note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Note.Width = 256;
            // 
            // radioButton_Regular
            // 
            this.radioButton_Regular.AutoSize = true;
            this.radioButton_Regular.Font = new System.Drawing.Font("UTM Cafeta", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Regular.Location = new System.Drawing.Point(15, 56);
            this.radioButton_Regular.Name = "radioButton_Regular";
            this.radioButton_Regular.Size = new System.Drawing.Size(51, 18);
            this.radioButton_Regular.TabIndex = 2;
            this.radioButton_Regular.TabStop = true;
            this.radioButton_Regular.Text = "Regular";
            this.radioButton_Regular.UseVisualStyleBackColor = true;
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "12",
            "14",
            "16",
            "24",
            "48",
            "72"});
            this.comboBox_Size.Location = new System.Drawing.Point(152, 28);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Size.TabIndex = 1;
            this.comboBox_Size.SelectedIndexChanged += new System.EventHandler(this.comboBox_Size_SelectedIndexChanged);
            // 
            // comboBox_TextStyle
            // 
            this.comboBox_TextStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TextStyle.FormattingEnabled = true;
            this.comboBox_TextStyle.Location = new System.Drawing.Point(15, 28);
            this.comboBox_TextStyle.Name = "comboBox_TextStyle";
            this.comboBox_TextStyle.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TextStyle.TabIndex = 0;
            this.comboBox_TextStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox_TextStyle_SelectedIndexChanged);
            // 
            // textBox_TitleNote
            // 
            this.textBox_TitleNote.Location = new System.Drawing.Point(4, 16);
            this.textBox_TitleNote.Name = "textBox_TitleNote";
            this.textBox_TitleNote.Size = new System.Drawing.Size(570, 20);
            this.textBox_TitleNote.TabIndex = 1;
            // 
            // richText_Note
            // 
            this.richText_Note.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richText_Note.Location = new System.Drawing.Point(6, 42);
            this.richText_Note.Name = "richText_Note";
            this.richText_Note.Size = new System.Drawing.Size(571, 513);
            this.richText_Note.TabIndex = 0;
            this.richText_Note.Text = "";
            this.richText_Note.MouseEnter += new System.EventHandler(this.richText_Note_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.addNoteToolStripMenuItem.Text = "AddNote";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // frm_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 636);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Note";
            this.Text = "frm_Note";
            this.Load += new System.EventHandler(this.frm_Note_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richText_Note;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RadioButton radioButton_Regular;
        private System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.ComboBox comboBox_TextStyle;
        private System.Windows.Forms.ListView listView_ListNote;
        private System.Windows.Forms.ColumnHeader column_Id;
        private System.Windows.Forms.ColumnHeader column_Title_Note;
        private System.Windows.Forms.ColumnHeader column_Note;
        private System.Windows.Forms.TextBox textBox_TitleNote;
    }
}