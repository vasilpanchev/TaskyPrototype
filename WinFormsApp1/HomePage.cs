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
            labelTaskIdUpdateHomePage.Show();
            labelUpdateTaskHomePage.Show();
            labelTitleTaskHomePage.Show();
            labelEndDateTaskHomePage.Show();
            tBTitleTaskHomePage.Show();
            tBTaskIdUpdateHomePage.Show();
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
            int updateTaskId = Convert.ToInt32(tBTaskIdUpdateHomePage.Text);

            UserTaskContext userTaskContext = new(taskyPrototypeContext);

            UserTask userTask = new UserTask(updateTaskId, taskTitle, "", DateTime.Now, DateTime.NowdTPTaskHomePage.Value, currentUser.Username)
            {
                TaskId = updateTaskId,
                Title = taskTitle,
                EndDate = dTPTaskHomePage.Value,
                Username = currentUser.Username
            };

            if (userTaskContext.Update(userTask) == false)
            {
                MessageBox.Show("There is not a task with this Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelTaskIdUpdateHomePage.Hide();
            labelUpdateTaskHomePage.Hide();
            labelTitleTaskHomePage.Hide();
            labelEndDateTaskHomePage.Hide();
            tBTitleTaskHomePage.Hide();
            tBTaskIdUpdateHomePage.Hide();
            dTPTaskHomePage.Hide();
            btnClearInfoTaskHomePage.Hide();
            btnSaveUpdateTaskHomePage.Hide();
        }

        private void btnSaveNewTaskHomePage_Click(object sender, EventArgs e)
        {
            string taskTitle = tBTitleTaskHomePage.Text;

            UserTaskContext userTaskContext = new(taskyPrototypeContext);

            UserTask userTask = new UserTask(taskTitle, "", DateTime.Now, dTPTaskHomePage.Value, currentUser.Username)
            {
                Title = taskTitle,
                EndDate = dTPTaskHomePage.Value,
                Username = currentUser.Username
            };

            userTaskContext.Create(currentUser, userTask);

            labelNewTaskHomePage.Hide();
            labelTitleTaskHomePage.Hide();
            labelEndDateTaskHomePage.Hide();
            tBTitleTaskHomePage.Hide();
            dTPTaskHomePage.Hide();
            btnClearInfoTaskHomePage.Hide();
            btnSaveNewTaskHomePage.Hide();
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

        private void btnDeleteTaskHomePage_Click(object sender, EventArgs e)
        {
            labelDeleteTaskHomePage.Show();
            labelTaskIdDeleteHomePage.Show();
            tBTaskIdDeleteHomePage.Show();
            btnClearDeleteHomePage.Hide();
            btnDeleteDeleteHomePage.Hide();

        }

        private void btnClearDeleteHomePage_Click(object sender, EventArgs e)
        {
            tBTaskIdDeleteHomePage.Text = "";
        }

        private void btnDeleteDeleteHomePage_Click(object sender, EventArgs e)
        {
            int taskId = Convert.ToInt32(tBTaskIdDeleteHomePage.Text);

            UserTaskContext userTaskContext = new(taskyPrototypeContext);

            userTaskContext.Delete(taskId);
        }
    }
}
