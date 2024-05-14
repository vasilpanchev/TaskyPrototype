using BusinessLayer;
using DataLayer;
using Microsoft.Identity.Client;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
        string currentUsername = "";
        string currentPassword = "";
        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            User user = new User(username, password)
            {
                Username = username,
                Password = password
            };

            UserContext userContext = new UserContext(taskyPrototypeContext);

            userContext.Create(user);

            currentUsername = user.Username;
            currentPassword = user.Password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string taskTitle = textBox4.Text;

            UserTaskContext userTaskContext = new(taskyPrototypeContext);

            User currentUser = new User(currentUsername, currentPassword)
            {
                Username = currentUsername,
                Password = currentPassword
            };

            UserTask userTask = new UserTask(taskTitle, "", DateTime.Now, DateTime.Now, currentUsername)
            {
                Title = taskTitle,
                Username = currentUsername
            };

            userTaskContext.Create(currentUser, userTask);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox5.Text;
            string password = textBox3.Text;

            User user = new User(username, password)
            {
                Username = username,
                Password = password
            };

            UserContext userContext = new UserContext(taskyPrototypeContext);

            User userFromDb = userContext.Read(username);

            if (user.Password.Equals(userFromDb.Password) && userFromDb is not null)
            {
                currentUsername = username;
                currentPassword = password;
            }
        }
    }
}
