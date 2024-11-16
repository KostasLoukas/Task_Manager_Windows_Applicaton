
namespace Task_Management
{
    partial class EditTaskForm
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
            this.EditTaskDeadlineLabel = new System.Windows.Forms.Label();
            this.EditTaskPriorityLabel = new System.Windows.Forms.Label();
            this.EditTaskDeadlineCalendar = new System.Windows.Forms.MonthCalendar();
            this.EditPrioritiesDropDown = new System.Windows.Forms.ComboBox();
            this.EditTaskDescriptionLabel = new System.Windows.Forms.Label();
            this.EditTaskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.EditTaskButton = new System.Windows.Forms.Button();
            this.EditTaskTitleLabel = new System.Windows.Forms.Label();
            this.EditTaskTitleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditTaskDeadlineLabel
            // 
            this.EditTaskDeadlineLabel.AutoSize = true;
            this.EditTaskDeadlineLabel.Location = new System.Drawing.Point(600, 36);
            this.EditTaskDeadlineLabel.Name = "EditTaskDeadlineLabel";
            this.EditTaskDeadlineLabel.Size = new System.Drawing.Size(76, 13);
            this.EditTaskDeadlineLabel.TabIndex = 17;
            this.EditTaskDeadlineLabel.Text = "Task Deadline";
            // 
            // EditTaskPriorityLabel
            // 
            this.EditTaskPriorityLabel.AutoSize = true;
            this.EditTaskPriorityLabel.Location = new System.Drawing.Point(401, 36);
            this.EditTaskPriorityLabel.Name = "EditTaskPriorityLabel";
            this.EditTaskPriorityLabel.Size = new System.Drawing.Size(65, 13);
            this.EditTaskPriorityLabel.TabIndex = 16;
            this.EditTaskPriorityLabel.Text = "Task Priority";
            // 
            // EditTaskDeadlineCalendar
            // 
            this.EditTaskDeadlineCalendar.Location = new System.Drawing.Point(521, 52);
            this.EditTaskDeadlineCalendar.MaxSelectionCount = 1;
            this.EditTaskDeadlineCalendar.Name = "EditTaskDeadlineCalendar";
            this.EditTaskDeadlineCalendar.TabIndex = 15;
            this.EditTaskDeadlineCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.EditTaskDeadlineCalendar_DateChanged);
            // 
            // EditPrioritiesDropDown
            // 
            this.EditPrioritiesDropDown.FormattingEnabled = true;
            this.EditPrioritiesDropDown.Items.AddRange(new object[] {
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
            this.EditPrioritiesDropDown.Location = new System.Drawing.Point(361, 52);
            this.EditPrioritiesDropDown.MaxDropDownItems = 10;
            this.EditPrioritiesDropDown.Name = "EditPrioritiesDropDown";
            this.EditPrioritiesDropDown.Size = new System.Drawing.Size(138, 21);
            this.EditPrioritiesDropDown.TabIndex = 14;
            this.EditPrioritiesDropDown.SelectedIndexChanged += new System.EventHandler(this.EditPrioritiesDropDown_SelectedIndexChanged);
            // 
            // EditTaskDescriptionLabel
            // 
            this.EditTaskDescriptionLabel.AutoSize = true;
            this.EditTaskDescriptionLabel.Location = new System.Drawing.Point(211, 36);
            this.EditTaskDescriptionLabel.Name = "EditTaskDescriptionLabel";
            this.EditTaskDescriptionLabel.Size = new System.Drawing.Size(87, 13);
            this.EditTaskDescriptionLabel.TabIndex = 13;
            this.EditTaskDescriptionLabel.Text = "Task Description";
            // 
            // EditTaskDescriptionTextBox
            // 
            this.EditTaskDescriptionTextBox.Location = new System.Drawing.Point(189, 52);
            this.EditTaskDescriptionTextBox.MaxLength = 200;
            this.EditTaskDescriptionTextBox.Multiline = true;
            this.EditTaskDescriptionTextBox.Name = "EditTaskDescriptionTextBox";
            this.EditTaskDescriptionTextBox.Size = new System.Drawing.Size(140, 82);
            this.EditTaskDescriptionTextBox.TabIndex = 12;
            this.EditTaskDescriptionTextBox.TextChanged += new System.EventHandler(this.EditTaskDescriptionTextBox_TextChanged);
            // 
            // EditTaskButton
            // 
            this.EditTaskButton.Location = new System.Drawing.Point(316, 215);
            this.EditTaskButton.Name = "EditTaskButton";
            this.EditTaskButton.Size = new System.Drawing.Size(96, 31);
            this.EditTaskButton.TabIndex = 11;
            this.EditTaskButton.Text = "Update Task";
            this.EditTaskButton.UseVisualStyleBackColor = true;
            this.EditTaskButton.Click += new System.EventHandler(this.EditTaskButton_Click);
            // 
            // EditTaskTitleLabel
            // 
            this.EditTaskTitleLabel.AutoSize = true;
            this.EditTaskTitleLabel.Location = new System.Drawing.Point(67, 36);
            this.EditTaskTitleLabel.Name = "EditTaskTitleLabel";
            this.EditTaskTitleLabel.Size = new System.Drawing.Size(54, 13);
            this.EditTaskTitleLabel.TabIndex = 10;
            this.EditTaskTitleLabel.Text = "Task Title";
            // 
            // EditTaskTitleTextBox
            // 
            this.EditTaskTitleTextBox.Location = new System.Drawing.Point(28, 52);
            this.EditTaskTitleTextBox.MaxLength = 20;
            this.EditTaskTitleTextBox.Name = "EditTaskTitleTextBox";
            this.EditTaskTitleTextBox.Size = new System.Drawing.Size(140, 20);
            this.EditTaskTitleTextBox.TabIndex = 9;
            this.EditTaskTitleTextBox.TextChanged += new System.EventHandler(this.EditTaskTitleTextBox_TextChanged);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 283);
            this.Controls.Add(this.EditTaskDeadlineLabel);
            this.Controls.Add(this.EditTaskPriorityLabel);
            this.Controls.Add(this.EditTaskDeadlineCalendar);
            this.Controls.Add(this.EditPrioritiesDropDown);
            this.Controls.Add(this.EditTaskDescriptionLabel);
            this.Controls.Add(this.EditTaskDescriptionTextBox);
            this.Controls.Add(this.EditTaskButton);
            this.Controls.Add(this.EditTaskTitleLabel);
            this.Controls.Add(this.EditTaskTitleTextBox);
            this.Name = "EditTaskForm";
            this.Text = "EditTaskForm";
            this.Load += new System.EventHandler(this.EditTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditTaskDeadlineLabel;
        private System.Windows.Forms.Label EditTaskPriorityLabel;
        private System.Windows.Forms.MonthCalendar EditTaskDeadlineCalendar;
        private System.Windows.Forms.ComboBox EditPrioritiesDropDown;
        private System.Windows.Forms.Label EditTaskDescriptionLabel;
        private System.Windows.Forms.TextBox EditTaskDescriptionTextBox;
        private System.Windows.Forms.Button EditTaskButton;
        private System.Windows.Forms.Label EditTaskTitleLabel;
        private System.Windows.Forms.TextBox EditTaskTitleTextBox;
    }
}