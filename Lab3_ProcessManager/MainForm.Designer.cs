namespace Lab3_ProcessManager
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            PID = new DataGridViewTextBoxColumn();
            RAM = new DataGridViewTextBoxColumn();
            StartTime = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Threads = new DataGridViewTextBoxColumn();
            selectProcessCbx = new ComboBox();
            runProcBtn = new Button();
            killProcessBtn = new Button();
            priorityCbx = new ComboBox();
            changePriorityBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, PID, RAM, StartTime, Priority, Threads });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 367);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // PID
            // 
            PID.HeaderText = "PID";
            PID.Name = "PID";
            PID.ReadOnly = true;
            // 
            // RAM
            // 
            RAM.HeaderText = "RAM";
            RAM.Name = "RAM";
            RAM.ReadOnly = true;
            // 
            // StartTime
            // 
            StartTime.HeaderText = "Start Time";
            StartTime.Name = "StartTime";
            StartTime.ReadOnly = true;
            // 
            // Priority
            // 
            Priority.HeaderText = "Priority";
            Priority.Name = "Priority";
            Priority.ReadOnly = true;
            // 
            // Threads
            // 
            Threads.HeaderText = "Threads";
            Threads.Name = "Threads";
            Threads.ReadOnly = true;
            // 
            // selectProcessCbx
            // 
            selectProcessCbx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectProcessCbx.Items.AddRange(new object[] { "Calculator", "Microsoft Word", "Microsoft Excel", "Notepad", "Paint" });
            selectProcessCbx.Location = new Point(12, 12);
            selectProcessCbx.Name = "selectProcessCbx";
            selectProcessCbx.Size = new Size(638, 23);
            selectProcessCbx.TabIndex = 0;
            // 
            // runProcBtn
            // 
            runProcBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            runProcBtn.Location = new Point(656, 12);
            runProcBtn.Name = "runProcBtn";
            runProcBtn.Size = new Size(132, 23);
            runProcBtn.TabIndex = 1;
            runProcBtn.Text = "Run process";
            runProcBtn.UseVisualStyleBackColor = true;
            runProcBtn.Click += runProcBtn_Click;
            // 
            // killProcessBtn
            // 
            killProcessBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            killProcessBtn.Location = new Point(567, 414);
            killProcessBtn.Name = "killProcessBtn";
            killProcessBtn.Size = new Size(221, 24);
            killProcessBtn.TabIndex = 3;
            killProcessBtn.Text = "Kill process";
            killProcessBtn.UseVisualStyleBackColor = true;
            killProcessBtn.Click += killProcessBtn_Click;
            // 
            // priorityCbx
            // 
            priorityCbx.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            priorityCbx.DisplayMember = "1";
            priorityCbx.FormattingEnabled = true;
            priorityCbx.Items.AddRange(new object[] { "Realtime", "High", "Above normal", "Normal", "Below normal", "Low" });
            priorityCbx.Location = new Point(12, 416);
            priorityCbx.Name = "priorityCbx";
            priorityCbx.Size = new Size(193, 23);
            priorityCbx.TabIndex = 4;
            // 
            // changePriorityBtn
            // 
            changePriorityBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            changePriorityBtn.Location = new Point(211, 416);
            changePriorityBtn.Name = "changePriorityBtn";
            changePriorityBtn.Size = new Size(175, 23);
            changePriorityBtn.TabIndex = 5;
            changePriorityBtn.Text = "Change priority";
            changePriorityBtn.UseVisualStyleBackColor = true;
            changePriorityBtn.Click += changePriorityBtn_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            timer1.Tick += UpdateData;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(changePriorityBtn);
            Controls.Add(priorityCbx);
            Controls.Add(killProcessBtn);
            Controls.Add(dataGridView1);
            Controls.Add(runProcBtn);
            Controls.Add(selectProcessCbx);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox selectProcessCbx;
        private Button runProcBtn;
        private DataGridView dataGridView1;
        private Button killProcessBtn;
        private ComboBox priorityCbx;
        private Button changePriorityBtn;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn PID;
        private DataGridViewTextBoxColumn RAM;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Threads;
        private System.Windows.Forms.Timer timer1;
    }
}