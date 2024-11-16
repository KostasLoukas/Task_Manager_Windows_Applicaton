using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management
{
    public partial class MainMenu : Form
    {
        bool fileWriteSuccess;
        public MainMenu()
        {
            InitializeComponent();
            FileSavedLabel.Hide();
            FileNotSavedLabel.Hide();
        }

        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            //Create a New Task window
            NewTaskForm form = new NewTaskForm();
            form.Show();
            FileSavedLabel.Hide();
            FileNotSavedLabel.Hide();
        }

        private void UpdateTaskButton_Click(object sender, EventArgs e)
        {
            //Create a new Update Task window
            UpdateTaskForm form = new UpdateTaskForm();
            form.Show();
            FileSavedLabel.Hide();
            FileNotSavedLabel.Hide();
        }

        private void ViewTasksButton_Click(object sender, EventArgs e)
        {
            ViewTasksForm form = new ViewTasksForm();
            form.Show();
            FileSavedLabel.Hide();
            FileNotSavedLabel.Hide();
        }

        private void SaveTasksToFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter("Tasks.csv"))
                {
                    //Write Header of file
                    outputFile.WriteLine("Task Title;Task Description;Task Priority;Task Deadline;Task Status");
                    //write Saved Tasks
                    foreach (string task in Tasks.tasks)
                        outputFile.WriteLine(task.Replace('@', ';'));
                }

                fileWriteSuccess = true;
            }
            catch (IOException ex)
            {
                fileWriteSuccess = false;
            }

            if (fileWriteSuccess)
            {
                FileNotSavedLabel.Hide();
                FileSavedLabel.Text = "File Saved Successfully!";
                FileSavedLabel.Show();
            }
            else
            {
                FileSavedLabel.Hide();
                FileNotSavedLabel.Text = "Save to file failed...";
                FileNotSavedLabel.Show();
            }

        }
    }
}
