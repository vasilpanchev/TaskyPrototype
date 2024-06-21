using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Identity.Client;

namespace PresentationLayer
{
    public partial class LogInPage : Form
    {
        TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();

        public LogInPage()
        {
            InitializeComponent();
        }

        private void btnLogInLogInPage_Click(object sender, EventArgs e)
        {
            if (tBUsernameLogInPage.Text != "" && tBPasswordLogInPage.Text != "")
            {
                string fromUserUsername = tBUsernameLogInPage.Text;
                string fromUserPassword = tBPasswordLogInPage.Text;

                User fromUserUser = new User(fromUserUsername, fromUserPassword)
                {
                    Username = fromUserUsername,
                    Password = fromUserPassword
                };

                UserContext fromContextUser = new UserContext(taskyPrototypeContext);

                User fromDataUser = fromContextUser.Read(fromUserUsername);

                try
                {
                    if (fromDataUser is not null && fromUserUser.Password.Equals(fromDataUser.Password))
                    {
                        this.Hide();
                        HomePage homePage = new HomePage(fromUserUser);
                        homePage.Show();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("There isn't an account with this information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is empty text boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegisterLogInPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
        }
    }
}
