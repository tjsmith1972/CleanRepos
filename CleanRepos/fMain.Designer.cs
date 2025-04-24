namespace CleanRepos
{
    partial class fMain
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
            splitContainer1 = new SplitContainer();
            txtRootFolder = new TextBox();
            btnFolBrowser = new Button();
            splitContainer2 = new SplitContainer();
            rLog = new RichTextBox();
            label1 = new Label();
            txtFoldersToDelete = new TextBox();
            btnGo = new Button();
            btnPreview = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtRootFolder);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnFolBrowser);
            splitContainer1.Size = new Size(800, 31);
            splitContainer1.SplitterDistance = 731;
            splitContainer1.TabIndex = 0;
            // 
            // txtRootFolder
            // 
            txtRootFolder.Dock = DockStyle.Fill;
            txtRootFolder.Location = new Point(0, 0);
            txtRootFolder.Name = "txtRootFolder";
            txtRootFolder.Size = new Size(731, 29);
            txtRootFolder.TabIndex = 0;
            txtRootFolder.KeyUp += txtRootFolder_KeyUp;
            // 
            // btnFolBrowser
            // 
            btnFolBrowser.Dock = DockStyle.Fill;
            btnFolBrowser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFolBrowser.Location = new Point(0, 0);
            btnFolBrowser.Name = "btnFolBrowser";
            btnFolBrowser.Size = new Size(65, 31);
            btnFolBrowser.TabIndex = 0;
            btnFolBrowser.Text = "...";
            btnFolBrowser.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 31);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(rLog);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(label1);
            splitContainer2.Panel2.Controls.Add(txtFoldersToDelete);
            splitContainer2.Panel2.Controls.Add(btnGo);
            splitContainer2.Panel2.Controls.Add(btnPreview);
            splitContainer2.Size = new Size(800, 419);
            splitContainer2.SplitterDistance = 371;
            splitContainer2.TabIndex = 2;
            // 
            // rLog
            // 
            rLog.Dock = DockStyle.Fill;
            rLog.Location = new Point(0, 0);
            rLog.Name = "rLog";
            rLog.Size = new Size(800, 371);
            rLog.TabIndex = 2;
            rLog.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 12);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 4;
            label1.Text = "Folders To Delete";
            // 
            // txtFoldersToDelete
            // 
            txtFoldersToDelete.Location = new Point(301, 9);
            txtFoldersToDelete.Name = "txtFoldersToDelete";
            txtFoldersToDelete.Size = new Size(270, 29);
            txtFoldersToDelete.TabIndex = 3;
            txtFoldersToDelete.Text = "node_modules,packages,bin,obj";
            // 
            // btnGo
            // 
            btnGo.Dock = DockStyle.Right;
            btnGo.Location = new Point(725, 0);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 44);
            btnGo.TabIndex = 2;
            btnGo.Text = "Clean";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnPreview
            // 
            btnPreview.Dock = DockStyle.Left;
            btnPreview.Location = new Point(0, 0);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(127, 44);
            btnPreview.TabIndex = 0;
            btnPreview.Text = "Preview Clean";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_ClickAsync;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer2);
            Controls.Add(splitContainer1);
            Name = "fMain";
            Text = "Clean Repos (Point this at your projects folders to delete the bloat!)";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtRootFolder;
        private Button btnFolBrowser;
        private SplitContainer splitContainer2;
        private RichTextBox rLog;
        private Button btnGo;
        private Button btnPreview;
        private Label label1;
        private TextBox txtFoldersToDelete;
    }
}