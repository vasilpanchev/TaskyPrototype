namespace PresentationLayer
{
    partial class LogInPage
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
            labelLogInLogInPage = new Label();
            labelUsernameLogInPage = new Label();
            labelPasswordLogInPage = new Label();
            btnLogInLogInPage = new Button();
            btnRegisterLogInPage = new Button();
            labelQuestionLogInPage = new Label();
            tBUsernameLogInPage = new TextBox();
            tBPasswordLogInPage = new TextBox();
            SuspendLayout();
            // 
            // labelLogInLogInPage
            // 
            labelLogInLogInPage.AutoSize = true;
            labelLogInLogInPage.Location = new Point(356, 106);
            labelLogInLogInPage.Name = "labelLogInLogInPage";
            labelLogInLogInPage.Size = new Size(46, 20);
            labelLogInLogInPage.TabIndex = 0;
            labelLogInLogInPage.Text = "LogIn";
            // 
            // labelUsernameLogInPage
            // 
            labelUsernameLogInPage.AutoSize = true;
            labelUsernameLogInPage.Location = new Point(222, 191);
            labelUsernameLogInPage.Name = "labelUsernameLogInPage";
            labelUsernameLogInPage.Size = new Size(78, 20);
            labelUsernameLogInPage.TabIndex = 1;
            labelUsernameLogInPage.Text = "Username:";
            // 
            // labelPasswordLogInPage
            // 
            labelPasswordLogInPage.AutoSize = true;
            labelPasswordLogInPage.Location = new Point(227, 237);
            labelPasswordLogInPage.Name = "labelPasswordLogInPage";
            labelPasswordLogInPage.Size = new Size(73, 20);
            labelPasswordLogInPage.TabIndex = 2;
            labelPasswordLogInPage.Text = "Password:";
            // 
            // btnLogInLogInPage
            // 
            btnLogInLogInPage.Location = new Point(353, 290);
            btnLogInLogInPage.Name = "btnLogInLogInPage";
            btnLogInLogInPage.Size = new Size(94, 29);
            btnLogInLogInPage.TabIndex = 3;
            btnLogInLogInPage.Text = "LogIn";
            btnLogInLogInPage.UseVisualStyleBackColor = true;
            btnLogInLogInPage.Click += btnLogInLogInPage_Click;
            // 
            // btnRegisterLogInPage
            // 
            btnRegisterLogInPage.Location = new Point(418, 354);
            btnRegisterLogInPage.Name = "btnRegisterLogInPage";
            btnRegisterLogInPage.Size = new Size(94, 29);
            btnRegisterLogInPage.TabIndex = 4;
            btnRegisterLogInPage.Text = "Register";
            btnRegisterLogInPage.UseVisualStyleBackColor = true;
            btnRegisterLogInPage.Click += btnRegisterLogInPage_Click;
            // 
            // labelQuestionLogInPage
            // 
            labelQuestionLogInPage.AutoSize = true;
            labelQuestionLogInPage.Location = new Point(269, 358);
            labelQuestionLogInPage.Name = "labelQuestionLogInPage";
            labelQuestionLogInPage.Size = new Size(143, 20);
            labelQuestionLogInPage.TabIndex = 5;
            labelQuestionLogInPage.Text = "Don't have account?";
            // 
            // tBUsernameLogInPage
            // 
            tBUsernameLogInPage.Location = new Point(306, 188);
            tBUsernameLogInPage.Name = "tBUsernameLogInPage";
            tBUsernameLogInPage.Size = new Size(125, 27);
            tBUsernameLogInPage.TabIndex = 6;
            // 
            // tBPasswordLogInPage
            // 
            tBPasswordLogInPage.Location = new Point(306, 234);
            tBPasswordLogInPage.Name = "tBPasswordLogInPage";
            tBPasswordLogInPage.Size = new Size(125, 27);
            tBPasswordLogInPage.TabIndex = 7;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tBPasswordLogInPage);
            Controls.Add(tBUsernameLogInPage);
            Controls.Add(labelQuestionLogInPage);
            Controls.Add(btnRegisterLogInPage);
            Controls.Add(btnLogInLogInPage);
            Controls.Add(labelPasswordLogInPage);
            Controls.Add(labelUsernameLogInPage);
            Controls.Add(labelLogInLogInPage);
            Name = "LogInPage";
            Text = "Tasky";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogInLogInPage;
        private Label labelUsernameLogInPage;
        private Label labelPasswordLogInPage;
        private Button btnLogInLogInPage;
        private Button btnRegisterLogInPage;
        private Label labelQuestionLogInPage;
        private TextBox tBUsernameLogInPage;
        private TextBox tBPasswordLogInPage;
    }
}