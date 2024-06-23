namespace PresentationLayer
{
    partial class HomePage
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
            labelUsernameHomePage = new Label();
            dGVTasksHomePage = new DataGridView();
            btnNewTaskHomePage = new Button();
            labelNewTaskHomePage = new Label();
            labelTitleTaskHomePage = new Label();
            tBTitleTaskHomePage = new TextBox();
            labelEndDateTaskHomePage = new Label();
            dTPTaskHomePage = new DateTimePicker();
            btnSaveNewTaskHomePage = new Button();
            btnClearInfoTaskHomePage = new Button();
            btnUpdateTaskHomePage = new Button();
            labelUpdateTaskHomePage = new Label();
            btnSaveUpdateTaskHomePage = new Button();
            btnDeleteTaskHomePage = new Button();
            ((System.ComponentModel.ISupportInitialize)dGVTasksHomePage).BeginInit();
            SuspendLayout();
            // 
            // labelUsernameHomePage
            // 
            labelUsernameHomePage.AutoSize = true;
            labelUsernameHomePage.Font = new Font("Book Antiqua", 12F);
            labelUsernameHomePage.ForeColor = SystemColors.Highlight;
            labelUsernameHomePage.Location = new Point(10, 13);
            labelUsernameHomePage.Name = "labelUsernameHomePage";
            labelUsernameHomePage.Size = new Size(102, 24);
            labelUsernameHomePage.TabIndex = 1;
            labelUsernameHomePage.Text = "Username";
            // 
            // dGVTasksHomePage
            // 
            dGVTasksHomePage.BackgroundColor = Color.White;
            dGVTasksHomePage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVTasksHomePage.GridColor = Color.Black;
            dGVTasksHomePage.Location = new Point(423, 96);
            dGVTasksHomePage.Name = "dGVTasksHomePage";
            dGVTasksHomePage.RowHeadersWidth = 51;
            dGVTasksHomePage.Size = new Size(337, 247);
            dGVTasksHomePage.TabIndex = 2;
            // 
            // btnNewTaskHomePage
            // 
            btnNewTaskHomePage.BackColor = Color.RoyalBlue;
            btnNewTaskHomePage.FlatAppearance.BorderColor = Color.Black;
            btnNewTaskHomePage.FlatStyle = FlatStyle.Flat;
            btnNewTaskHomePage.ForeColor = Color.White;
            btnNewTaskHomePage.Location = new Point(51, 170);
            btnNewTaskHomePage.Name = "btnNewTaskHomePage";
            btnNewTaskHomePage.Size = new Size(117, 29);
            btnNewTaskHomePage.TabIndex = 3;
            btnNewTaskHomePage.Text = "New Task";
            btnNewTaskHomePage.UseVisualStyleBackColor = false;
            btnNewTaskHomePage.Click += btnNewTaskHomePage_Click;
            // 
            // labelNewTaskHomePage
            // 
            labelNewTaskHomePage.AutoSize = true;
            labelNewTaskHomePage.BackColor = Color.White;
            labelNewTaskHomePage.BorderStyle = BorderStyle.FixedSingle;
            labelNewTaskHomePage.FlatStyle = FlatStyle.Flat;
            labelNewTaskHomePage.Font = new Font("Book Antiqua", 15F);
            labelNewTaskHomePage.ForeColor = SystemColors.Highlight;
            labelNewTaskHomePage.Location = new Point(115, 37);
            labelNewTaskHomePage.Margin = new Padding(21, 20, 21, 20);
            labelNewTaskHomePage.Name = "labelNewTaskHomePage";
            labelNewTaskHomePage.Padding = new Padding(200, 40, 200, 329);
            labelNewTaskHomePage.RightToLeft = RightToLeft.Yes;
            labelNewTaskHomePage.Size = new Size(529, 402);
            labelNewTaskHomePage.TabIndex = 4;
            labelNewTaskHomePage.Text = "New Task";
            // 
            // labelTitleTaskHomePage
            // 
            labelTitleTaskHomePage.AutoSize = true;
            labelTitleTaskHomePage.BackColor = Color.White;
            labelTitleTaskHomePage.Font = new Font("Book Antiqua", 11F);
            labelTitleTaskHomePage.ForeColor = SystemColors.Highlight;
            labelTitleTaskHomePage.Location = new Point(265, 190);
            labelTitleTaskHomePage.Name = "labelTitleTaskHomePage";
            labelTitleTaskHomePage.Size = new Size(54, 23);
            labelTitleTaskHomePage.TabIndex = 5;
            labelTitleTaskHomePage.Text = "Title:";
            // 
            // tBTitleTaskHomePage
            // 
            tBTitleTaskHomePage.Location = new Point(325, 188);
            tBTitleTaskHomePage.Name = "tBTitleTaskHomePage";
            tBTitleTaskHomePage.Size = new Size(125, 27);
            tBTitleTaskHomePage.TabIndex = 6;
            // 
            // labelEndDateTaskHomePage
            // 
            labelEndDateTaskHomePage.AutoSize = true;
            labelEndDateTaskHomePage.BackColor = Color.White;
            labelEndDateTaskHomePage.Font = new Font("Book Antiqua", 11F);
            labelEndDateTaskHomePage.ForeColor = SystemColors.Highlight;
            labelEndDateTaskHomePage.Location = new Point(224, 248);
            labelEndDateTaskHomePage.Name = "labelEndDateTaskHomePage";
            labelEndDateTaskHomePage.Size = new Size(95, 23);
            labelEndDateTaskHomePage.TabIndex = 7;
            labelEndDateTaskHomePage.Text = "End Date:";
            labelEndDateTaskHomePage.Visible = false;
            // 
            // dTPTaskHomePage
            // 
            dTPTaskHomePage.Location = new Point(325, 244);
            dTPTaskHomePage.Name = "dTPTaskHomePage";
            dTPTaskHomePage.Size = new Size(199, 27);
            dTPTaskHomePage.TabIndex = 8;
            dTPTaskHomePage.Visible = false;
            // 
            // btnSaveNewTaskHomePage
            // 
            btnSaveNewTaskHomePage.BackColor = SystemColors.Highlight;
            btnSaveNewTaskHomePage.FlatAppearance.BorderColor = Color.Black;
            btnSaveNewTaskHomePage.FlatStyle = FlatStyle.Flat;
            btnSaveNewTaskHomePage.ForeColor = Color.White;
            btnSaveNewTaskHomePage.Location = new Point(456, 338);
            btnSaveNewTaskHomePage.Name = "btnSaveNewTaskHomePage";
            btnSaveNewTaskHomePage.Size = new Size(94, 29);
            btnSaveNewTaskHomePage.TabIndex = 9;
            btnSaveNewTaskHomePage.Text = "Save";
            btnSaveNewTaskHomePage.UseVisualStyleBackColor = false;
            btnSaveNewTaskHomePage.Click += btnSaveNewTaskHomePage_Click;
            // 
            // btnClearInfoTaskHomePage
            // 
            btnClearInfoTaskHomePage.BackColor = Color.RoyalBlue;
            btnClearInfoTaskHomePage.FlatAppearance.BorderColor = Color.Black;
            btnClearInfoTaskHomePage.FlatStyle = FlatStyle.Flat;
            btnClearInfoTaskHomePage.ForeColor = Color.White;
            btnClearInfoTaskHomePage.Location = new Point(200, 338);
            btnClearInfoTaskHomePage.Name = "btnClearInfoTaskHomePage";
            btnClearInfoTaskHomePage.Size = new Size(94, 29);
            btnClearInfoTaskHomePage.TabIndex = 10;
            btnClearInfoTaskHomePage.Text = "Clear";
            btnClearInfoTaskHomePage.UseVisualStyleBackColor = false;
            btnClearInfoTaskHomePage.Visible = false;
            btnClearInfoTaskHomePage.Click += btnClearInfoTaskHomePage_Click;
            // 
            // btnUpdateTaskHomePage
            // 
            btnUpdateTaskHomePage.BackColor = Color.RoyalBlue;
            btnUpdateTaskHomePage.FlatAppearance.BorderColor = Color.Black;
            btnUpdateTaskHomePage.FlatStyle = FlatStyle.Flat;
            btnUpdateTaskHomePage.ForeColor = Color.White;
            btnUpdateTaskHomePage.Location = new Point(224, 170);
            btnUpdateTaskHomePage.Name = "btnUpdateTaskHomePage";
            btnUpdateTaskHomePage.Size = new Size(129, 29);
            btnUpdateTaskHomePage.TabIndex = 11;
            btnUpdateTaskHomePage.Text = "Update Task";
            btnUpdateTaskHomePage.UseVisualStyleBackColor = false;
            btnUpdateTaskHomePage.Click += btnUpdateTaskHomePage_Click;
            // 
            // labelUpdateTaskHomePage
            // 
            labelUpdateTaskHomePage.AutoSize = true;
            labelUpdateTaskHomePage.BackColor = Color.White;
            labelUpdateTaskHomePage.BorderStyle = BorderStyle.FixedSingle;
            labelUpdateTaskHomePage.FlatStyle = FlatStyle.Flat;
            labelUpdateTaskHomePage.Font = new Font("Book Antiqua", 11F);
            labelUpdateTaskHomePage.ForeColor = SystemColors.Highlight;
            labelUpdateTaskHomePage.Location = new Point(115, 37);
            labelUpdateTaskHomePage.Margin = new Padding(21, 20, 21, 20);
            labelUpdateTaskHomePage.Name = "labelUpdateTaskHomePage";
            labelUpdateTaskHomePage.Padding = new Padding(200, 40, 200, 329);
            labelUpdateTaskHomePage.RightToLeft = RightToLeft.Yes;
            labelUpdateTaskHomePage.Size = new Size(521, 394);
            labelUpdateTaskHomePage.TabIndex = 12;
            labelUpdateTaskHomePage.Text = "Update Task";
            // 
            // btnSaveUpdateTaskHomePage
            // 
            btnSaveUpdateTaskHomePage.BackColor = Color.RoyalBlue;
            btnSaveUpdateTaskHomePage.FlatAppearance.BorderColor = Color.Black;
            btnSaveUpdateTaskHomePage.FlatStyle = FlatStyle.Flat;
            btnSaveUpdateTaskHomePage.ForeColor = Color.White;
            btnSaveUpdateTaskHomePage.Location = new Point(456, 338);
            btnSaveUpdateTaskHomePage.Name = "btnSaveUpdateTaskHomePage";
            btnSaveUpdateTaskHomePage.Size = new Size(94, 29);
            btnSaveUpdateTaskHomePage.TabIndex = 13;
            btnSaveUpdateTaskHomePage.Text = "Save";
            btnSaveUpdateTaskHomePage.UseVisualStyleBackColor = false;
            btnSaveUpdateTaskHomePage.Visible = false;
            btnSaveUpdateTaskHomePage.Click += btnSaveUpdateTaskHomePage_Click;
            // 
            // btnDeleteTaskHomePage
            // 
            btnDeleteTaskHomePage.BackColor = Color.RoyalBlue;
            btnDeleteTaskHomePage.FlatAppearance.BorderColor = Color.Black;
            btnDeleteTaskHomePage.FlatStyle = FlatStyle.Flat;
            btnDeleteTaskHomePage.ForeColor = Color.White;
            btnDeleteTaskHomePage.Location = new Point(152, 274);
            btnDeleteTaskHomePage.Name = "btnDeleteTaskHomePage";
            btnDeleteTaskHomePage.Size = new Size(94, 29);
            btnDeleteTaskHomePage.TabIndex = 16;
            btnDeleteTaskHomePage.Text = "Delete Task";
            btnDeleteTaskHomePage.UseVisualStyleBackColor = false;
            btnDeleteTaskHomePage.Click += btnDeleteTaskHomePage_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(btnSaveUpdateTaskHomePage);
            Controls.Add(btnClearInfoTaskHomePage);
            Controls.Add(btnSaveNewTaskHomePage);
            Controls.Add(labelEndDateTaskHomePage);
            Controls.Add(dTPTaskHomePage);
            Controls.Add(tBTitleTaskHomePage);
            Controls.Add(labelTitleTaskHomePage);
            Controls.Add(labelUsernameHomePage);
            Controls.Add(labelNewTaskHomePage);
            Controls.Add(labelUpdateTaskHomePage);
            Controls.Add(dGVTasksHomePage);
            Controls.Add(btnUpdateTaskHomePage);
            Controls.Add(btnDeleteTaskHomePage);
            Controls.Add(btnNewTaskHomePage);
            Name = "HomePage";
            Text = "Tasky";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dGVTasksHomePage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelUsernameHomePage;
        private DataGridView dGVTasksHomePage;
        private Button btnNewTaskHomePage;
        private Label labelNewTaskHomePage;
        private Label labelTitleTaskHomePage;
        private TextBox tBTitleTaskHomePage;
        private Label labelEndDateTaskHomePage;
        private DateTimePicker dTPTaskHomePage;
        private Button btnSaveNewTaskHomePage;
        private Button btnClearInfoTaskHomePage;
        private Button btnUpdateTaskHomePage;
        private Label labelUpdateTaskHomePage;
        private Button btnSaveUpdateTaskHomePage;
        private Button btnDeleteTaskHomePage;
    }
}