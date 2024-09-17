using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        private List<Task> tasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(taskTextBox.Text))
            {
                Task newTask = new Task(taskTextBox.Text);
                tasks.Add(newTask);
                taskListBox.Items.Add(newTask);
                taskTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                int index = taskListBox.SelectedIndex;
                tasks.RemoveAt(index);
                taskListBox.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void markCompleteButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                int index = taskListBox.SelectedIndex;
                tasks[index].MarkComplete();
                taskListBox.Items[index] = tasks[index];
            }
            else
            {
                MessageBox.Show("Please select a task to mark as complete.");
            }
        }
    }
}
