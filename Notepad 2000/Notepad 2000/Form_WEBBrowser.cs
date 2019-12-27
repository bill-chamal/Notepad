using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Notepad_2000
{
    public partial class Form_WEBBrowser : Form
    {
        public Form_WEBBrowser()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/open?id=1UQcWHLWlB75vtwRFp3AQqPtV0IqpWJMV");
        }
    }
}
