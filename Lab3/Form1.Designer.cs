namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            keyTb = new TextBox();
            keyTitleLbl = new Label();
            openFileBtn = new Button();
            filePathLbl = new Label();
            EncryptBtn = new Button();
            CloseBtn = new Button();
            progressBar1 = new ProgressBar();
            ProgressLbl = new Label();
            openFileDlg = new OpenFileDialog();
            EncryptionBw = new System.ComponentModel.BackgroundWorker();
            DecryptBtn = new Button();
            SuspendLayout();
            // 
            // keyTb
            // 
            keyTb.Location = new Point(47, 12);
            keyTb.Name = "keyTb";
            keyTb.Size = new Size(377, 23);
            keyTb.TabIndex = 0;
            // 
            // keyTitleLbl
            // 
            keyTitleLbl.AutoSize = true;
            keyTitleLbl.Location = new Point(12, 15);
            keyTitleLbl.Name = "keyTitleLbl";
            keyTitleLbl.Size = new Size(29, 15);
            keyTitleLbl.TabIndex = 1;
            keyTitleLbl.Text = "Key:";
            // 
            // openFileBtn
            // 
            openFileBtn.Location = new Point(12, 41);
            openFileBtn.Name = "openFileBtn";
            openFileBtn.Size = new Size(125, 23);
            openFileBtn.TabIndex = 2;
            openFileBtn.Text = "Open file";
            openFileBtn.UseVisualStyleBackColor = true;
            openFileBtn.Click += openFileBtn_Click;
            // 
            // filePathLbl
            // 
            filePathLbl.AutoSize = true;
            filePathLbl.Location = new Point(143, 45);
            filePathLbl.Name = "filePathLbl";
            filePathLbl.Size = new Size(92, 15);
            filePathLbl.TabIndex = 3;
            filePathLbl.Text = "File not selected";
            // 
            // EncryptBtn
            // 
            EncryptBtn.Location = new Point(12, 95);
            EncryptBtn.Name = "EncryptBtn";
            EncryptBtn.Size = new Size(110, 23);
            EncryptBtn.TabIndex = 4;
            EncryptBtn.Text = "Encrypt";
            EncryptBtn.UseVisualStyleBackColor = true;
            EncryptBtn.Click += EncryptBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(278, 95);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(146, 23);
            CloseBtn.TabIndex = 5;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 79);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(412, 10);
            progressBar1.TabIndex = 6;
            // 
            // ProgressLbl
            // 
            ProgressLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProgressLbl.AutoSize = true;
            ProgressLbl.Location = new Point(401, 61);
            ProgressLbl.Name = "ProgressLbl";
            ProgressLbl.Size = new Size(23, 15);
            ProgressLbl.TabIndex = 7;
            ProgressLbl.Text = "0%";
            ProgressLbl.TextAlign = ContentAlignment.TopRight;
            // 
            // openFileDlg
            // 
            openFileDlg.FileName = "openFileDlg";
            openFileDlg.Filter = "*.*|All files";
            // 
            // EncryptionBw
            // 
            EncryptionBw.DoWork += EncryptionBw_DoWork;
            EncryptionBw.ProgressChanged += EncryptionBw_ProgressChanged;
            EncryptionBw.RunWorkerCompleted += EncryptionBw_RunWorkerCompleted;
            // 
            // DecryptBtn
            // 
            DecryptBtn.Location = new Point(128, 95);
            DecryptBtn.Name = "DecryptBtn";
            DecryptBtn.Size = new Size(110, 23);
            DecryptBtn.TabIndex = 8;
            DecryptBtn.Text = "Decrypt";
            DecryptBtn.UseVisualStyleBackColor = true;
            DecryptBtn.Click += DecryptBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 126);
            Controls.Add(DecryptBtn);
            Controls.Add(ProgressLbl);
            Controls.Add(progressBar1);
            Controls.Add(CloseBtn);
            Controls.Add(EncryptBtn);
            Controls.Add(filePathLbl);
            Controls.Add(openFileBtn);
            Controls.Add(keyTitleLbl);
            Controls.Add(keyTb);
            MaximumSize = new Size(452, 165);
            MinimumSize = new Size(452, 165);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox keyTb;
        private Label keyTitleLbl;
        private Button openFileBtn;
        private Label filePathLbl;
        private Button EncryptBtn;
        private Button CloseBtn;
        private ProgressBar progressBar1;
        private Label ProgressLbl;
        private OpenFileDialog openFileDlg;
        private System.ComponentModel.BackgroundWorker EncryptionBw;
        private Button DecryptBtn;
    }
}