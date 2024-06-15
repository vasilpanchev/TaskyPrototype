using DataLayer;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class RegisterPage : Form
    {
        TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnRegisterRegisterPage_Click(object sender, EventArgs e)
        {
            if (tBUsernameRegisterPage.Text != "" && tBPasswordRegisterPage.Text != "" && tBConPasswordRegisterPage.Text != "")
            {
                string fromUserUsername = tBUsernameRegisterPage.Text;
                string fromUserPassword = tBPasswordRegisterPage.Text;
                string fromUserConPassword = tBConPasswordRegisterPage.Text;

                User fromUserUser = new User(fromUserUsername, fromUserPassword)
                {
                    Username = fromUserUsername,
                    Password = fromUserPassword
                };

                UserContext fromContextUser = new UserContext(taskyPrototypeContext);

                User fromDataUser = fromContextUser.Read(fromUserUsername);

                if(fromDataUser is not null)
                {
                    MessageBox.Show("There is already an account with this username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    fromContextUser.Create(fromUserUser);

                    MessageBox.Show("The user was created succesfuly!", "Tasky", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    LogInPage logInPage = new LogInPage();
                    logInPage.Show();
                }
            }
            else
            {
                MessageBox.Show("There is empty text boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogInRegisterPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInPage logInPage = new LogInPage();
            logInPage.Show();
        }
    }
}
