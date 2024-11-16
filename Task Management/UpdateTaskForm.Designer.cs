
namespace Task_Management
{
    partial class UpdateTaskForm
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
            this.TasksListBox = new System.Windows.Forms.ListBox();
            this.EditTaskButton = new System.Windows.Forms.Button();
            this.UpdateTaskStatusButton = new System.Windows.Forms.Button();
            this.UpdateTaskRefreshWarning = new System.Windows.Forms.Label();
            this.CloseUpdateTaskWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TasksListBox
            // 
            this.TasksListBox.FormattingEnabled = true;
            this.TasksListBox.HorizontalScrollbar = true;
            this.TasksListBox.Location = new System.Drawing.Point(91, 45);
            this.TasksListBox.Name = "TasksListBox";
            this.TasksListBox.ScrollAlwaysVisible = true;
            this.TasksListBox.Size = new System.Drawing.Size(614, 342);
            this.TasksListBox.TabIndex = 0;
            this.TasksListBox.SelectedIndexChanged += new System.EventHandler(this.TasksListBox_SelectedIndexChanged);
            // 
            // EditTaskButton
            // 
            this.EditTaskButton.Location = new System.Drawing.Point(630, 415);
            this.EditTaskButton.Name = "EditTaskButton";
            this.EditTaskButton.Size = new System.Drawing.Size(75, 23);
            this.EditTaskButton.TabIndex = 1;
            this.EditTaskButton.Text = "Edit Task";
            this.EditTaskButton.UseVisualStyleBackColor = true;
            this.EditTaskButton.Click += new System.EventHandler(this.EditTaskButton_Click);
            // 
            // UpdateTaskStatusButton
            // 
            this.UpdateTaskStatusButton.Location = new System.Drawing.Point(517, 415);
            this.UpdateTaskStatusButton.Name = "UpdateTaskStatusButton";
            this.UpdateTaskStatusButton.Size = new System.Drawing.Size(107, 23);
            this.UpdateTaskStatusButton.TabIndex = 2;
            this.UpdateTaskStatusButton.Text = "Update Status";
            this.UpdateTaskStatusButton.UseVisualStyleBackColor = true;
            this.UpdateTaskStatusButton.Click += new System.EventHandler(this.UpdateTaskStatusButton_Click);
            // 
            // UpdateTaskRefreshWarning
            // 
            this.UpdateTaskRefreshWarning.AutoSize = true;
            this.UpdateTaskRefreshWarning.Location = new System.Drawing.Point(88, 390);
            this.UpdateTaskRefreshWarning.Name = "UpdateTaskRefreshWarning";
            this.UpdateTaskRefreshWarning.Size = new System.Drawing.Size(234, 13);
            this.UpdateTaskRefreshWarning.TabIndex = 3;
            this.UpdateTaskRefreshWarning.Text = "*Hint: Re-open window to refresh page contents";
            // 
            // CloseUpdateTaskWindowButton
            // 
            this.CloseUpdateTaskWindowButton.Location = new System.Drawing.Point(91, 415);
            this.CloseUpdateTaskWindowButton.Name = "CloseUpdateTaskWindowButton";
            this.CloseUpdateTaskWindowButton.Size = new System.Drawing.Size(75, 23);
            this.CloseUpdateTaskWindowButton.TabIndex = 4;
            this.CloseUpdateTaskWindowButton.Text = "Close";
            this.CloseUpdateTaskWindowButton.UseVisualStyleBackColor = true;
            this.CloseUpdateTaskWindowButton.Click += new System.EventHandler(this.CloseUpdateTaskWindowButton_Click);
            // 
            // UpdateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseUpdateTaskWindowButton);
            this.Controls.Add(this.UpdateTaskRefreshWarning);
            this.Controls.Add(this.UpdateTaskStatusButton);
            this.Controls.Add(this.EditTaskButton);
            this.Controls.Add(this.TasksListBox);
            this.Name = "UpdateTaskForm";
            this.Text = "UpdateTaskForm";
            this.Load += new System.EventHandler(this.UpdateTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TasksListBox;
        private System.Windows.Forms.Button EditTaskButton;
        private System.Windows.Forms.Button UpdateTaskStatusButton;
        private System.Windows.Forms.Label UpdateTaskRefreshWarning;
        private System.Windows.Forms.Button CloseUpdateTaskWindowButton;
    }
}