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
            this.textbox_findnote = new System.Windows.Forms.TextBox();
            this.button_findDone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Bold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Italic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_alignL = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_alignM = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_alignR = new System.Windows.Forms.ToolStripButton();
            this.button_selectFont = new System.Windows.Forms.Button();
            this.button_ColorText = new System.Windows.Forms.Button();
            this.button_Newnote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_ListNote = new System.Windows.Forms.ListView();
            this.column_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Title_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Font = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ColorBg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ColorText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.comboBox_TextStyle = new System.Windows.Forms.ComboBox();
            this.button_Del = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Line = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_Col = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_loading = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TitleNote = new System.Windows.Forms.TextBox();
            this.richText_Note = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coppyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.textbox_findnote);
            this.splitContainer1.Panel1.Controls.Add(this.button_findDone);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel1.Controls.Add(this.button_selectFont);
            this.splitContainer1.Panel1.Controls.Add(this.button_ColorText);
            this.splitContainer1.Panel1.Controls.Add(this.button_Newnote);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.listView_ListNote);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_Size);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_TextStyle);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.button_Del);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.button_Save);
            this.splitContainer1.Panel2.Controls.Add(this.button_Add);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_TitleNote);
            this.splitContainer1.Panel2.Controls.Add(this.richText_Note);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1139, 612);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 1;
            // 
            // textbox_findnote
            // 
            this.textbox_findnote.Location = new System.Drawing.Point(12, 156);
            this.textbox_findnote.Name = "textbox_findnote";
            this.textbox_findnote.Size = new System.Drawing.Size(197, 20);
            this.textbox_findnote.TabIndex = 9;
            this.textbox_findnote.Visible = false;
            this.textbox_findnote.TextChanged += new System.EventHandler(this.textbox_findnote_TextChanged);
            // 
            // button_findDone
            // 
            this.button_findDone.BackColor = System.Drawing.Color.Transparent;
            this.button_findDone.Font = new System.Drawing.Font("UTM Facebook K&T", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_findDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_findDone.Location = new System.Drawing.Point(215, 153);
            this.button_findDone.Name = "button_findDone";
            this.button_findDone.Size = new System.Drawing.Size(75, 23);
            this.button_findDone.TabIndex = 13;
            this.button_findDone.Text = "OK";
            this.button_findDone.UseVisualStyleBackColor = false;
            this.button_findDone.Visible = false;
            this.button_findDone.Click += new System.EventHandler(this.button_findDone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Facebook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Find title";
            this.label4.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Bold,
            this.toolStripButton_Italic,
            this.toolStripButton_Underline,
            this.toolStripButton_alignL,
            this.toolStripButton_alignM,
            this.toolStripButton_alignR});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(457, 25);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton_Bold
            // 
            this.toolStripButton_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Bold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Bold.Image")));
            this.toolStripButton_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Bold.Name = "toolStripButton_Bold";
            this.toolStripButton_Bold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Bold.Text = "toolStripButton1";
            this.toolStripButton_Bold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripButton_Italic
            // 
            this.toolStripButton_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Italic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Italic.Image")));
            this.toolStripButton_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Italic.Name = "toolStripButton_Italic";
            this.toolStripButton_Italic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Italic.Text = "toolStripButton2";
            this.toolStripButton_Italic.Click += new System.EventHandler(this.toolStripButton_Italic_Click);
            // 
            // toolStripButton_Underline
            // 
            this.toolStripButton_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Underline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Underline.Image")));
            this.toolStripButton_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Underline.Name = "toolStripButton_Underline";
            this.toolStripButton_Underline.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Underline.Text = "toolStripButton3";
            this.toolStripButton_Underline.Click += new System.EventHandler(this.toolStripButton_Underline_Click);
            // 
            // toolStripButton_alignL
            // 
            this.toolStripButton_alignL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_alignL.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_alignL.Image")));
            this.toolStripButton_alignL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_alignL.Name = "toolStripButton_alignL";
            this.toolStripButton_alignL.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_alignL.Text = "toolStripButton4";
            this.toolStripButton_alignL.Click += new System.EventHandler(this.toolStripButton_alignL_Click);
            // 
            // toolStripButton_alignM
            // 
            this.toolStripButton_alignM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_alignM.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_alignM.Image")));
            this.toolStripButton_alignM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_alignM.Name = "toolStripButton_alignM";
            this.toolStripButton_alignM.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_alignM.Text = "toolStripButton5";
            this.toolStripButton_alignM.Click += new System.EventHandler(this.toolStripButton_alignM_Click);
            // 
            // toolStripButton_alignR
            // 
            this.toolStripButton_alignR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_alignR.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_alignR.Image")));
            this.toolStripButton_alignR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_alignR.Name = "toolStripButton_alignR";
            this.toolStripButton_alignR.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_alignR.Text = "toolStripButton6";
            this.toolStripButton_alignR.Click += new System.EventHandler(this.toolStripButton_alignR_Click);
            // 
            // button_selectFont
            // 
            this.button_selectFont.BackColor = System.Drawing.Color.Transparent;
            this.button_selectFont.Font = new System.Drawing.Font("UTM Facebook K&T", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selectFont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_selectFont.Location = new System.Drawing.Point(373, 55);
            this.button_selectFont.Name = "button_selectFont";
            this.button_selectFont.Size = new System.Drawing.Size(75, 23);
            this.button_selectFont.TabIndex = 9;
            this.button_selectFont.Text = "Font";
            this.button_selectFont.UseVisualStyleBackColor = false;
            this.button_selectFont.Click += new System.EventHandler(this.button_selectFont_Click);
            // 
            // button_ColorText
            // 
            this.button_ColorText.BackColor = System.Drawing.Color.Transparent;
            this.button_ColorText.Font = new System.Drawing.Font("UTM Facebook K&T", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ColorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_ColorText.Location = new System.Drawing.Point(292, 55);
            this.button_ColorText.Name = "button_ColorText";
            this.button_ColorText.Size = new System.Drawing.Size(75, 23);
            this.button_ColorText.TabIndex = 8;
            this.button_ColorText.Text = "Color text";
            this.button_ColorText.UseVisualStyleBackColor = false;
            this.button_ColorText.Click += new System.EventHandler(this.button_ColorText_Click);
            // 
            // button_Newnote
            // 
            this.button_Newnote.BackColor = System.Drawing.Color.Transparent;
            this.button_Newnote.Font = new System.Drawing.Font("UTM Facebook K&T", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Newnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Newnote.Location = new System.Drawing.Point(12, 82);
            this.button_Newnote.Name = "button_Newnote";
            this.button_Newnote.Size = new System.Drawing.Size(75, 23);
            this.button_Newnote.TabIndex = 7;
            this.button_Newnote.Text = "New";
            this.button_Newnote.UseVisualStyleBackColor = false;
            this.button_Newnote.Click += new System.EventHandler(this.button_Newnote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Facebook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(147, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Facebook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Font";
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
            this.column_Note,
            this.column_Font,
            this.column_Size,
            this.column_ColorBg,
            this.column_ColorText});
            this.listView_ListNote.Font = new System.Drawing.Font("UTM Facebook K&T", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ListNote.ForeColor = System.Drawing.Color.Red;
            this.listView_ListNote.GridLines = true;
            this.listView_ListNote.HideSelection = false;
            this.listView_ListNote.Location = new System.Drawing.Point(3, 196);
            this.listView_ListNote.Name = "listView_ListNote";
            this.listView_ListNote.Size = new System.Drawing.Size(448, 413);
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
            this.column_Note.Width = 332;
            // 
            // column_Font
            // 
            this.column_Font.Text = "Font";
            // 
            // column_Size
            // 
            this.column_Size.Text = "Size";
            // 
            // column_ColorBg
            // 
            this.column_ColorBg.Text = "ColorBg";
            // 
            // column_ColorText
            // 
            this.column_ColorText.Text = "ColorText";
            this.column_ColorText.Width = 75;
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Location = new System.Drawing.Point(151, 55);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Size.TabIndex = 1;
            this.comboBox_Size.SelectedIndexChanged += new System.EventHandler(this.comboBox_Size_SelectedIndexChanged);
            // 
            // comboBox_TextStyle
            // 
            this.comboBox_TextStyle.FormattingEnabled = true;
            this.comboBox_TextStyle.Location = new System.Drawing.Point(12, 55);
            this.comboBox_TextStyle.Name = "comboBox_TextStyle";
            this.comboBox_TextStyle.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TextStyle.TabIndex = 0;
            this.comboBox_TextStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox_TextStyle_SelectedIndexChanged);
            // 
            // button_Del
            // 
            this.button_Del.Font = new System.Drawing.Font("UTM Charlemagne", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Del.Location = new System.Drawing.Point(533, 53);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(75, 23);
            this.button_Del.TabIndex = 8;
            this.button_Del.Text = "Delete";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Line,
            this.toolStripLabel_Col,
            this.toolStripButton_loading,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 587);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_Line
            // 
            this.toolStripLabel_Line.Font = new System.Drawing.Font("UTM Facebook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_Line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripLabel_Line.Name = "toolStripLabel_Line";
            this.toolStripLabel_Line.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel_Line.Text = "Line";
            this.toolStripLabel_Line.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripLabel_Col
            // 
            this.toolStripLabel_Col.Font = new System.Drawing.Font("UTM Facebook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_Col.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripLabel_Col.Name = "toolStripLabel_Col";
            this.toolStripLabel_Col.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel_Col.Text = "Col";
            // 
            // toolStripButton_loading
            // 
            this.toolStripButton_loading.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_loading.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_loading.Image")));
            this.toolStripButton_loading.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_loading.Name = "toolStripButton_loading";
            this.toolStripButton_loading.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_loading.Text = "toolStripButton7";
            this.toolStripButton_loading.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "user";
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
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Facebook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title Of Note";
            // 
            // textBox_TitleNote
            // 
            this.textBox_TitleNote.Location = new System.Drawing.Point(124, 27);
            this.textBox_TitleNote.Name = "textBox_TitleNote";
            this.textBox_TitleNote.Size = new System.Drawing.Size(302, 20);
            this.textBox_TitleNote.TabIndex = 1;
            // 
            // richText_Note
            // 
            this.richText_Note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richText_Note.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richText_Note.Location = new System.Drawing.Point(16, 82);
            this.richText_Note.Name = "richText_Note";
            this.richText_Note.Size = new System.Drawing.Size(636, 479);
            this.richText_Note.TabIndex = 0;
            this.richText_Note.Text = "";
            this.richText_Note.SelectionChanged += new System.EventHandler(this.richText_Note_SelectionChanged);
            this.richText_Note.TextChanged += new System.EventHandler(this.richText_Note_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.controllerToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openTextToolStripMenuItem
            // 
            this.openTextToolStripMenuItem.Name = "openTextToolStripMenuItem";
            this.openTextToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.openTextToolStripMenuItem.Text = "Open Text";
            this.openTextToolStripMenuItem.Click += new System.EventHandler(this.openTextToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertImageToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.coppyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
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
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // coppyToolStripMenuItem
            // 
            this.coppyToolStripMenuItem.Name = "coppyToolStripMenuItem";
            this.coppyToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.coppyToolStripMenuItem.Text = "Copy";
            this.coppyToolStripMenuItem.Click += new System.EventHandler(this.coppyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // controllerToolStripMenuItem
            // 
            this.controllerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
            this.controllerToolStripMenuItem.Name = "controllerToolStripMenuItem";
            this.controllerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.controllerToolStripMenuItem.Text = "Controller";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpingToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpingToolStripMenuItem
            // 
            this.helpingToolStripMenuItem.Name = "helpingToolStripMenuItem";
            this.helpingToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.helpingToolStripMenuItem.Text = "Helping";
            this.helpingToolStripMenuItem.Click += new System.EventHandler(this.helpingToolStripMenuItem_Click);
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
            this.Text = "Simple Note";
            this.Load += new System.EventHandler(this.frm_Note_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richText_Note;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FontDialog fontDialog1;
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
        private System.Windows.Forms.ToolStripMenuItem insertImageToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Line;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Col;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button button_Newnote;
        private System.Windows.Forms.ToolStripMenuItem coppyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Button button_ColorText;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.Button button_selectFont;
        private System.Windows.Forms.ColumnHeader column_Font;
        private System.Windows.Forms.ColumnHeader column_Size;
        private System.Windows.Forms.ColumnHeader column_ColorBg;
        private System.Windows.Forms.ColumnHeader column_ColorText;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Bold;
        private System.Windows.Forms.ToolStripButton toolStripButton_Italic;
        private System.Windows.Forms.ToolStripButton toolStripButton_Underline;
        private System.Windows.Forms.ToolStripButton toolStripButton_alignL;
        private System.Windows.Forms.ToolStripButton toolStripButton_alignM;
        private System.Windows.Forms.ToolStripButton toolStripButton_alignR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_findDone;
        private System.Windows.Forms.TextBox textbox_findnote;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.ToolStripButton toolStripButton_loading;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpingToolStripMenuItem;
    }
}