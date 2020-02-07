using System;
using System.Windows.Forms;

namespace Notepad_2000
{
    public partial class Form_Find : Form
    {
        public Form_Find()
        {
            InitializeComponent();

        }
        //private const int CsDropShadow = 0x00020000;

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle = CsDropShadow;
        //        return cp;
        //    }
        //}


        int clickcount = 0, length = 0, index = 0;
        private Form1 mainForm = null;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Find_Activated(object sender, EventArgs e)
        {

        }

        private void Form_Find_Deactivate(object sender, EventArgs e)
        {

        }

        public Form_Find(Form callingForm)
        {
            this.mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Word;
            int length_pri = 0, index_pri = 0;
            Word = tbFind.Text;
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
