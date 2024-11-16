
namespace Task_Management
{
    partial class MainMenu
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
            this.NewTaskButton = new System.Windows.Forms.Button();
            this.UpdateTaskButton = new System.Windows.Forms.Button();
            this.ViewTasksButton = new System.Windows.Forms.Button();
            this.SaveTasksToFileButton = new System.Windows.Forms.Button();
            this.FileSavedLabel = new System.Windows.Forms.Label();
            this.FileNotSavedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.Location = new System.Drawing.Point(292, 48);
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(128, 40);
            this.NewTaskButton.TabIndex = 0;
            this.NewTaskButton.Text = "New Task";
            this.NewTaskButton.UseVisualStyleBackColor = true;
            this.NewTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // UpdateTaskButton
            // 
            this.UpdateTaskButton.Location = new System.Drawing.Point(292, 111);
            this.UpdateTaskButton.Name = "UpdateTaskButton";
            this.UpdateTaskButton.Size = new System.Drawing.Size(128, 40);
            this.UpdateTaskButton.TabIndex = 4;
            this.UpdateTaskButton.Text = "Update Task";
            this.UpdateTaskButton.UseVisualStyleBackColor = true;
            this.UpdateTaskButton.Click += new System.EventHandler(this.UpdateTaskButton_Click);
            // 
            // ViewTasksButton
            // 
            this.ViewTasksButton.Location = new System.Drawing.Point(292, 174);
            this.ViewTasksButton.Name = "ViewTasksButton";
            this.ViewTasksButton.Size = new System.Drawing.Size(128, 40);
            this.ViewTasksButton.TabIndex = 5;
            this.ViewTasksButton.Text = "View Tasks";
            this.ViewTasksButton.UseVisualStyleBackColor = true;
            this.ViewTasksButton.Click += new System.EventHandler(this.ViewTasksButton_Click);
            // 
            // SaveTasksToFileButton
            // 
            this.SaveTasksToFileButton.Location = new System.Drawing.Point(292, 238);
            this.SaveTasksToFileButton.Name = "SaveTasksToFileButton";
            this.SaveTasksToFileButton.Size = new System.Drawing.Size(128, 40);
            this.SaveTasksToFileButton.TabIndex = 6;
            this.SaveTasksToFileButton.Text = "Save Tasks To File";
            this.SaveTasksToFileButton.UseVisualStyleBackColor = true;
            this.SaveTasksToFileButton.Click += new System.EventHandler(this.SaveTasksToFileButton_Click);
            // 
            // FileSavedLabel
            // 
            this.FileSavedLabel.AutoSize = true;
            this.FileSavedLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.FileSavedLabel.Location = new System.Drawing.Point(295, 281);
            this.FileSavedLabel.Name = "FileSavedLabel";
            this.FileSavedLabel.Size = new System.Drawing.Size(57, 13);
            this.FileSavedLabel.TabIndex = 7;
            this.FileSavedLabel.Text = "File Saved";
            // 
            // FileNotSavedLabel
            // 
            this.FileNotSavedLabel.AutoSize = true;
            this.FileNotSavedLabel.ForeColor = System.Drawing.Color.Maroon;
            this.FileNotSavedLabel.Location = new System.Drawing.Point(309, 281);
            this.FileNotSavedLabel.Name = "FileNotSavedLabel";
            this.FileNotSavedLabel.Size = new System.Drawing.Size(77, 13);
            this.FileNotSavedLabel.TabIndex = 8;
            this.FileNotSavedLabel.Text = "File Not Saved";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 354);
            this.Controls.Add(this.FileNotSavedLabel);
            this.Controls.Add(this.FileSavedLabel);
            this.Controls.Add(this.SaveTasksToFileButton);
            this.Controls.Add(this.ViewTasksButton);
            this.Controls.Add(this.UpdateTaskButton);
            this.Controls.Add(this.NewTaskButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewTaskButton;
        private System.Windows.Forms.Button UpdateTaskButton;
        private System.Windows.Forms.Button ViewTasksButton;
        private System.Windows.Forms.Button SaveTasksToFileButton;
        private System.Windows.Forms.Label FileSavedLabel;
        private System.Windows.Forms.Label FileNotSavedLabel;
    }
}

