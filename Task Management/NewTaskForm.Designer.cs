
namespace Task_Management
{
    partial class NewTaskForm
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
            this.TaskTitleTextBox = new System.Windows.Forms.TextBox();
            this.TaskTitleLabel = new System.Windows.Forms.Label();
            this.SubmitTaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TaskDeadlineCalendar = new System.Windows.Forms.MonthCalendar();
            this.PrioritiesDropDown = new System.Windows.Forms.ComboBox();
            this.TaskPriorityLabel = new System.Windows.Forms.Label();
            this.TaskDeadlineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskTitleTextBox
            // 
            this.TaskTitleTextBox.Location = new System.Drawing.Point(13, 46);
            this.TaskTitleTextBox.MaxLength = 20;
            this.TaskTitleTextBox.Name = "TaskTitleTextBox";
            this.TaskTitleTextBox.Size = new System.Drawing.Size(140, 20);
            this.TaskTitleTextBox.TabIndex = 0;
            this.TaskTitleTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TaskTitleLabel
            // 
            this.TaskTitleLabel.AutoSize = true;
            this.TaskTitleLabel.Location = new System.Drawing.Point(52, 30);
            this.TaskTitleLabel.Name = "TaskTitleLabel";
            this.TaskTitleLabel.Size = new System.Drawing.Size(54, 13);
            this.TaskTitleLabel.TabIndex = 1;
            this.TaskTitleLabel.Text = "Task Title";
            this.TaskTitleLabel.Click += new System.EventHandler(this.TaskTitleLabel_Click);
            // 
            // SubmitTaskButton
            // 
            this.SubmitTaskButton.Location = new System.Drawing.Point(301, 209);
            this.SubmitTaskButton.Name = "SubmitTaskButton";
            this.SubmitTaskButton.Size = new System.Drawing.Size(96, 31);
            this.SubmitTaskButton.TabIndex = 2;
            this.SubmitTaskButton.Text = "Submit Task";
            this.SubmitTaskButton.UseVisualStyleBackColor = true;
            this.SubmitTaskButton.Click += new System.EventHandler(this.SubmitTaskButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task Description";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TaskDescriptionTextBox
            // 
            this.TaskDescriptionTextBox.Location = new System.Drawing.Point(174, 46);
            this.TaskDescriptionTextBox.MaxLength = 200;
            this.TaskDescriptionTextBox.Multiline = true;
            this.TaskDescriptionTextBox.Name = "TaskDescriptionTextBox";
            this.TaskDescriptionTextBox.Size = new System.Drawing.Size(140, 82);
            this.TaskDescriptionTextBox.TabIndex = 3;
            this.TaskDescriptionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // TaskDeadlineCalendar
            // 
            this.TaskDeadlineCalendar.Location = new System.Drawing.Point(506, 46);
            this.TaskDeadlineCalendar.MaxSelectionCount = 1;
            this.TaskDeadlineCalendar.Name = "TaskDeadlineCalendar";
            this.TaskDeadlineCalendar.TabIndex = 6;
            this.TaskDeadlineCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // PrioritiesDropDown
            // 
            this.PrioritiesDropDown.FormattingEnabled = true;
            this.PrioritiesDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PrioritiesDropDown.Location = new System.Drawing.Point(346, 46);
            this.PrioritiesDropDown.MaxDropDownItems = 10;
            this.PrioritiesDropDown.Name = "PrioritiesDropDown";
            this.PrioritiesDropDown.Size = new System.Drawing.Size(138, 21);
            this.PrioritiesDropDown.TabIndex = 5;
            this.PrioritiesDropDown.SelectedIndexChanged += new System.EventHandler(this.PrioritiesDropDown_SelectedIndexChanged);
            // 
            // TaskPriorityLabel
            // 
            this.TaskPriorityLabel.AutoSize = true;
            this.TaskPriorityLabel.Location = new System.Drawing.Point(386, 30);
            this.TaskPriorityLabel.Name = "TaskPriorityLabel";
            this.TaskPriorityLabel.Size = new System.Drawing.Size(65, 13);
            this.TaskPriorityLabel.TabIndex = 7;
            this.TaskPriorityLabel.Text = "Task Priority";
            this.TaskPriorityLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TaskDeadlineLabel
            // 
            this.TaskDeadlineLabel.AutoSize = true;
            this.TaskDeadlineLabel.Location = new System.Drawing.Point(585, 30);
            this.TaskDeadlineLabel.Name = "TaskDeadlineLabel";
            this.TaskDeadlineLabel.Size = new System.Drawing.Size(76, 13);
            this.TaskDeadlineLabel.TabIndex = 8;
            this.TaskDeadlineLabel.Text = "Task Deadline";
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 252);
            this.Controls.Add(this.TaskDeadlineLabel);
            this.Controls.Add(this.TaskPriorityLabel);
            this.Controls.Add(this.TaskDeadlineCalendar);
            this.Controls.Add(this.PrioritiesDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskDescriptionTextBox);
            this.Controls.Add(this.SubmitTaskButton);
            this.Controls.Add(this.TaskTitleLabel);
            this.Controls.Add(this.TaskTitleTextBox);
            this.Name = "NewTaskForm";
            this.Text = "NewTaskForm";
            this.Load += new System.EventHandler(this.NewTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TaskTitleTextBox;
        private System.Windows.Forms.Label TaskTitleLabel;
        private System.Windows.Forms.Button SubmitTaskButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TaskDescriptionTextBox;
        private System.Windows.Forms.MonthCalendar TaskDeadlineCalendar;
        private System.Windows.Forms.ComboBox PrioritiesDropDown;
        private System.Windows.Forms.Label TaskPriorityLabel;
        private System.Windows.Forms.Label TaskDeadlineLabel;
    }
}