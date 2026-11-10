namespace PomodoroTaskManager
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
            components = new System.ComponentModel.Container();
            lblTimer = new Label();
            lblStatus = new Label();
            btnStartPause = new Button();
            btnReset = new Button();
            txtNewTask = new TextBox();
            btnAddTask = new Button();
            lstTasks = new ListBox();
            btnDeleteTask = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTimer.Location = new Point(1, 27);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(153, 65);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "25:00";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(17, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(86, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Munka időszak";
            // 
            // btnStartPause
            // 
            btnStartPause.Location = new Point(12, 104);
            btnStartPause.Name = "btnStartPause";
            btnStartPause.Size = new Size(75, 23);
            btnStartPause.TabIndex = 2;
            btnStartPause.Text = "Indítás";
            btnStartPause.UseVisualStyleBackColor = true;
            btnStartPause.Click += btnStartPause_Click_1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(93, 104);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "Visszaállítás";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // txtNewTask
            // 
            txtNewTask.Location = new Point(12, 197);
            txtNewTask.Multiline = true;
            txtNewTask.Name = "txtNewTask";
            txtNewTask.Size = new Size(100, 25);
            txtNewTask.TabIndex = 4;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(1, 148);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(102, 23);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "Hozzáadás";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click_1;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(223, 95);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(511, 319);
            lstTasks.TabIndex = 6;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(109, 148);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(102, 23);
            btnDeleteTask.TabIndex = 7;
            btnDeleteTask.Text = "Kész/törlés";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click_1;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteTask);
            Controls.Add(lstTasks);
            Controls.Add(btnAddTask);
            Controls.Add(txtNewTask);
            Controls.Add(btnReset);
            Controls.Add(btnStartPause);
            Controls.Add(lblStatus);
            Controls.Add(lblTimer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Label lblStatus;
        private Button btnStartPause;
        private Button btnReset;
        private TextBox txtNewTask;
        private Button btnAddTask;
        private ListBox lstTasks;
        private Button btnDeleteTask;
        private System.Windows.Forms.Timer timer1;
    }
}
