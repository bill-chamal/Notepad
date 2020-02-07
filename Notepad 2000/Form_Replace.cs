using System;
using System.Windows.Forms;

namespace Notepad_2000
{
    public partial class Form_Replace : Form
    {
        public Form_Replace()
        {
            InitializeComponent();
        }
        int clickcount = 0, length = 0, index = 0;

        private Form1 mainForm = null;
        public Form_Replace(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string Word;
            //int length = 0, index = 0;
            Word = tbFindwhat.Text;
            string Text = mainForm.richTextBox1.Text;
            if (Text.Contains(Word))
            {
                //length = Word.Length;
                //index = Text.IndexOf(Word);
                Text = Text.Remove(index, length);
                Text = Text.Insert(index, tBReplaceWith.Text);
                mainForm.richTextBox1.Text = Text;
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            string Word;
            Word = tbFindwhat.Text;
            string Text = mainForm.richTextBox1.Text;
            if (Text.Contains(Word))
            {
                if (tBReplaceWith.Text != string.Empty)
                {
                    Text = Text.Replace(Word, tBReplaceWith.Text);
                    mainForm.richTextBox1.Text = Text;
                }
            }

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbFindwhat.Text = string.Empty;
            tBReplaceWith.Text = string.Empty;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFintnext_Click(object sender, EventArgs e)
        {
            string Word;
            int length_pri = 0, index_pri = 0;
            Word = tbFindwhat.Text;
            string Text = mainForm.richTextBox1.Text;
            if (Text.Contains(Word))
            {
                for (int i = 0; i <= clickcount; i++)
                {
                    length_pri = Word.Length;
                    index_pri = Text.IndexOf(Word, index + length);
                    if (index_pri != -1)
                    {
                        mainForm.richTextBox1.Select(index_pri, length_pri);
                        mainForm.richTextBox1.HideSelection = false;
                    }
                }
            }
            clickcount++;
            length = length_pri; index = index_pri;
            length_pri = 0; index_pri = 0;

        }
    }
}
