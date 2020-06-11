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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView_ListNote = new System.Windows.Forms.ListView();
            this.column_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Title_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.radioButton_Regular = new System.Windows.Forms.RadioButton();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.comboBox_TextStyle = new System.Windows.Forms.ComboBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_TitleNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.richText_Note = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Line = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_Col = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.listView_ListNote);
            this.splitContainer1.Panel1.Controls.Add(this.splitter2);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton_Regular);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_Size);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_TextStyle);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.button_Save);
            this.splitContainer1.Panel2.Controls.Add(this.button_Add);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_TitleNote);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.richText_Note);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1139, 612);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView_ListNote
            // 
            this.listView_ListNote.AllowColumnReorder = true;
            this.listView_ListNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_ListNote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Id,
            this.column_Title_Note,
            this.column_Note});
            this.listView_ListNote.GridLines = true;
            this.listView_ListNote.HideSelection = false;
            this.listView_ListNote.Location = new System.Drawing.Point(3, 271);
            this.listView_ListNote.Name = "listView_ListNote";
            this.listView_ListNote.Size = new System.Drawing.Size(448, 276);
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
            this.column_Title_Note.Width = 77;
            // 
            // column_Note
            // 
            this.column_Note.Text = "Note";
            this.column_Note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Note.Width = 316;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 262);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(457, 350);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // radioButton_Regular
            // 
            this.radioButton_Regular.AutoSize = true;
            this.radioButton_Regular.Font = new System.Drawing.Font("UTM Cafeta", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Regular.Location = new System.Drawing.Point(137, 58);
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
            this.comboBox_Size.Location = new System.Drawing.Point(274, 28);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Size.TabIndex = 1;
            this.comboBox_Size.SelectedIndexChanged += new System.EventHandler(this.comboBox_Size_SelectedIndexChanged);
            // 
            // comboBox_TextStyle
            // 
            this.comboBox_TextStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TextStyle.FormattingEnabled = true;
            this.comboBox_TextStyle.Location = new System.Drawing.Point(137, 28);
            this.comboBox_TextStyle.Name = "comboBox_TextStyle";
            this.comboBox_TextStyle.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TextStyle.TabIndex = 0;
            this.comboBox_TextStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox_TextStyle_SelectedIndexChanged);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("UTM Charlemagne", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Save.Location = new System.Drawing.Point(533, 21);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("UTM Charlemagne", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Add.Location = new System.Drawing.Point(452, 22);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_TitleNote
            // 
            this.textBox_TitleNote.Location = new System.Drawing.Point(124, 24);
            this.textBox_TitleNote.Name = "textBox_TitleNote";
            this.textBox_TitleNote.Size = new System.Drawing.Size(311, 20);
            this.textBox_TitleNote.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Androgyne", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title Of Note";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(678, 61);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // richText_Note
            // 
            this.richText_Note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richText_Note.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richText_Note.Location = new System.Drawing.Point(16, 82);
            this.richText_Note.Name = "richText_Note";
            this.richText_Note.Size = new System.Drawing.Size(636, 507);
            this.richText_Note.TabIndex = 0;
            this.richText_Note.Text = "";
            this.richText_Note.SelectionChanged += new System.EventHandler(this.richText_Note_SelectionChanged);
            this.richText_Note.TextChanged += new System.EventHandler(this.richText_Note_TextChanged);
            this.richText_Note.MouseEnter += new System.EventHandler(this.richText_Note_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editToolStripMenuItem,
            this.controllerToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertImageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // insertImageToolStripMenuItem
            // 
            this.insertImageToolStripMenuItem.Name = "insertImageToolStripMenuItem";
            this.insertImageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.insertImageToolStripMenuItem.Text = "Insert image";
            this.insertImageToolStripMenuItem.Click += new System.EventHandler(this.insertImageToolStripMenuItem_Click);
            // 
            // controllerToolStripMenuItem
            // 
            this.controllerToolStripMenuItem.Name = "controllerToolStripMenuItem";
            this.controllerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.controllerToolStripMenuItem.Text = "Controller";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Line,
            this.toolStripLabel_Col});
            this.toolStrip1.Location = new System.Drawing.Point(0, 587);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_Line
            // 
            this.toolStripLabel_Line.Name = "toolStripLabel_Line";
            this.toolStripLabel_Line.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel_Line.Text = "Line";
            this.toolStripLabel_Line.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripLabel_Col
            // 
            this.toolStripLabel_Col.Name = "toolStripLabel_Col";
            this.toolStripLabel_Col.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel_Col.Text = "Col";
            // 
            // frm_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 636);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Note";
            this.Text = "frm_Note";
            this.Load += new System.EventHandler(this.frm_Note_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertImageToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Line;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Col;
    }
}