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
            labelLogInLogInPage.Font = new Font("Book Antiqua", 22F, FontStyle.Bold);
            labelLogInLogInPage.ForeColor = SystemColors.HotTrack;
            labelLogInLogInPage.Location = new Point(325, 69);
            labelLogInLogInPage.Margin = new Padding(3);
            labelLogInLogInPage.Name = "labelLogInLogInPage";
            labelLogInLogInPage.Padding = new Padding(0, 0, 0, 3);
            labelLogInLogInPage.Size = new Size(121, 47);
            labelLogInLogInPage.TabIndex = 0;
            labelLogInLogInPage.Text = "LogIn";
            // 
            // labelUsernameLogInPage
            // 
            labelUsernameLogInPage.AutoSize = true;
            labelUsernameLogInPage.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsernameLogInPage.ForeColor = SystemColors.HotTrack;
            labelUsernameLogInPage.Location = new Point(223, 173);
            labelUsernameLogInPage.Name = "labelUsernameLogInPage";
            labelUsernameLogInPage.Size = new Size(134, 31);
            labelUsernameLogInPage.TabIndex = 1;
            labelUsernameLogInPage.Text = "Username:";
            // 
            // labelPasswordLogInPage
            // 
            labelPasswordLogInPage.AutoSize = true;
            labelPasswordLogInPage.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPasswordLogInPage.ForeColor = SystemColors.HotTrack;
            labelPasswordLogInPage.Location = new Point(227, 223);
            labelPasswordLogInPage.Name = "labelPasswordLogInPage";
            labelPasswordLogInPage.Size = new Size(130, 31);
            labelPasswordLogInPage.TabIndex = 2;
            labelPasswordLogInPage.Text = "Password:";
            // 
            // btnLogInLogInPage
            // 
            btnLogInLogInPage.BackColor = Color.RoyalBlue;
            btnLogInLogInPage.FlatAppearance.BorderColor = Color.Black;
            btnLogInLogInPage.FlatStyle = FlatStyle.Flat;
            btnLogInLogInPage.ForeColor = Color.White;
            btnLogInLogInPage.Location = new Point(339, 292);
            btnLogInLogInPage.Name = "btnLogInLogInPage";
            btnLogInLogInPage.Size = new Size(94, 29);
            btnLogInLogInPage.TabIndex = 3;
            btnLogInLogInPage.Text = "LogIn";
            btnLogInLogInPage.UseVisualStyleBackColor = false;
            btnLogInLogInPage.Click += btnLogInLogInPage_Click;
            // 
            // btnRegisterLogInPage
            // 
            btnRegisterLogInPage.BackColor = Color.RoyalBlue;
            btnRegisterLogInPage.FlatAppearance.BorderColor = Color.Black;
            btnRegisterLogInPage.FlatStyle = FlatStyle.Flat;
            btnRegisterLogInPage.ForeColor = Color.White;
            btnRegisterLogInPage.Location = new Point(439, 354);
            btnRegisterLogInPage.Name = "btnRegisterLogInPage";
            btnRegisterLogInPage.Size = new Size(94, 29);
            btnRegisterLogInPage.TabIndex = 4;
            btnRegisterLogInPage.Text = "Register";
            btnRegisterLogInPage.UseVisualStyleBackColor = false;
            btnRegisterLogInPage.Click += btnRegisterLogInPage_Click;
            // 
            // labelQuestionLogInPage
            // 
            labelQuestionLogInPage.AutoSize = true;
            labelQuestionLogInPage.Font = new Font("Book Antiqua", 11F);
            labelQuestionLogInPage.ForeColor = SystemColors.HotTrack;
            labelQuestionLogInPage.Location = new Point(254, 357);
            labelQuestionLogInPage.Name = "labelQuestionLogInPage";
            labelQuestionLogInPage.Size = new Size(179, 23);
            labelQuestionLogInPage.TabIndex = 5;
            labelQuestionLogInPage.Text = "Don't have account?";
            // 
            // tBUsernameLogInPage
            // 
            tBUsernameLogInPage.Location = new Point(363, 177);
            tBUsernameLogInPage.Name = "tBUsernameLogInPage";
            tBUsernameLogInPage.Size = new Size(125, 27);
            tBUsernameLogInPage.TabIndex = 6;
            // 
            // tBPasswordLogInPage
            // 
            tBPasswordLogInPage.Location = new Point(363, 227);
            tBPasswordLogInPage.Name = "tBPasswordLogInPage";
            tBPasswordLogInPage.Size = new Size(125, 27);
            tBPasswordLogInPage.TabIndex = 7;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tBPasswordLogInPage);
            Controls.Add(tBUsernameLogInPage);
            Controls.Add(labelQuestionLogInPage);
            Controls.Add(btnRegisterLogInPage);
            Controls.Add(btnLogInLogInPage);
            Controls.Add(labelPasswordLogInPage);
            Controls.Add(labelUsernameLogInPage);
            Controls.Add(labelLogInLogInPage);
            ForeColor = SystemColors.ControlText;
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