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
    public partial class NewTaskForm : Form
    {
        string titleText;
        string descriptionText;
        string priority = "10"; //default priority
        string dateTime = DateTime.Now.ToString().Substring(0, 10); //default date

        public NewTaskForm()
        {
            InitializeComponent();
        }

        private void NewTaskForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SubmitTaskButton_Click(object sender, EventArgs e)
        {
            Tasks.tasks.Add(titleText + Tasks.stringDelimiter + descriptionText + Tasks.stringDelimiter + priority + Tasks.stringDelimiter
                + dateTime.Substring(0, 10) + Tasks.stringDelimiter + "Pending");
            this.Close();
        }
        //Title Text Box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            titleText = TaskTitleTextBox.Text;
        }

        //Description Text Box
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            descriptionText = TaskDescriptionTextBox.Text;
        }

        //Task Priorities DropDown
        private void PrioritiesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            priority = PrioritiesDropDown.Text;
        }

        //Task Deadline Calendar
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTime = TaskDeadlineCalendar.SelectionRange.Start.ToString();
        }











        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TaskTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
