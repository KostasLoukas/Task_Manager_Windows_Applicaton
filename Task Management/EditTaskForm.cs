using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management
{
    public partial class EditTaskForm : Form
    {
        string[] texts = new string[5];
        public EditTaskForm()
        {
            InitializeComponent();
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            //Fetch each part of the task and store them in a temporary table to show them in the edit window for reference
            texts = Tasks.tasks[UpdateTaskForm.taskListBoxIndex].Split(Tasks.stringDelimiter);
            EditTaskTitleTextBox.Text = texts[0];
            EditTaskDescriptionTextBox.Text = texts[1];
            EditPrioritiesDropDown.SelectedIndex = Int32.Parse(texts[2]) - 1;
            EditTaskDeadlineCalendar.SelectionRange.Start = DateTime.Parse(texts[3]);
        }

        private void EditTaskTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            texts[0] = EditTaskTitleTextBox.Text;
        }

        private void EditTaskDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            texts[1] = EditTaskDescriptionTextBox.Text;
        }

        private void EditPrioritiesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            texts[2] = EditPrioritiesDropDown.Text;
        }

        private void EditTaskDeadlineCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            texts[3] = EditTaskDeadlineCalendar.SelectionRange.Start.ToString();
        }

        //Update task values
        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            Tasks.tasks[UpdateTaskForm.taskListBoxIndex] = texts[0] + Tasks.stringDelimiter + texts[1] + Tasks.stringDelimiter + texts[2] + Tasks.stringDelimiter
                + texts[3].Substring(0, 10) + Tasks.stringDelimiter + texts[4];
            this.Close();
        }
    }
}
