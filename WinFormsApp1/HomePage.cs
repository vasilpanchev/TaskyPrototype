using BusinessLayer;
using DataLayer;
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
        private List<UserTask> tasksOfCurrentUser;


        public HomePage(User user)
        {
            this.currentUser = user;
            tasksOfCurrentUser = new List<UserTask>();
            InitializeComponent();
        }

        private void btnNewTaskHomePage_Click(object sender, EventArgs e)
        {
            labelNewTaskHomePage.Show();
            labelTitleTaskHomePage.Show();
            labelEndDateTaskHomePage.Show();
            tBTitleTaskHomePage.Show();
            dTPTaskHomePage.Show();
            btnClearInfoTaskHomePage.Show();
            btnSaveNewTaskHomePage.Show();
        }

        private void btnUpdateTaskHomePage_Click(object sender, EventArgs e)
        {
            labelUpdateTaskHomePage.Show();
            labelTitleTaskHomePage.Show();
            labelEndDateTaskHomePage.Show();
            tBTitleTaskHomePage.Show();
            dTPTaskHomePage.Show();
            btnClearInfoTaskHomePage.Show();
            btnSaveUpdateTaskHomePage.Show();
        }

        private void btnClearInfoTaskHomePage_Click(object sender, EventArgs e)
        {
            tBTitleTaskHomePage.Text = "";
        }

        private void btnSaveUpdateTaskHomePage_Click(object sender, EventArgs e)
        {
            string taskTitle = tBTitleTaskHomePage.Text;

            UserTaskContext userTaskContext = new(taskyPrototypeContext);

            UserTask userTask = new UserTask(taskTitle, "", dTPTaskHomePage.Value, DateTime.Now, currentUser.Username)
            {
                Title = taskTitle,
                StartDate = dTPTaskHomePage.Value,
                Username = currentUser.Username
            };

            userTaskContext.Update(userTask);
        }

        private void btnSaveNewTaskHomePage_Click(object sender, EventArgs e)
        {
            string taskTitle = tBTitleTaskHomePage.Text;

            UserTaskContext userTaskContext = new(taskyPrototypeContext);

            UserTask userTask = new UserTask(taskTitle, "", DateTime.Now, DateTime.Now, currentUser.Username)
            {
                Title = taskTitle,
                StartDate = dTPTaskHomePage.Value,
                Username = currentUser.Username
            };

            userTaskContext.Create(currentUser, userTask);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            labelUsernameHomePage.Text = currentUser.Username;
            UserTaskContext fromContextUserTask = new UserTaskContext(taskyPrototypeContext);
            List<UserTask> tasks = fromContextUserTask.ReadAll(0);

            foreach (UserTask task in tasks)
            {
                if (task.Username == currentUser.Username)
                {
                    tasksOfCurrentUser.Add(task);
                }
            }
            dGVTasksHomePage.DataSource = tasksOfCurrentUser;
        }
    }
}
