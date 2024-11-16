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
    public partial class UpdateTaskForm : Form
    {
        public static int taskListBoxIndex = -1;
        public UpdateTaskForm()
        {
            InitializeComponent();
        }

        private void UpdateTaskForm_Load(object sender, EventArgs e)
        {
            TasksListBox.DataSource = Tasks.tasks;
        }

        private void TasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            taskListBoxIndex = TasksListBox.SelectedIndex;
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            EditTaskForm form = new EditTaskForm();
            form.Show();
        }

        private void UpdateTaskStatusButton_Click(object sender, EventArgs e)
        {
            EditTaskStatusForm form = new EditTaskStatusForm();
            form.Show();
        }

        private void CloseUpdateTaskWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
