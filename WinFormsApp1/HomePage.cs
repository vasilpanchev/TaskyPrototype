using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PresentationLayer
{
    public partial class HomePage : Form
    {
        TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
        private User currentUser;


        public HomePage(User user)
        {
            this.currentUser = user;

            InitializeComponent();

            HideNewTaskWindows();
            HideUpdateTaskWindows();

            UpdateData();
        }

        private void HideNewTaskWindows()
        {
            labelNewTaskHomePage.Hide();
            labelTitleTaskHomePage.Hide();
            labelEndDateTaskHomePage.Hide();
            tBTitleTaskHomePage.Hide();
            dTPTaskHomePage.Hide();
            btnClearInfoTaskHomePage.Hide();
            btnSaveNewTaskHomePage.Hide();
        }

        private void ShowNewTaskWindows()
        {
            labelNewTaskHomePage.Show();
            labelTitleTaskHomePage.Show();
            labelEndDateTaskHomePage.Show();
            tBTitleTaskHomePage.Show();
            dTPTaskHomePage.Show();
            btnClearInfoTaskHomePage.Show();
            btnSaveNewTaskHomePage.Show();
        }

        private void HideUpdateTaskWindows()
        {
            labelUpdateTaskHomePage.Hide();
            labelTitleTaskHomePage.Hide();
            labelEndDateTaskHomePage.Hide();
            tBTitleTaskHomePage.Hide();
            dTPTaskHomePage.Hide();
            btnClearInfoTaskHomePage.Hide();
            btnSaveUpdateTaskHomePage.Hide();
        }

        private void ShowUpdateTaskWindows()
        {
            labelUpdateTaskHomePage.Show();
            labelTitleTaskHomePage.Show();
            labelEndDateTaskHomePage.Show();
            tBTitleTaskHomePage.Show();
            dTPTaskHomePage.Show();
            btnClearInfoTaskHomePage.Show();
            btnSaveUpdateTaskHomePage.Show();
        }

        private void UpdateData()
        {
            UserTaskContext fromContextUserTask = new UserTaskContext(taskyPrototypeContext);
            dGVTasksHomePage.DataSource = fromContextUserTask.ReadAll().Where(x => x.Username == currentUser.Username).ToList();
            dGVTasksHomePage.ReadOnly = true;
            dGVTasksHomePage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            labelUsernameHomePage.Text = currentUser.Username;

        }

        private void btnNewTaskHomePage_Click(object sender, EventArgs e)
        {
            ShowNewTaskWindows();
        }

        private void btnUpdateTaskHomePage_Click(object sender, EventArgs e)
        {
            ShowUpdateTaskWindows();
        }

        private void btnDeleteTaskHomePage_Click(object sender, EventArgs e)
        {
            var item = dGVTasksHomePage.SelectedRows[0].Cells;
            var taskToUpdateId = int.Parse(item[0].Value.ToString());

            UserTaskContext userTaskContext = new UserTaskContext(taskyPrototypeContext);

            userTaskContext.Delete(taskToUpdateId);
            UpdateData();
        }

        private void btnClearInfoTaskHomePage_Click(object sender, EventArgs e)
        {
            tBTitleTaskHomePage.Clear();
        }

        private void btnSaveNewTaskHomePage_Click(object sender, EventArgs e)
        {
            string taskTitle = tBTitleTaskHomePage.Text;

            UserTaskContext userTaskContext = new(taskyPrototypeContext);

            UserTask userTask = new UserTask(taskTitle, "", DateTime.Now, dTPTaskHomePage.Value, currentUser.Username)
            {
                Title = taskTitle,
                StartDate = DateTime.Now,
                EndDate = dTPTaskHomePage.Value,
                Username = currentUser.Username
            };

            userTaskContext.Create(currentUser, userTask);
            UpdateData();
            HideNewTaskWindows();

            tBTitleTaskHomePage.Clear();
        }

        private void btnSaveUpdateTaskHomePage_Click(object sender, EventArgs e)
        {
            string taskTitle = tBTitleTaskHomePage.Text;

            var item = dGVTasksHomePage.SelectedRows[0].Cells;
            var taskToUpdateId = int.Parse(item[0].Value.ToString());

            UserTaskContext userTaskContext = new UserTaskContext(taskyPrototypeContext);

            UserTask selectedTask = userTaskContext.Read(taskToUpdateId);

            selectedTask.TaskId = taskToUpdateId;
            selectedTask.Title = taskTitle;
            selectedTask.StartDate = DateTime.Now;
            selectedTask.EndDate = dTPTaskHomePage.Value;

            userTaskContext.Update(selectedTask);

            UpdateData();

            HideUpdateTaskWindows();

            tBTitleTaskHomePage.Clear();
        }

    }
}
