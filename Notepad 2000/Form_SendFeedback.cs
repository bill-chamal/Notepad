using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Notepad_2000
{
    public partial class SendFeedback : Form
    {
        public SendFeedback()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            // Open gmail in browser
            Process.Start("mailto:basilischal17@gmail.com");
        }

        private void SendFeedback_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://github.com/bill-chamal/Notepad/issues");
        }
    }
}