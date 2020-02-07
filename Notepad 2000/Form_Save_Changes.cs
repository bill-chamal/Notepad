using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad_2000
{
    public partial class Form_Save_Changes : Form
    {
        public Form_Save_Changes()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_TermsOfLic formlic = new Form_TermsOfLic();
            formlic.ShowDialog();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.Control;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromName("#D5D3C9");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = Properties.Resources.Azur_Corp;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Azur_Corp2;
        }
    }
}
