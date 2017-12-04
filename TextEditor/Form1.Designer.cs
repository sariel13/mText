namespace TextEditor
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbBoard = new System.Windows.Forms.RichTextBox();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbTextSize = new System.Windows.Forms.ComboBox();
            this.cbFontName = new System.Windows.Forms.ComboBox();
            this.btnHighlight = new System.Windows.Forms.Button();
            this.btnCentralAlign = new System.Windows.Forms.Button();
            this.btnLeftAlign = new System.Windows.Forms.Button();
            this.btnRightAlign = new System.Windows.Forms.Button();
            this.btnStriketrough = new System.Windows.Forms.Button();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.tbFindString = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblWordCounter = new System.Windows.Forms.Label();
            this.lblCharCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(66, 25);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Otvori fajl";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbBoard
            // 
            this.rtbBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbBoard.Font = new System.Drawing.Font("Tahoma", 8F);
            this.rtbBoard.Location = new System.Drawing.Point(12, 110);
            this.rtbBoard.Name = "rtbBoard";
            this.rtbBoard.Size = new System.Drawing.Size(923, 267);
            this.rtbBoard.TabIndex = 0;
            this.rtbBoard.Text = "";
            this.rtbBoard.TextChanged += new System.EventHandler(this.rtbBoard_TextChanged);
            // 
            // btnBold
            // 
            this.btnBold.Location = new System.Drawing.Point(12, 43);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(25, 25);
            this.btnBold.TabIndex = 4;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Location = new System.Drawing.Point(43, 43);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(25, 25);
            this.btnItalic.TabIndex = 5;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Location = new System.Drawing.Point(74, 43);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(25, 25);
            this.btnUnderline.TabIndex = 6;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Žuta",
            "Narandžasta",
            "Crvena",
            "Roze",
            "Ljubičasta",
            "Plava",
            "Svetlo plava",
            "Svetlo zelena",
            "Zelena",
            "Braon",
            "Crna",
            "Siva",
            "Bela"});
            this.cbColor.Location = new System.Drawing.Point(11, 74);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(88, 21);
            this.cbColor.TabIndex = 12;
            this.cbColor.Text = "Izaberi boju...";
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // cbTextSize
            // 
            this.cbTextSize.FormattingEnabled = true;
            this.cbTextSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "20"});
            this.cbTextSize.Location = new System.Drawing.Point(105, 74);
            this.cbTextSize.Name = "cbTextSize";
            this.cbTextSize.Size = new System.Drawing.Size(128, 21);
            this.cbTextSize.TabIndex = 13;
            this.cbTextSize.Text = "Izaberi velicinu fonta...";
            this.cbTextSize.SelectedIndexChanged += new System.EventHandler(this.cbTextSize_SelectedIndexChanged);
            // 
            // cbFontName
            // 
            this.cbFontName.FormattingEnabled = true;
            this.cbFontName.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Tahoma",
            "Comic Sans MS"});
            this.cbFontName.Location = new System.Drawing.Point(239, 74);
            this.cbFontName.Name = "cbFontName";
            this.cbFontName.Size = new System.Drawing.Size(84, 21);
            this.cbFontName.TabIndex = 14;
            this.cbFontName.Text = "Izaberi font...";
            this.cbFontName.SelectedIndexChanged += new System.EventHandler(this.cbFontName_SelectedIndexChanged);
            // 
            // btnHighlight
            // 
            this.btnHighlight.Location = new System.Drawing.Point(136, 43);
            this.btnHighlight.Name = "btnHighlight";
            this.btnHighlight.Size = new System.Drawing.Size(25, 25);
            this.btnHighlight.TabIndex = 8;
            this.btnHighlight.Text = "H";
            this.btnHighlight.UseVisualStyleBackColor = true;
            this.btnHighlight.Click += new System.EventHandler(this.btnHighlight_Click);
            // 
            // btnCentralAlign
            // 
            this.btnCentralAlign.Location = new System.Drawing.Point(198, 43);
            this.btnCentralAlign.Name = "btnCentralAlign";
            this.btnCentralAlign.Size = new System.Drawing.Size(25, 25);
            this.btnCentralAlign.TabIndex = 10;
            this.btnCentralAlign.Text = "C";
            this.btnCentralAlign.UseVisualStyleBackColor = true;
            this.btnCentralAlign.Click += new System.EventHandler(this.btnCentralAlign_Click);
            // 
            // btnLeftAlign
            // 
            this.btnLeftAlign.Location = new System.Drawing.Point(167, 43);
            this.btnLeftAlign.Name = "btnLeftAlign";
            this.btnLeftAlign.Size = new System.Drawing.Size(25, 25);
            this.btnLeftAlign.TabIndex = 9;
            this.btnLeftAlign.Text = "L";
            this.btnLeftAlign.UseVisualStyleBackColor = true;
            this.btnLeftAlign.Click += new System.EventHandler(this.btnLeftAlign_Click);
            // 
            // btnRightAlign
            // 
            this.btnRightAlign.Location = new System.Drawing.Point(229, 43);
            this.btnRightAlign.Name = "btnRightAlign";
            this.btnRightAlign.Size = new System.Drawing.Size(25, 25);
            this.btnRightAlign.TabIndex = 11;
            this.btnRightAlign.Text = "R";
            this.btnRightAlign.UseVisualStyleBackColor = true;
            this.btnRightAlign.Click += new System.EventHandler(this.btnRightAlign_Click);
            // 
            // btnStriketrough
            // 
            this.btnStriketrough.Location = new System.Drawing.Point(105, 43);
            this.btnStriketrough.Name = "btnStriketrough";
            this.btnStriketrough.Size = new System.Drawing.Size(25, 25);
            this.btnStriketrough.TabIndex = 7;
            this.btnStriketrough.Text = "S";
            this.btnStriketrough.UseVisualStyleBackColor = true;
            this.btnStriketrough.Click += new System.EventHandler(this.btnStriketrough_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(154, 12);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(66, 25);
            this.btnNewFile.TabIndex = 3;
            this.btnNewFile.Text = "Novi fajl";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // tbFindString
            // 
            this.tbFindString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFindString.Location = new System.Drawing.Point(789, 74);
            this.tbFindString.Name = "tbFindString";
            this.tbFindString.Size = new System.Drawing.Size(100, 20);
            this.tbFindString.TabIndex = 15;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(895, 74);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(40, 21);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Nadji";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblWordCounter
            // 
            this.lblWordCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWordCounter.Location = new System.Drawing.Point(900, 385);
            this.lblWordCounter.Name = "lblWordCounter";
            this.lblWordCounter.Size = new System.Drawing.Size(35, 23);
            this.lblWordCounter.TabIndex = 20;
            // 
            // lblCharCounter
            // 
            this.lblCharCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharCounter.Location = new System.Drawing.Point(800, 385);
            this.lblCharCounter.Name = "lblCharCounter";
            this.lblCharCounter.Size = new System.Drawing.Size(35, 23);
            this.lblCharCounter.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(728, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Broj karaktera";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(853, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Broj reci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCharCounter);
            this.Controls.Add(this.lblWordCounter);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbFindString);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.btnStriketrough);
            this.Controls.Add(this.btnRightAlign);
            this.Controls.Add(this.btnLeftAlign);
            this.Controls.Add(this.btnCentralAlign);
            this.Controls.Add(this.btnHighlight);
            this.Controls.Add(this.cbFontName);
            this.Controls.Add(this.cbTextSize);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.rtbBoard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbBoard;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbTextSize;
        private System.Windows.Forms.ComboBox cbFontName;
        private System.Windows.Forms.Button btnHighlight;
        private System.Windows.Forms.Button btnCentralAlign;
        private System.Windows.Forms.Button btnLeftAlign;
        private System.Windows.Forms.Button btnRightAlign;
        private System.Windows.Forms.Button btnStriketrough;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.TextBox tbFindString;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblWordCounter;
        private System.Windows.Forms.Label lblCharCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

