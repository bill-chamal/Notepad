namespace Notepad_2000
{
    partial class Encryption_Pass_Form
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
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.labelShow2 = new System.Windows.Forms.Label();
            this.ShowError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(12, 36);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(458, 43);
            this.textBox_Password.TabIndex = 0;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(264, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 24);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Set Password:";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 213);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Be aware! If you forget the password, there is not going back!";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(370, 213);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 40);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "&Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Enabled = false;
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Consolas", 18F);
            this.textBoxConfirmPass.Location = new System.Drawing.Point(12, 148);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(458, 43);
            this.textBoxConfirmPass.TabIndex = 1;
            this.textBoxConfirmPass.UseSystemPasswordChar = true;
            // 
            // labelShow2
            // 
            this.labelShow2.AutoSize = true;
            this.labelShow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelShow2.Location = new System.Drawing.Point(11, 121);
            this.labelShow2.Name = "labelShow2";
            this.labelShow2.Size = new System.Drawing.Size(166, 24);
            this.labelShow2.TabIndex = 6;
            this.labelShow2.Text = "Confirm password:";
            // 
            // ShowError
            // 
            this.ShowError.AutoSize = true;
            this.ShowError.ForeColor = System.Drawing.Color.Red;
            this.ShowError.Location = new System.Drawing.Point(13, 239);
            this.ShowError.Name = "ShowError";
            this.ShowError.Size = new System.Drawing.Size(16, 17);
            this.ShowError.TabIndex = 7;
            this.ShowError.Text = "  ";
            // 
            // Encryption_Pass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 265);
            this.Controls.Add(this.ShowError);
            this.Controls.Add(this.labelShow2);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Encryption_Pass_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad2000~Cipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Encryption_Pass_Form_FormClosing);
            this.Load += new System.EventHandler(this.Encryption_Pass_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Label labelShow2;
        private System.Windows.Forms.Label ShowError;
    }
}