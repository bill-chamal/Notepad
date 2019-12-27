namespace Notepad_2000
{
    partial class Form_Find
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(486, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(9, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(79, 20);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Find What:";
            // 
            // tbFind
            // 
            this.tbFind.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tbFind.Location = new System.Drawing.Point(13, 36);
            this.tbFind.Multiline = true;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(464, 30);
            this.tbFind.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(486, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // Form_Find
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(612, 133);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Find";
            this.ShowIcon = false;
            this.Text = "Find";
            this.Activated += new System.EventHandler(this.Form_Find_Activated);
            this.Deactivate += new System.EventHandler(this.Form_Find_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}