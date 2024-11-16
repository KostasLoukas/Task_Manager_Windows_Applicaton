
namespace Task_Management
{
    partial class EditTaskStatusForm
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
            this.EditTaskStatusDropDown = new System.Windows.Forms.ComboBox();
            this.EditTaskStatusLabel = new System.Windows.Forms.Label();
            this.UpdateTaskStatusButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditTaskStatusDropDown
            // 
            this.EditTaskStatusDropDown.FormattingEnabled = true;
            this.EditTaskStatusDropDown.Items.AddRange(new object[] {
            "Pending",
            "In progress",
            "Completed"});
            this.EditTaskStatusDropDown.Location = new System.Drawing.Point(164, 124);
            this.EditTaskStatusDropDown.Name = "EditTaskStatusDropDown";
            this.EditTaskStatusDropDown.Size = new System.Drawing.Size(137, 21);
            this.EditTaskStatusDropDown.TabIndex = 0;
            this.EditTaskStatusDropDown.SelectedIndexChanged += new System.EventHandler(this.EditTaskStatusDropDown_SelectedIndexChanged);
            // 
            // EditTaskStatusLabel
            // 
            this.EditTaskStatusLabel.AutoSize = true;
            this.EditTaskStatusLabel.Location = new System.Drawing.Point(190, 108);
            this.EditTaskStatusLabel.Name = "EditTaskStatusLabel";
            this.EditTaskStatusLabel.Size = new System.Drawing.Size(88, 13);
            this.EditTaskStatusLabel.TabIndex = 1;
            this.EditTaskStatusLabel.Text = "Edit Task Status:";
            // 
            // UpdateTaskStatusButton2
            // 
            this.UpdateTaskStatusButton2.Location = new System.Drawing.Point(193, 248);
            this.UpdateTaskStatusButton2.Name = "UpdateTaskStatusButton2";
            this.UpdateTaskStatusButton2.Size = new System.Drawing.Size(85, 22);
            this.UpdateTaskStatusButton2.TabIndex = 2;
            this.UpdateTaskStatusButton2.Text = "Update";
            this.UpdateTaskStatusButton2.UseVisualStyleBackColor = true;
            this.UpdateTaskStatusButton2.Click += new System.EventHandler(this.UpdateTaskStatusButton2_Click);
            // 
            // EditTaskStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 282);
            this.Controls.Add(this.UpdateTaskStatusButton2);
            this.Controls.Add(this.EditTaskStatusLabel);
            this.Controls.Add(this.EditTaskStatusDropDown);
            this.Name = "EditTaskStatusForm";
            this.Text = "EditTaskStatusForm";
            this.Load += new System.EventHandler(this.EditTaskStatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EditTaskStatusDropDown;
        private System.Windows.Forms.Label EditTaskStatusLabel;
        private System.Windows.Forms.Button UpdateTaskStatusButton2;
    }
}