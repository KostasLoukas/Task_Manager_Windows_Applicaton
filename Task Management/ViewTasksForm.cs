﻿using System;
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
    public partial class ViewTasksForm : Form
    {
        public ViewTasksForm()
        {
            InitializeComponent();
        }

        private void ViewTasksForm_Load(object sender, EventArgs e)
        {
            ViewTasksListBox.DataSource = Tasks.tasks;
        }

        private void CloseViewTasksWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
