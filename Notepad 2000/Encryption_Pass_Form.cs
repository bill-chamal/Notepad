using System;
using System.Windows.Forms;

namespace Notepad_2000
{
    public partial class Encryption_Pass_Form : Form
    {
        public Encryption_Pass_Form()
        {
            InitializeComponent();
        }

        public bool RenterPassword
        {
            get { return ReEnterPassword; }
            set { ReEnterPassword = value; }
        }

        public bool ReEnterPassword = false;

        private bool DoNotClose = false;

        private Form1 mainForm = null;
        public Encryption_Pass_Form(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ReEnterPassword)
            {
                if (textBox_Password.Text != string.Empty && textBox_Password.Text == textBoxConfirmPass.Text)
                {
                    mainForm.hash = textBox_Password.Text;
                }
                else
                {
                    //DialogResult option = MessageBox.Show("Not the same Password!", "Notepad 2000", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    //if (option == DialogResult.Retry)
                    //{
                    //    DoNotClose = true;
                    //}
                    ShowError.Text = "Passwords chars must be the same!";
                    DoNotClose = true;
                }

            }
            else
            {
                if (textBox_Password.Text != string.Empty)
                {
                    mainForm.hash = textBox_Password.Text;
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = checkBox1.Checked;
            switch (Checked)
            {
                case true:
                    textBox_Password.UseSystemPasswordChar = false;
                    textBoxConfirmPass.UseSystemPasswordChar = false;
                    break;
                case false:
                    textBox_Password.UseSystemPasswordChar = true;
                    textBoxConfirmPass.UseSystemPasswordChar = true;
                    break;
                default:
                    break;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Encryption_Pass_Form_Load(object sender, EventArgs e)
        {
            if (ReEnterPassword == true)
            {
                labelName.Text = "Set Password for encryption:";
                labelShow2.Enabled = true;
                textBoxConfirmPass.Enabled = true;
            }
            else
            {
                labelName.Text = "Set Password for decryption:";
                labelShow2.Enabled = false;
                textBoxConfirmPass.Enabled = false;
            }

        }

        private void Encryption_Pass_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DoNotClose)
            {
                e.Cancel = true;
            }
            DoNotClose = false;
        }
    }
}