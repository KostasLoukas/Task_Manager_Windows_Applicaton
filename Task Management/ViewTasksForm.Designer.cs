
namespace Task_Management
{
    partial class ViewTasksForm
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
            this.ViewTasksListBox = new System.Windows.Forms.ListBox();
            this.ViewTasksRefreshWarning = new System.Windows.Forms.Label();
            this.CloseViewTasksWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewTasksListBox
            // 
            this.ViewTasksListBox.FormattingEnabled = true;
            this.ViewTasksListBox.HorizontalScrollbar = true;
            this.ViewTasksListBox.Location = new System.Drawing.Point(68, 55);
            this.ViewTasksListBox.Name = "ViewTasksListBox";
            this.ViewTasksListBox.ScrollAlwaysVisible = true;
            this.ViewTasksListBox.Size = new System.Drawing.Size(646, 316);
            this.ViewTasksListBox.TabIndex = 0;
            // 
            // ViewTasksRefreshWarning
            // 
            this.ViewTasksRefreshWarning.AutoSize = true;
            this.ViewTasksRefreshWarning.Location = new System.Drawing.Point(68, 378);
            this.ViewTasksRefreshWarning.Name = "ViewTasksRefreshWarning";
            this.ViewTasksRefreshWarning.Size = new System.Drawing.Size(234, 13);
            this.ViewTasksRefreshWarning.TabIndex = 1;
            this.ViewTasksRefreshWarning.Text = "*Hint: Re-open window to refresh page contents";
            // 
            // CloseViewTasksWindowButton
            // 
            this.CloseViewTasksWindowButton.Location = new System.Drawing.Point(68, 406);
            this.CloseViewTasksWindowButton.Name = "CloseViewTasksWindowButton";
            this.CloseViewTasksWindowButton.Size = new System.Drawing.Size(75, 23);
            this.CloseViewTasksWindowButton.TabIndex = 5;
            this.CloseViewTasksWindowButton.Text = "Close";
            this.CloseViewTasksWindowButton.UseVisualStyleBackColor = true;
            this.CloseViewTasksWindowButton.Click += new System.EventHandler(this.CloseViewTasksWindowButton_Click);
            // 
            // ViewTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseViewTasksWindowButton);
            this.Controls.Add(this.ViewTasksRefreshWarning);
            this.Controls.Add(this.ViewTasksListBox);
            this.Name = "ViewTasksForm";
            this.Text = "ViewTasksForm";
            this.Load += new System.EventHandler(this.ViewTasksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ViewTasksListBox;
        private System.Windows.Forms.Label ViewTasksRefreshWarning;
        private System.Windows.Forms.Button CloseViewTasksWindowButton;
    }
}