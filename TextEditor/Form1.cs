using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtbBoard_TextChanged(object sender, EventArgs e)
        {
            string count = rtbBoard.Text;
            lblWordCounter.Text = (count.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length).ToString();
            lblCharCounter.Text = rtbBoard.Text.Length.ToString();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "RTF Files|*.rtf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbBoard.LoadFile(ofd.FileName);
                //za .txt
                //richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);

            }
            rtbBoard.Focus();
            rtbBoard.Select(rtbBoard.Text.Length, 0);
            //richTextBox1.ScrollToCaret();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "RTF Files|*.rtf";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                rtbBoard.SaveFile(sfd.FileName);

            }
            rtbBoard.Focus();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {  
            Font currentFont = rtbBoard.SelectionFont;
            rtbBoard.SelectionFont = new Font(currentFont.Name, currentFont.Size,  currentFont.Style ^ FontStyle.Bold);
            rtbBoard.Focus();            
        }
        
        private void btnItalic_Click(object sender, EventArgs e)
        {
            Font currentFont = rtbBoard.SelectionFont;
            rtbBoard.SelectionFont = new Font(currentFont.Name, currentFont.Size, currentFont.Style ^ FontStyle.Italic);
            rtbBoard.Focus();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            Font currentFont = rtbBoard.SelectionFont;
            rtbBoard.SelectionFont = new Font(currentFont.Name, currentFont.Size, currentFont.Style ^ FontStyle.Underline);
            rtbBoard.Focus();
        }

        private void btnStriketrough_Click(object sender, EventArgs e)
        {
            Font currentFont = rtbBoard.SelectionFont;
            rtbBoard.SelectionFont = new Font(currentFont.Name, currentFont.Size, currentFont.Style ^ FontStyle.Strikeout);
            rtbBoard.Focus();
        }
        
        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColor.Text.Equals("Žuta"))
                rtbBoard.SelectionColor = Color.Yellow;
            else if (cbColor.Text.Equals("Narandžasta"))
                rtbBoard.SelectionColor = Color.Orange;
            if (cbColor.Text.Equals("Crvena"))
                rtbBoard.SelectionColor = Color.Red;
            else if (cbColor.Text.Equals("Roze"))
                rtbBoard.SelectionColor = Color.LightPink;
            else if (cbColor.Text.Equals("Ljubičasta"))
                rtbBoard.SelectionColor = Color.MediumPurple;
            else if (cbColor.Text.Equals("Plava"))
                rtbBoard.SelectionColor = Color.Blue;
            else if (cbColor.Text.Equals("Svetlo plava"))
                rtbBoard.SelectionColor = Color.LightBlue;
            else if (cbColor.Text.Equals("Svetlo zelena"))
                rtbBoard.SelectionColor = Color.LightGreen;
            else if (cbColor.Text.Equals("Zelena"))
                rtbBoard.SelectionColor = Color.Green;
            else if (cbColor.Text.Equals("Braon"))
                rtbBoard.SelectionColor = Color.Brown;
            else if (cbColor.Text.Equals("Crna"))
                rtbBoard.SelectionColor = Color.Black;
            else if (cbColor.Text.Equals("Siva"))
                rtbBoard.SelectionColor = Color.Gray;
            else if (cbColor.Text.Equals("Bela"))
                rtbBoard.SelectionColor = Color.White;

            rtbBoard.Focus();
        }

        private void cbTextSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font currentFont = rtbBoard.SelectionFont;

            if (cbTextSize.Text.Equals("8"))
                rtbBoard.SelectionFont = new Font(currentFont.Name, 8, currentFont.Style);
            else if (cbTextSize.Text.Equals("10"))
                rtbBoard.SelectionFont = new Font(currentFont.Name, 10, currentFont.Style);
            else if (cbTextSize.Text.Equals("12"))
                rtbBoard.SelectionFont = new Font(currentFont.Name, 12, currentFont.Style);
            else if (cbTextSize.Text.Equals("14"))
                rtbBoard.SelectionFont = new Font(currentFont.Name, 14, currentFont.Style);
            else if (cbTextSize.Text.Equals("16"))
                rtbBoard.SelectionFont = new Font(currentFont.Name, 16, currentFont.Style);
            else if (cbTextSize.Text.Equals("20"))
                rtbBoard.SelectionFont = new Font(currentFont.Name, 20, currentFont.Style);

            rtbBoard.Focus();
        }

        private void cbFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font currentFont = rtbBoard.SelectionFont;
            
            if (cbFontName.SelectedIndex == 0)
                rtbBoard.SelectionFont = new Font("Arial", currentFont.Size, currentFont.Style);
            else if (cbFontName.SelectedIndex == 1)
                rtbBoard.SelectionFont = new Font("Times New Roman", currentFont.Size, currentFont.Style);
            else if (cbFontName.SelectedIndex == 2)
                rtbBoard.SelectionFont = new Font("Tahoma", currentFont.Size, currentFont.Style);
            else if (cbFontName.SelectedIndex == 3)
                rtbBoard.SelectionFont = new Font("Comic Sans MS", currentFont.Size, currentFont.Style);

            rtbBoard.Focus();
        }

        private void btnHighlight_Click(object sender, EventArgs e)
        {
            if (rtbBoard.SelectionBackColor.Name.Equals("Yellow"))
                rtbBoard.SelectionBackColor = Color.White;
            else
                rtbBoard.SelectionBackColor = Color.Yellow;

            rtbBoard.Focus();
        }

        private void btnCentralAlign_Click(object sender, EventArgs e)
        {
            rtbBoard.SelectionAlignment = HorizontalAlignment.Center;
            rtbBoard.Focus();
        }

        private void btnLeftAlign_Click(object sender, EventArgs e)
        {
            rtbBoard.SelectionAlignment = HorizontalAlignment.Left;
            rtbBoard.Focus();
        }

        private void btnRightAlign_Click(object sender, EventArgs e)
        {
            rtbBoard.SelectionAlignment = HorizontalAlignment.Right;
            rtbBoard.Focus();
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            rtbBoard.Clear();
            rtbBoard.Focus();
        }

        int index, startIndex = 0;

        private void btnFind_Click(object sender, EventArgs e)
        {
            string word = tbFindString.Text;

            if (word == string.Empty)
                return;

            index = rtbBoard.Text.IndexOf(word, startIndex);
            if (index == -1)
            {
                startIndex = 0;
                index = rtbBoard.Text.IndexOf(word, startIndex);
            }

            rtbBoard.Select(index, word.Length);
            rtbBoard.Focus();
            startIndex = index + word.Length;
        }
    }
}
