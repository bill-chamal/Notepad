namespace Notepad_2000
{
    partial class Form_Replace
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
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.tbFindwhat = new System.Windows.Forms.TextBox();
            this.tBReplaceWith = new System.Windows.Forms.TextBox();
            this.BtnFintnext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReplace.Location = new System.Drawing.Point(575, 63);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(110, 30);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplaceAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReplaceAll.Location = new System.Drawing.Point(575, 99);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(110, 30);
            this.btnReplaceAll.TabIndex = 0;
            this.btnReplaceAll.Text = "Replace &All...";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.Location = new System.Drawing.Point(575, 144);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(110, 30);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Cancel";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tbFindwhat
            // 
            this.tbFindwhat.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tbFindwhat.Location = new System.Drawing.Point(128, 27);
            this.tbFindwhat.Multiline = true;
            this.tbFindwhat.Name = "tbFindwhat";
            this.tbFindwhat.Size = new System.Drawing.Size(441, 30);
            this.tbFindwhat.TabIndex = 1;
            // 
            // tBReplaceWith
            // 
            this.tBReplaceWith.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tBReplaceWith.Location = new System.Drawing.Point(128, 63);
            this.tBReplaceWith.Multiline = true;
            this.tBReplaceWith.Name = "tBReplaceWith";
            this.tBReplaceWith.Size = new System.Drawing.Size(441, 30);
            this.tBReplaceWith.TabIndex = 2;
            // 
            // BtnFintnext
            // 
            this.BtnFintnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFintnext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnFintnext.Location = new System.Drawing.Point(575, 27);
            this.BtnFintnext.Name = "BtnFintnext";
            this.BtnFintnext.Size = new System.Drawing.Size(110, 30);
            this.BtnFintnext.TabIndex = 0;
            this.BtnFintnext.Text = "&Find Next";
            this.BtnFintnext.UseVisualStyleBackColor = true;
            this.BtnFintnext.Click += new System.EventHandler(this.BtnFintnext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find What:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace With:";
            // 
            // Form_Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(211)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(702, 193);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBReplaceWith);
            this.Controls.Add(this.tbFindwhat);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.BtnFintnext);
            this.Controls.Add(this.btnReplace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Replace";
            this.ShowIcon = false;
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox tbFindwhat;
        private System.Windows.Forms.TextBox tBReplaceWith;
        private System.Windows.Forms.Button BtnFintnext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}