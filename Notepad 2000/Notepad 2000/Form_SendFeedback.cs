using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            // Copy for Paste
            //richTextBox1.SelectAll();
            //richTextBox1.Copy();
            //notifyIcon1.ShowBalloonTip(1000);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Open gmail in browser
            Process.Start("https://mail.google.com/mail/u/0/#search/basilischal17%40gmail.com?compose=new");
        }

        private void SendFeedback_Load(object sender, EventArgs e)
        {
        }
    }
}