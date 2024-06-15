namespace PresentationLayer
{
    partial class RegisterPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelRegisterRegisterPage = new Label();
            labelUsernameRegisterPage = new Label();
            labelPasswordRegisterPage = new Label();
            labelConPasswordRegisterPage = new Label();
            tBUsernameRegisterPage = new TextBox();
            tBPasswordRegisterPage = new TextBox();
            tBConPasswordRegisterPage = new TextBox();
            btnRegisterRegisterPage = new Button();
            btnLogInRegisterPage = new Button();
            labelQuestionRegisterPage = new Label();
            SuspendLayout();
            // 
            // labelRegisterRegisterPage
            // 
            labelRegisterRegisterPage.AutoSize = true;
            labelRegisterRegisterPage.Location = new Point(363, 93);
            labelRegisterRegisterPage.Name = "labelRegisterRegisterPage";
            labelRegisterRegisterPage.Size = new Size(63, 20);
            labelRegisterRegisterPage.TabIndex = 0;
            labelRegisterRegisterPage.Text = "Register";
            // 
            // labelUsernameRegisterPage
            // 
            labelUsernameRegisterPage.AutoSize = true;
            labelUsernameRegisterPage.Location = new Point(207, 174);
            labelUsernameRegisterPage.Name = "labelUsernameRegisterPage";
            labelUsernameRegisterPage.Size = new Size(78, 20);
            labelUsernameRegisterPage.TabIndex = 1;
            labelUsernameRegisterPage.Text = "Username:";
            // 
            // labelPasswordRegisterPage
            // 
            labelPasswordRegisterPage.AutoSize = true;
            labelPasswordRegisterPage.Location = new Point(212, 211);
            labelPasswordRegisterPage.Name = "labelPasswordRegisterPage";
            labelPasswordRegisterPage.Size = new Size(73, 20);
            labelPasswordRegisterPage.TabIndex = 2;
            labelPasswordRegisterPage.Text = "Password:";
            // 
            // labelConPasswordRegisterPage
            // 
            labelConPasswordRegisterPage.AutoSize = true;
            labelConPasswordRegisterPage.Location = new Point(153, 252);
            labelConPasswordRegisterPage.Name = "labelConPasswordRegisterPage";
            labelConPasswordRegisterPage.Size = new Size(132, 20);
            labelConPasswordRegisterPage.TabIndex = 3;
            labelConPasswordRegisterPage.Text = "Confirm password:";
            // 
            // tBUsernameRegisterPage
            // 
            tBUsernameRegisterPage.Location = new Point(291, 171);
            tBUsernameRegisterPage.Name = "tBUsernameRegisterPage";
            tBUsernameRegisterPage.Size = new Size(125, 27);
            tBUsernameRegisterPage.TabIndex = 4;
            // 
            // tBPasswordRegisterPage
            // 
            tBPasswordRegisterPage.Location = new Point(291, 211);
            tBPasswordRegisterPage.Name = "tBPasswordRegisterPage";
            tBPasswordRegisterPage.Size = new Size(125, 27);
            tBPasswordRegisterPage.TabIndex = 5;
            // 
            // tBConPasswordRegisterPage
            // 
            tBConPasswordRegisterPage.Location = new Point(291, 249);
            tBConPasswordRegisterPage.Name = "tBConPasswordRegisterPage";
            tBConPasswordRegisterPage.Size = new Size(125, 27);
            tBConPasswordRegisterPage.TabIndex = 6;
            // 
            // btnRegisterRegisterPage
            // 
            btnRegisterRegisterPage.Location = new Point(344, 303);
            btnRegisterRegisterPage.Name = "btnRegisterRegisterPage";
            btnRegisterRegisterPage.Size = new Size(94, 29);
            btnRegisterRegisterPage.TabIndex = 7;
            btnRegisterRegisterPage.Text = "Register";
            btnRegisterRegisterPage.UseVisualStyleBackColor = true;
            btnRegisterRegisterPage.Click += this.btnRegisterRegisterPage_Click;
            // 
            // btnLogInRegisterPage
            // 
            btnLogInRegisterPage.Location = new Point(427, 373);
            btnLogInRegisterPage.Name = "btnLogInRegisterPage";
            btnLogInRegisterPage.Size = new Size(94, 29);
            btnLogInRegisterPage.TabIndex = 8;
            btnLogInRegisterPage.Text = "LogIn";
            btnLogInRegisterPage.UseVisualStyleBackColor = true;
            btnLogInRegisterPage.Click += this.btnLogInRegisterPage_Click;
            // 
            // labelQuestionRegisterPage
            // 
            labelQuestionRegisterPage.AutoSize = true;
            labelQuestionRegisterPage.Location = new Point(246, 377);
            labelQuestionRegisterPage.Name = "labelQuestionRegisterPage";
            labelQuestionRegisterPage.Size = new Size(180, 20);
            labelQuestionRegisterPage.TabIndex = 9;
            labelQuestionRegisterPage.Text = "Already have an acoount?";
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelQuestionRegisterPage);
            Controls.Add(btnLogInRegisterPage);
            Controls.Add(btnRegisterRegisterPage);
            Controls.Add(tBConPasswordRegisterPage);
            Controls.Add(tBPasswordRegisterPage);
            Controls.Add(tBUsernameRegisterPage);
            Controls.Add(labelConPasswordRegisterPage);
            Controls.Add(labelPasswordRegisterPage);
            Controls.Add(labelUsernameRegisterPage);
            Controls.Add(labelRegisterRegisterPage);
            Name = "RegisterPage";
            Text = "Tasky";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegisterRegisterPage;
        private Label labelUsernameRegisterPage;
        private Label labelPasswordRegisterPage;
        private Label labelConPasswordRegisterPage;
        private TextBox tBUsernameRegisterPage;
        private TextBox tBPasswordRegisterPage;
        private TextBox tBConPasswordRegisterPage;
        private Button btnRegisterRegisterPage;
        private Button btnLogInRegisterPage;
        private Label labelQuestionRegisterPage;
    }
}