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
    public partial class EditTaskStatusForm : Form
    {
        string[] texts = new string[5];
        public EditTaskStatusForm()
        {
            InitializeComponent();
        }

        private void EditTaskStatusForm_Load(object sender, EventArgs e)
        {
            //Fetch each part of the task and store them in a temporary table to show them in the edit window for reference
            texts = Tasks.tasks[UpdateTaskForm.taskListBoxIndex].Split(Tasks.stringDelimiter);
        }

        private void UpdateTaskStatusButton2_Click(object sender, EventArgs e)
        {
            Tasks.tasks[UpdateTaskForm.taskListBoxIndex] = texts[0] + Tasks.stringDelimiter + texts[1] + Tasks.stringDelimiter + texts[2] + Tasks.stringDelimiter
                + texts[3].Substring(0, 10) + Tasks.stringDelimiter + texts[4];
            this.Close();
        }

        private void EditTaskStatusDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            texts[4] = EditTaskStatusDropDown.Text;
        }
    }
}
