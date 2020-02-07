//-----------------------------------------------------------------------
// <copyright file="C:\Notepad 2000\Notepad 2000\Form1.cs" company="Azur">
//     Author:  Bill Chamalidis
//     Copyright (GNU) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Notepad_2000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Send richTextBox1 value to forms
        public string RichBoxText
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }
        public string Hash
        {
            get { return hash; }
            set { hash = value; }
        }

        int mov;
        int movX;
        int movY;

        string path = string.Empty;
        bool IsSaved = true;

        public string hash = string.Empty;

        //Drop Shadow Effect
        private const int CsDropShadow = 0x00020000;

        private void ToggleSavebtn()
        {
            switch (IsSaved)
            {
                case true:
                    // The save btn 
                    exitToolStripMenuItem.Enabled = false;
                    break;
                case false:
                    exitToolStripMenuItem.Enabled = true;
                    break;

            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CsDropShadow;
                return cp;
            }
        }

        // Exit & Save
        private void Button1_Click(object sender, EventArgs e)
        {

            if (IsSaved)
            {
                Application.Exit();
            }

            else
            {

                DialogResult dialog = MessageBox.Show("Do you want to save the changes before exit?", "Notepad 2000",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    if (path != string.Empty)
                    {
                        File.WriteAllText(path, richTextBox1.Text);
                    }
                    else
                    {
                        SaveFileDialog sv = new SaveFileDialog();
                        sv.Filter = "Text Document(*.txt)|* .txt| All Files(* . *)|*.*";
                        sv.FileName = "Untitled";
                        if (sv.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(path = sv.FileName, richTextBox1.Text);
                        }
                    }

                    Application.Exit();
                }
                else if (dialog == DialogResult.No)
                {
                    Application.Exit();
                }

            }

        }

        // Windows States! ---- Windows States!
        private void Button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }

            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }

            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        // Move Application 
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        // New & Clear - - - - New!
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsSaved/*richTextBox1.Text != string.Empty*/)
            {
                richTextBox1.Clear();
                path = string.Empty;
                IsSaved = false;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Do you want to save the changes?", "Notepad 2000",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    // If Yes Save & clear
                    if (path != string.Empty)
                    {
                        File.WriteAllText(path, richTextBox1.Text);
                    }
                    else
                    {
                        SaveFileDialog sv = new SaveFileDialog();
                        sv.Filter = "Text Document(*.txt)|* .txt| All Files(* . *)|*.*";
                        sv.FileName = "Untitled";
                        if (sv.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(path = sv.FileName, richTextBox1.Text);
                        }
                    }

                    richTextBox1.Clear();

                }
                else if (dialog == DialogResult.No)
                {
                    // If NO Clear only
                    richTextBox1.Clear();
                    path = string.Empty;
                }
            }
            IsSaved = true;

        }

        // Open File & Save File - - - Open!
        private void OpenAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If it is empty do...
            if (IsSaved/*richTextBox1.Text == string.Empty*/)
            {
                try
                {
                    OpenFileDialog op = new OpenFileDialog();
                    op.Filter =
                        "Text Document(*.txt)|* .txt| Microsoft Word 93 - 2003 Document(* .doc)|* .doc| Word File(* .word)|* .word| HTML File(* .html)|* .html| CSS File(* .css)|*.css| JavaScript File(* .js)|* .js| VBScript Script File(* .vbs)|* .vbs| Windows Batch File(* .bat)|* .bat| All Files(* . *)|*.*";
                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                        IsSaved = true;
                        path = op.FileName;
                    }
                    //else if(op.ShowDialog == DialogResult.Cancel)
                    // Do anything
                    // Put the path location into the variable path 
                    //path = op.FileName;
                    this.Text = op.FileName;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Is not the right kind of document!", "Can't Open This File");
                    Console.WriteLine(exception);
                    throw;
                }



            }
            // if there is text inside do...
            else // If false IsSaved "Is not saved"
            {
                DialogResult dialog = MessageBox.Show("Do you want to save the changes before open a file?", "Notepad 2000",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    if (path != string.Empty)
                    {
                        File.WriteAllText(path, richTextBox1.Text);
                    }
                    else
                    {
                        SaveFileDialog sv = new SaveFileDialog();
                        sv.Filter = "Text Document(*.txt)|* .txt| All Files(* . *)|*.*";
                        sv.FileName = "Untitled";
                        if (sv.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(path = sv.FileName, richTextBox1.Text);
                        }
                    }

                    richTextBox1.Clear();
                    // Open File
                    try
                    {
                        OpenFileDialog op = new OpenFileDialog();
                        op.Filter =
                            "Text Document(*.txt)|* .txt| Microsoft Word 93 - 2003 Document(* .doc)|* .doc| Word File(* .word)|* .word| HTML File(* .html)|* .html| CSS File(* .css)|*.css| VBScript Script File(* .vbs)|* .vbs| Windows Batch File(* .bat)|* .bat| All Files(* . *)|*.*";
                        if (op.ShowDialog() == DialogResult.OK)
                            richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                        IsSaved = true;
                        path = op.FileName;
                        this.Text = op.FileName;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Is not the right kind of document!", "Notepad 2000");
                        Console.WriteLine(exception);
                        throw;
                    }



                }
                // If no, Then don't save, clear, open new file of document
                else if (dialog == DialogResult.No)
                {
                    richTextBox1.Clear();

                    try
                    {
                        OpenFileDialog op = new OpenFileDialog();
                        op.Filter =
                            "Text Document(*.txt)|* .txt| Microsoft Word 93 - 2003 Document(* .doc)|* .doc| Word File(* .word)|* .word| HTML File(* .html)|* .html| CSS File(* .css)|*.css| VBScript Script File(* .vbs)|* .vbs| Windows Batch File(* .bat)|* .bat| All Files(* . *)|*.*";
                        if (op.ShowDialog() == DialogResult.OK)
                            richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                        IsSaved = true;
                        path = op.FileName;
                        this.Text = op.FileName;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Is not the rihgt kind of document", "Notepad 2000");
                        Console.WriteLine(exception);
                        throw;
                    }


                }

            }
            lblName.Text = "Notepad 2000-" + path;
            //IsSaved = true;
            ToggleSavebtn();
        }

        // Save file  - - - - Save!
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (path != string.Empty)
            {
                File.WriteAllText(path, richTextBox1.Text);
            }
            else
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Text Document(*.txt)|* .txt| All Files(* . *)|*.*";
                sv.FileName = "Untitled";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(path = sv.FileName, richTextBox1.Text);
                }
            }
            IsSaved = true;
            ToggleSavebtn();
            // old one 
            //SaveFileDialog sv = new SaveFileDialog();
            //sv.Filter = "Text Document(*.txt)|* .txt| All Files(* . *)|*.*";
            //sv.FileName = "Untitled";

            //if (sv.ShowDialog() == DialogResult.OK)
            //    richTextBox1.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            //this.Text = sv.FileName;

        }

        // Save As... - - - -  Save as...
        private void SaveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter =
                " Text Document(*.txt)|* .txt| Microsoft Word 93 - 2003 Document(*.doc)|* .doc| Word File(*.word)|* .word| HTML File(*.html)|* .html| CSS File(*.css)|*.css| JavaScript File(*.js)|* .js| VBScript Script File(*.vbs)|* .vbs| Windows Batch File(*.bat)|* .bat| Python(*.py)|* .py| All Files(* . *)|*.*";

            sv.FileName = "Untitled";

            if (sv.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sv.FileName;
            IsSaved = true;
        }

        // Exit & Save - - - - Save!
        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e) => button1.PerformClick();

        //  Text Controls
        private void UndoCtrlZToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Undo();

        private void RudoCtrlYToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Redo();

        private void CutCtrlXToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Cut();

        private void CopyCtrlVToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Copy();

        private void PasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Paste();

        private void SelectAllCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == richTextBox1.Text)
            {
                richTextBox1.DeselectAll();
            }
            else
            {
                richTextBox1.SelectAll();
            }
        }

        // Time\Date
        private void TmeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = DateTime.Now.ToString();
        }

        private void DeleteDelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = string.Empty;
        }

        // Font
        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        // Word Warp
        private void WorldWarpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (worldWarpToolStripMenuItem.Checked == true)
            {
                richTextBox1.WordWrap = false;
                worldWarpToolStripMenuItem.Checked = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
                worldWarpToolStripMenuItem.Checked = true;
            }
        }

        // Zoom in Fractor
        private void ZoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor == 1)
            {
                richTextBox1.ZoomFactor = 2;
                zoomOutToolStripMenuItem.Enabled = true;
                defaultZoomToolStripMenuItem.Enabled = true;
            }

            else if (richTextBox1.ZoomFactor == 2)
            {
                richTextBox1.ZoomFactor = 3;
            }

            else if (richTextBox1.ZoomFactor == 3)
            {
                richTextBox1.ZoomFactor = 4;
            }

            else if (richTextBox1.ZoomFactor == 4)
            {
                richTextBox1.ZoomFactor = 5;
                zoomInToolStripMenuItem.Enabled = false;
            }

        }

        // Zoom out Fractor
        private void ZoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor == 5)
            {
                richTextBox1.ZoomFactor = 4;
                zoomInToolStripMenuItem.Enabled = true;
            }

            else if (richTextBox1.ZoomFactor == 4)
            {
                richTextBox1.ZoomFactor = 3;
            }

            else if (richTextBox1.ZoomFactor == 3)
            {
                richTextBox1.ZoomFactor = 2;
            }

            else if (richTextBox1.ZoomFactor == 2)
            {
                richTextBox1.ZoomFactor = 1;
                zoomOutToolStripMenuItem.Enabled = false;
                defaultZoomToolStripMenuItem.Enabled = false;
            }

        }

        // Default Zoom Fractor
        private void DefaultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1;
            zoomOutToolStripMenuItem.Enabled = false;
            defaultZoomToolStripMenuItem.Enabled = false;
        }

        // Change background color with color dialog 
        private void BackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cr = new ColorDialog();
            if (cr.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = cr.Color;
                eyeProtectionToolStripMenuItem.Checked = false;

            }
        }

        // Help Ling
        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Default microsoft's help page
            Process.Start(
                "https://www.bing.com/search?q=get+help+with+notepad+in+windows+10&filters=guid:%224466414-en-dia%22%20lang:%22en%22&form=T00032&ocid=HelpPane-BingIA");
        }

        // Colorize Text
        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void YellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Yellow;
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void GreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Gray;
        }

        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;
        }
        // End colorize text

        // Print
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                Console.WriteLine(exception);
                throw;
            }
        }

        // PrintDocument1_PrintPage
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black,
                new PointF(100, 100));
        }

        //New Window Form
        private void SaveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveUserSettings();
            Process.Start(@"Notepad 2000.exe");
        }

        // About Notepad 2000
        private void AboutNotepad2000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // About
            Form_Save_Changes FSC = new Form_Save_Changes();
            FSC.ShowDialog();

        }

        // Nul
        private void ColorTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // set background color

        // set background color
        // This Also is saved in User Settings App Form Named as Eye_Protection
        private void EyeProtectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Toogle eyeProtectionToolStripMenuItem
            if (eyeProtectionToolStripMenuItem.Checked == true)
            {
                eyeProtectionToolStripMenuItem.Checked = false;
                richTextBox1.BackColor = Color.White;

            }

            else
            {
                eyeProtectionToolStripMenuItem.Checked = true;
                richTextBox1.BackColor = Color.FromArgb(149, 255, 158);

            }
        }


        // Drag Drop RichTextBox1 Load File ///////===================
        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {

            try
            {



                object fileName = e.Data.GetData("FileDrop");
                if (fileName != null)
                {
                    var list = fileName as string[];

                    if (list != null && !string.IsNullOrEmpty(list[0]))
                    {

                        if (IsSaved/*richTextBox1.Text == string.Empty*/)
                        {
                            // Load file
                            richTextBox1.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                        }
                        else
                        {
                            // Ask
                            DialogResult dialog = MessageBox.Show("Do you want to save the changes?", "Notepad 2000",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                            if (dialog == DialogResult.Yes)
                            {
                                // If Yes Save & Clear & Load File
                                if (path != string.Empty)
                                {
                                    File.WriteAllText(path, richTextBox1.Text);
                                }
                                else
                                {
                                    SaveFileDialog sv = new SaveFileDialog();
                                    sv.Filter = "Text Document(*.txt)|* .txt| All Files(* . *)|*.*";
                                    sv.FileName = "Untitled";
                                    if (sv.ShowDialog() == DialogResult.OK)
                                    {
                                        File.WriteAllText(path = sv.FileName, richTextBox1.Text);
                                    }
                                }

                                richTextBox1.Clear();
                                richTextBox1.LoadFile(list[0], RichTextBoxStreamType.PlainText);



                            }
                            else if (dialog == DialogResult.No)
                            {
                                // If No Clear & Load File
                                richTextBox1.Clear();
                                richTextBox1.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                            }

                        }

                    }

                }

                path = string.Empty;
                lblName.Text = "Notepad 2000 " + path;
                IsSaved = true;
                ToggleSavebtn();
            }


            catch (Exception ex)
            {
                //richTextBox1.Clear();
                MessageBox.Show(ex.Message, "Notepad 2000", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }


        }

        // Contact Support
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SendFeedback SF = new SendFeedback();
            SF.ShowDialog();
        }

        // Context Menu Strip basic Copy&Paste
        // Right click mouse
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Undo();

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Redo();

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Cut();

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Copy();

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Paste();

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.SelectedText = string.Empty;

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e) => selectAllCtrlAToolStripMenuItem.PerformClick();

        // RichTextBox1 Right to left Toggle
        private void RightToLeftReadingOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.RightToLeft == RightToLeft.No)
            {
                richTextBox1.RightToLeft = RightToLeft.Yes;
                rightToLeftReadingOrderToolStripMenuItem.Checked = true;
            }

            else
            {
                richTextBox1.RightToLeft = RightToLeft.No;
                rightToLeftReadingOrderToolStripMenuItem.Checked = false;
            }
        }

        // Context Menu Strip change font color
        private void RedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void GreenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void BlueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void YellowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Yellow;
        }

        private void GreyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Gray;
        }

        private void BlackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;
        }

        // Timer1
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                // Menu Strip
                // File
                openToolStripMenuItem.Enabled = false;
                exitToolStripMenuItem.Enabled = false;
                printToolStripMenuItem.Enabled = false;
                // Edit
                selectAllCtrlAToolStripMenuItem.Enabled = false;
                cypherToolStripMenuItem.Enabled = false;
                // Contex Menu Strip1
                selectAllToolStripMenuItem.Enabled = false;
                //Find
                Find_button.Enabled = false;
                Clr_txt_highlight_bttn.Enabled = false;

            }

            else
            {
                // Menu Strip
                // File
                openToolStripMenuItem.Enabled = true;
                //exitToolStripMenuItem.Enabled = true;
                printToolStripMenuItem.Enabled = true;
                // Edit
                selectAllCtrlAToolStripMenuItem.Enabled = true;
                cypherToolStripMenuItem.Enabled = true;
                // Contex Menu Strip1
                selectAllToolStripMenuItem.Enabled = true;
                // Find
                Find_button.Enabled = true;
                Clr_txt_highlight_bttn.Enabled = true;

            }

            if (richTextBox1.SelectedText == string.Empty)
            {
                // Edit
                cutCtrlXToolStripMenuItem.Enabled = false;
                copyCtrlVToolStripMenuItem.Enabled = false;
                deleteDelToolStripMenuItem.Enabled = false;
                colorizeToolStripMenuItem.Enabled = false;
                Search_in_Bing_toolStripMenuItem3.Enabled = false;
                // Contex Menu Strip1
                toolStripMenuItem2.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                searchWithBingToolStripMenuItem.Enabled = false;
            }
            else
            {
                // Edit
                cutCtrlXToolStripMenuItem.Enabled = true;
                copyCtrlVToolStripMenuItem.Enabled = true;
                deleteDelToolStripMenuItem.Enabled = true;
                colorizeToolStripMenuItem.Enabled = true;
                Search_in_Bing_toolStripMenuItem3.Enabled = true;
                // Contex Menu Strip1
                toolStripMenuItem2.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                searchWithBingToolStripMenuItem.Enabled = true;

            }

        }

        // Default Font
        private void DefaultFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FontDialog fd = new FontDialog();
            fontDialog1.ShowApply = true;
            fontDialog1.Font = richTextBox1.SelectionFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // richTextBox1.SelectAll();
                richTextBox1.Font = fontDialog1.Font;
                // richTextBox1.DeselectAll();
            }

        }

        // Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // When Form Load do...
            timer1.Enabled = true;
            timer2.Enabled = true;
            richTextBox1.AllowDrop = true;
            richTextBox1.DragDrop += new DragEventHandler(RichTextBox1_DragDrop);
            // Set User Settings
            eyeProtectionToolStripMenuItem.Checked =
                Properties.Settings.Default.Eye_Protection; // name from app settings (Eye_Protection)
            worldWarpToolStripMenuItem.Checked =
                Properties.Settings.Default.Word_Warp_Toogle; // name from app settings (Word_Warp_Toogle)
            richTextBox1.Font =
                Properties.Settings.Default.Default_Font_Save; // name from app settings (Default_Font_Save)
            richTextBox1.BackColor =
                Properties.Settings.Default.BackgroundColor_Save; // named from settings (BackgroundColor_Save)
            topMostToolStripMenuItem.Checked =
                Properties.Settings.Default.TopMostNotepad_Toggle; // named from settings (TopMostNotepad_Toggle)
            detectUrlsToolStripMenuItem.Checked =
                Properties.Settings.Default
                    .DetectUrls_ToggleUserSettings; // Named fro settings (DetectUrls_ToggleUserSettings)
            wordCountToolStripMenuItem.Checked = Properties.Settings.Default.WordCnt_US;

            // Detect Urls
            // If detectUrlsToolStripMenuItem.Chected make it real
            if (detectUrlsToolStripMenuItem.Checked == true)
            {
                richTextBox1.DetectUrls = true;
            }
            else
            {
                richTextBox1.DetectUrls = false;
            }


            // Top Most Toggle
            // If topMostToolStripMenuItem.Checked make it real
            if (topMostToolStripMenuItem.Checked == false)
            {
                TopMost = false;
            }
            else
            {
                TopMost = true;
            }


            // eye_Prodection
            // If eye_Prodection checked = true, then turn it on
            if (eyeProtectionToolStripMenuItem.Checked == false)
            {
                eyeProtectionToolStripMenuItem.Checked = false;
                //  richTextBox1.BackColor = Color.White;
                richTextBox1.BackColor = Properties.Settings.Default.BackgroundColor_Save;

            }

            else
            {
                eyeProtectionToolStripMenuItem.Checked = true;
                richTextBox1.BackColor = Color.FromArgb(149, 255, 158);

            }

            // Word_Warp_Toogle
            // if Word_Warp_Toogle checked = true, Then turn it on
            if (worldWarpToolStripMenuItem.Checked == false)
            {
                richTextBox1.WordWrap = false;
                worldWarpToolStripMenuItem.Checked = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
                worldWarpToolStripMenuItem.Checked = true;
            }

            if (wordCountToolStripMenuItem.Checked == true)
            {
                WordCnt_groupBox.Visible = true;
            }

        }

        // Form Closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Timers ----- ------ Timers  Disable
            timer1.Enabled = false;
            timer2.Enabled = false;

            SaveUserSettings();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            try
            {
                panel1.BackgroundImage = Properties.Resources.Notepad2000_grad;
                pictureBox1.Image = Properties.Resources.NotePad_Logo_Image;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                Console.WriteLine(exception);
                throw;
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            try
            {
                panel1.BackgroundImage = Properties.Resources.Notepad2000_grad_BW;
                pictureBox1.Image = Properties.Resources.NotePad_Logo_Image_Desaturated;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                Console.WriteLine(exception);
                throw;
            }
        }

        // Timer 2 ----- ------ Timer 2
        // If CanUndo & If CanRedo
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                undoCtrlZToolStripMenuItem.Enabled = true;
                undoToolStripMenuItem.Enabled = true;
            }

            else if (richTextBox1.CanUndo == false)
            {
                undoCtrlZToolStripMenuItem.Enabled = false;
                undoToolStripMenuItem.Enabled = false;
            }

            if (richTextBox1.CanRedo == true)
            {
                rudoCtrlYToolStripMenuItem.Enabled = true;
                redoToolStripMenuItem.Enabled = true;
            }

            else if (richTextBox1.CanRedo == false)
            {
                rudoCtrlYToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
            }
        }

        // Search With Bing Buttons toolStripMenuItem3
        private void Search_in_Bing_toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string SearchInBing = richTextBox1.SelectedText;
            Process.Start("https://go.microsoft.com/fwlink/?linkid=873217&q=" + SearchInBing + "&form=NPCTXT");
        }

        // Search With Bing Buttons ToolStripMenuItem
        private void SearchWithBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SearchInBing = richTextBox1.SelectedText;
            Process.Start("https://go.microsoft.com/fwlink/?linkid=873217&q=" + SearchInBing + "&form=NPCTXT");
        }

        private void TopMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (topMostToolStripMenuItem.Checked == false)
            {
                TopMost = true;
                topMostToolStripMenuItem.Checked = true;
            }
            else
            {
                TopMost = false;
                topMostToolStripMenuItem.Checked = false;
            }
        }

        private void DetectUrlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (detectUrlsToolStripMenuItem.Checked == true)
            {
                richTextBox1.DetectUrls = false;
                detectUrlsToolStripMenuItem.Checked = false;
            }
            else
            {
                richTextBox1.DetectUrls = true;
                detectUrlsToolStripMenuItem.Checked = true;
            }
        }

        private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encryption_Pass_Form encryption_Pass_Form = new Encryption_Pass_Form(this);
            encryption_Pass_Form.ReEnterPassword = true;
            if (encryption_Pass_Form.ShowDialog(this) == DialogResult.OK && hash != string.Empty)
            {
                try
                {
                    byte[] data = UTF8Encoding.UTF8.GetBytes(richTextBox1.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                        { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripDes.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            richTextBox1.Text = Convert.ToBase64String(results, 0, results.Length);
                        }
                    }
                }
                catch (Exception exceptionCrypto)
                {
                    MessageBox.Show(exceptionCrypto.Message, "Notepad 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                hash = string.Empty;
            }
        }

        private void DecryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encryption_Pass_Form encryption_Pass_Form = new Encryption_Pass_Form(this);
            encryption_Pass_Form.ReEnterPassword = false;
            if (encryption_Pass_Form.ShowDialog(this) == DialogResult.OK && hash != string.Empty)
            {
                try
                {
                    byte[] data = Convert.FromBase64String(richTextBox1.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                        { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripDes.CreateDecryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            richTextBox1.Text = UTF8Encoding.UTF8.GetString(results);
                        }
                    }

                }
                catch (Exception exceptionDeCrypto)
                {
                    MessageBox.Show(exceptionDeCrypto.Message, "Notepad 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            hash = string.Empty;
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCheckInfo info;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    //Console.WriteLine(exception);
                    MessageBox.Show(
                        "The new version of the Notepad 2000 can't be downloaded at this time.\n\nPlease make sure you are connected to the internet! Error: " +
                        dde.Message, "Check for updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (InvalidDeploymentException IDE)
                {
                    MessageBox.Show(
                        "Can't check for a new version of the Notepad 2000. The Azure deployment is corrupt. Please redeploy the Azure Word and try again! Error: " +
                        IDE.Message, "Check for updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    ;
                }
                catch (InvalidOperationException IOE)
                {
                    MessageBox.Show("Azure Word can't be updated" + IOE.Message, "Check for updates",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    if (MessageBox.Show("A newer version is avaliable now. Do you want to update it now?",
                            "Chack for updates", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                    {
                        try
                        {
                            if (richTextBox1.Text == string.Empty)
                            {
                                ad.Update();
                                Application.Restart();
                            }
                            else
                            {
                                DialogResult dialog = MessageBox.Show(
                                    "A update has been found and the application needs to restart, do you want to save the changes?",
                                    "Word", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                                if (dialog == DialogResult.Yes)
                                {
                                    saveAsToolStripMenuItem1.PerformClick();
                                    ad.Update();
                                    Application.Restart();
                                }
                                else if (dialog == DialogResult.No)
                                {
                                    ad.Update();
                                    Application.Restart();
                                }

                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Check for updates", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            throw;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("You are running the latest version.", "Check for updates", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                Form_WEBBrowser webBrowser = new Form_WEBBrowser();
                webBrowser.Show();
                //if (MessageBox.Show(
                //        "To update it, you can download the newer version from Google Drive. \n\nDo you want to proceed?",
                //        "Update product",
                //        MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                //{
                //    Process.Start("https://drive.google.com/open?id=1UQcWHLWlB75vtwRFp3AQqPtV0IqpWJMV");
                //}
            }

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e) => button1.PerformClick();

        private void fiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find_groupBox.Visible = true;
            fiToolStripMenuItem.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Find_groupBox.Visible = false;
            fiToolStripMenuItem.Enabled = true;
        }

        private void Clear_button_Find_Click(object sender, EventArgs e)
        {
            Find_textBox.Text = string.Empty;
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            string[] words = Find_textBox.Text.Split(',');
            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < richTextBox1.TextLength)
                {
                    int wordSartIndex = richTextBox1.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordSartIndex != -1)
                    {
                        richTextBox1.SelectionStart = wordSartIndex;

                        richTextBox1.SelectionColor = colorDialog1.Color != Color.Black
                            ? colorDialog1.Color
                            : Color.FromArgb(134, 181, 218);

                        richTextBox1.SelectionLength = word.Length;
                        richTextBox1.Select();
                    }
                    else
                    {
                        string textBoxI = Find_textBox.Text;
                        if (MessageBox.Show("Cannot find: " + textBoxI, "Notepad 2000", MessageBoxButtons.OK,
                                MessageBoxIcon.Information) == DialogResult.OK)
                            break;
                    }

                    startIndex += wordSartIndex + word.Length;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button4.ForeColor = colorDialog1.Color;
        }

        private void Clr_txt_highlight_bttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear all the highlighted text?", "Notepad 2000",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) ==
                DialogResult.Yes)
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.DeselectAll();
            }
        }

        private void Find_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Find_textBox.Text != string.Empty)
            {
                Clear_button_Find.Enabled = true;
            }
            else
            {
                Clear_button_Find.Enabled = false;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) => button1.PerformClick();

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string words = richTextBox1.Text.Trim();
            //MessageBox.Font =  Font("Calibri", 50f, FontStyle.Regular);
            MessageBox.Show(
                "Characters:      " + richTextBox1.Text.Length.ToString() + "\n\nWords:        " +
                CountWords(words).ToString(), "Word Count", MessageBoxButtons.OK, MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

        }

        private int CountWords(string words)
        {
            string[] allWords = words.Split(' ');
            return allWords.Length;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            IsSaved = false;
            ToggleSavebtn();
            //if (richTextBox1.Text == string.Empty)
            //    exitToolStripMenuItem.Enabled = false;
            //else
            //    exitToolStripMenuItem.Enabled = true;

            string words = richTextBox1.Text.Trim();
            Chara_label.Text = richTextBox1.Text != string.Empty ? CountWords(words).ToString() : "0";

            label_Charac.Text = richTextBox1.Text.Length.ToString();
        }

        private void wordCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordCountToolStripMenuItem.Checked == true)
            {
                WordCnt_groupBox.Visible = false;
                wordCountToolStripMenuItem.Checked = false;
            }
            else
            {
                WordCnt_groupBox.Visible = true;
                wordCountToolStripMenuItem.Checked = true;

            }
        }
        // Richtextbox selection Changed!
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == richTextBox1.Text)
            {
                selectAllCtrlAToolStripMenuItem.Text = "&Deselect All";
                selectAllToolStripMenuItem.Text = "&Deselect All";
            }
            else
            {
                selectAllCtrlAToolStripMenuItem.Text = "Select &All";
                selectAllToolStripMenuItem.Text = "Select &All";
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gainsboro;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(213, 211, 201);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gainsboro;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(213, 211, 201);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gainsboro;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(213, 211, 201);
        }

        private void SaveUserSettings()
        {
            //When Form Closing...
            // Save User Settings...
            // Save User Settings eyeProtectionToolStripMenuItem checked named as Eye_Protection
            Properties.Settings.Default.Eye_Protection = eyeProtectionToolStripMenuItem.Checked;
            // Save User Settings worldWarpToolStripMenuItem checked Named as Word_Warp_Toogle
            Properties.Settings.Default.Word_Warp_Toogle = worldWarpToolStripMenuItem.Checked;
            // Save User Settings defaultFontToolStripMenuItem Font Named as Default_Font_Save
            Properties.Settings.Default.Default_Font_Save = richTextBox1.Font;
            // Save User Settings backgroundColorToolStripMenuItem Color Named as BackgroundColor_Save
            Properties.Settings.Default.BackgroundColor_Save = richTextBox1.BackColor;
            // Save User topMostToolStripMenuItem chected Named as TopMostNotepad_Toggle
            Properties.Settings.Default.TopMostNotepad_Toggle = topMostToolStripMenuItem.Checked;
            // Save user detectUrlsToolStripMenuItem chected named as DetectUrls_ToggleUserSettings
            Properties.Settings.Default.DetectUrls_ToggleUserSettings = detectUrlsToolStripMenuItem.Checked;
            //
            Properties.Settings.Default.WordCnt_US = wordCountToolStripMenuItem.Checked;
            // Save All
            Properties.Settings.Default.Save();

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            richTextBox1.Font = fontDialog1.Font;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Find form_Find = new Form_Find(this);
            // prevend to opening more than 1 
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Find")
                {
                    IsOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
                form_Find.Show();

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Replace form_Replace = new Form_Replace(this);
            // prevend to opening more than 1 
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Replace")
                {
                    IsOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
                form_Replace.Show();

        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void pictureBox1_Click(object sender, EventArgs e) => contextMenuStrip2.Show();

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cursor.Position = new Point(200,300);

            //Cursor.Position = new Point(Cursor.Position.X + 50, Cursor.Position.Y);
        }
    }
}