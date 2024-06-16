﻿namespace PresentationLayer
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
            labelHomeHomePage = new Label();
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
            labelTaskIdUpdateHomePage = new Label();
            tBTaskIdUpdateHomePage = new TextBox();
            btnDeleteTaskHomePage = new Button();
            labelDeleteTaskHomePage = new Label();
            btnClearDeleteHomePage = new Button();
            btnDeleteDeleteHomePage = new Button();
            labelTaskIdDeleteHomePage = new Label();
            tBTaskIdDeleteHomePage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dGVTasksHomePage).BeginInit();
            SuspendLayout();
            // 
            // labelHomeHomePage
            // 
            labelHomeHomePage.AutoSize = true;
            labelHomeHomePage.Location = new Point(304, 58);
            labelHomeHomePage.Name = "labelHomeHomePage";
            labelHomeHomePage.Size = new Size(40, 15);
            labelHomeHomePage.TabIndex = 0;
            labelHomeHomePage.Text = "Home";
            // 
            // labelUsernameHomePage
            // 
            labelUsernameHomePage.AutoSize = true;
            labelUsernameHomePage.Location = new Point(9, 10);
            labelUsernameHomePage.Name = "labelUsernameHomePage";
            labelUsernameHomePage.Size = new Size(0, 15);
            labelUsernameHomePage.TabIndex = 1;
            // 
            // dGVTasksHomePage
            // 
            dGVTasksHomePage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVTasksHomePage.Location = new Point(366, 99);
            dGVTasksHomePage.Margin = new Padding(3, 2, 3, 2);
            dGVTasksHomePage.Name = "dGVTasksHomePage";
            dGVTasksHomePage.RowHeadersWidth = 51;
            dGVTasksHomePage.Size = new Size(295, 185);
            dGVTasksHomePage.TabIndex = 2;
            // 
            // btnNewTaskHomePage
            // 
            btnNewTaskHomePage.Location = new Point(45, 162);
            btnNewTaskHomePage.Margin = new Padding(3, 2, 3, 2);
            btnNewTaskHomePage.Name = "btnNewTaskHomePage";
            btnNewTaskHomePage.Size = new Size(102, 22);
            btnNewTaskHomePage.TabIndex = 3;
            btnNewTaskHomePage.Text = "New Task";
            btnNewTaskHomePage.UseVisualStyleBackColor = true;
            btnNewTaskHomePage.Click += btnNewTaskHomePage_Click;
            // 
            // labelNewTaskHomePage
            // 
            labelNewTaskHomePage.AutoSize = true;
            labelNewTaskHomePage.BorderStyle = BorderStyle.FixedSingle;
            labelNewTaskHomePage.Location = new Point(129, 28);
            labelNewTaskHomePage.Margin = new Padding(18, 15, 18, 15);
            labelNewTaskHomePage.Name = "labelNewTaskHomePage";
            labelNewTaskHomePage.Padding = new Padding(175, 15, 175, 262);
            labelNewTaskHomePage.RightToLeft = RightToLeft.Yes;
            labelNewTaskHomePage.Size = new Size(408, 294);
            labelNewTaskHomePage.TabIndex = 4;
            labelNewTaskHomePage.Text = "New Task";
            // 
            // labelTitleTaskHomePage
            // 
            labelTitleTaskHomePage.AutoSize = true;
            labelTitleTaskHomePage.Location = new Point(179, 119);
            labelTitleTaskHomePage.Name = "labelTitleTaskHomePage";
            labelTitleTaskHomePage.Size = new Size(32, 15);
            labelTitleTaskHomePage.TabIndex = 5;
            labelTitleTaskHomePage.Text = "Title:";
            // 
            // tBTitleTaskHomePage
            // 
            tBTitleTaskHomePage.Location = new Point(220, 117);
            tBTitleTaskHomePage.Margin = new Padding(3, 2, 3, 2);
            tBTitleTaskHomePage.Name = "tBTitleTaskHomePage";
            tBTitleTaskHomePage.Size = new Size(110, 23);
            tBTitleTaskHomePage.TabIndex = 6;
            // 
            // labelEndDateTaskHomePage
            // 
            labelEndDateTaskHomePage.AutoSize = true;
            labelEndDateTaskHomePage.Location = new Point(151, 162);
            labelEndDateTaskHomePage.Name = "labelEndDateTaskHomePage";
            labelEndDateTaskHomePage.Size = new Size(57, 15);
            labelEndDateTaskHomePage.TabIndex = 7;
            labelEndDateTaskHomePage.Text = "End Date:";
            labelEndDateTaskHomePage.Visible = false;
            // 
            // dTPTaskHomePage
            // 
            dTPTaskHomePage.Location = new Point(220, 158);
            dTPTaskHomePage.Margin = new Padding(3, 2, 3, 2);
            dTPTaskHomePage.Name = "dTPTaskHomePage";
            dTPTaskHomePage.Size = new Size(175, 23);
            dTPTaskHomePage.TabIndex = 8;
            dTPTaskHomePage.Visible = false;
            // 
            // btnSaveNewTaskHomePage
            // 
            btnSaveNewTaskHomePage.Location = new Point(374, 243);
            btnSaveNewTaskHomePage.Margin = new Padding(3, 2, 3, 2);
            btnSaveNewTaskHomePage.Name = "btnSaveNewTaskHomePage";
            btnSaveNewTaskHomePage.Size = new Size(82, 22);
            btnSaveNewTaskHomePage.TabIndex = 9;
            btnSaveNewTaskHomePage.Text = "Save";
            btnSaveNewTaskHomePage.UseVisualStyleBackColor = true;
            btnSaveNewTaskHomePage.Click += btnSaveNewTaskHomePage_Click;
            // 
            // btnClearInfoTaskHomePage
            // 
            btnClearInfoTaskHomePage.Location = new Point(196, 243);
            btnClearInfoTaskHomePage.Margin = new Padding(3, 2, 3, 2);
            btnClearInfoTaskHomePage.Name = "btnClearInfoTaskHomePage";
            btnClearInfoTaskHomePage.Size = new Size(82, 22);
            btnClearInfoTaskHomePage.TabIndex = 10;
            btnClearInfoTaskHomePage.Text = "Clear";
            btnClearInfoTaskHomePage.UseVisualStyleBackColor = true;
            btnClearInfoTaskHomePage.Visible = false;
            btnClearInfoTaskHomePage.Click += btnClearInfoTaskHomePage_Click;
            // 
            // btnUpdateTaskHomePage
            // 
            btnUpdateTaskHomePage.Location = new Point(196, 162);
            btnUpdateTaskHomePage.Margin = new Padding(3, 2, 3, 2);
            btnUpdateTaskHomePage.Name = "btnUpdateTaskHomePage";
            btnUpdateTaskHomePage.Size = new Size(113, 22);
            btnUpdateTaskHomePage.TabIndex = 11;
            btnUpdateTaskHomePage.Text = "Update Task";
            btnUpdateTaskHomePage.UseVisualStyleBackColor = true;
            btnUpdateTaskHomePage.Click += btnUpdateTaskHomePage_Click;
            // 
            // labelUpdateTaskHomePage
            // 
            labelUpdateTaskHomePage.AutoSize = true;
            labelUpdateTaskHomePage.BorderStyle = BorderStyle.FixedSingle;
            labelUpdateTaskHomePage.Location = new Point(129, 28);
            labelUpdateTaskHomePage.Margin = new Padding(18, 15, 18, 15);
            labelUpdateTaskHomePage.Name = "labelUpdateTaskHomePage";
            labelUpdateTaskHomePage.Padding = new Padding(175, 15, 175, 262);
            labelUpdateTaskHomePage.RightToLeft = RightToLeft.Yes;
            labelUpdateTaskHomePage.Size = new Size(422, 294);
            labelUpdateTaskHomePage.TabIndex = 12;
            labelUpdateTaskHomePage.Text = "Update Task";
            // 
            // btnSaveUpdateTaskHomePage
            // 
            btnSaveUpdateTaskHomePage.Location = new Point(374, 243);
            btnSaveUpdateTaskHomePage.Margin = new Padding(3, 2, 3, 2);
            btnSaveUpdateTaskHomePage.Name = "btnSaveUpdateTaskHomePage";
            btnSaveUpdateTaskHomePage.Size = new Size(82, 22);
            btnSaveUpdateTaskHomePage.TabIndex = 13;
            btnSaveUpdateTaskHomePage.Text = "Save";
            btnSaveUpdateTaskHomePage.UseVisualStyleBackColor = true;
            btnSaveUpdateTaskHomePage.Visible = false;
            btnSaveUpdateTaskHomePage.Click += btnSaveUpdateTaskHomePage_Click;
            // 
            // labelTaskIdUpdateHomePage
            // 
            labelTaskIdUpdateHomePage.AutoSize = true;
            labelTaskIdUpdateHomePage.Location = new Point(166, 86);
            labelTaskIdUpdateHomePage.Name = "labelTaskIdUpdateHomePage";
            labelTaskIdUpdateHomePage.Size = new Size(45, 15);
            labelTaskIdUpdateHomePage.TabIndex = 14;
            labelTaskIdUpdateHomePage.Text = "Task Id:";
            // 
            // tBTaskIdUpdateHomePage
            // 
            tBTaskIdUpdateHomePage.Location = new Point(220, 84);
            tBTaskIdUpdateHomePage.Margin = new Padding(3, 2, 3, 2);
            tBTaskIdUpdateHomePage.Name = "tBTaskIdUpdateHomePage";
            tBTaskIdUpdateHomePage.Size = new Size(110, 23);
            tBTaskIdUpdateHomePage.TabIndex = 15;
            // 
            // btnDeleteTaskHomePage
            // 
            btnDeleteTaskHomePage.Location = new Point(133, 227);
            btnDeleteTaskHomePage.Margin = new Padding(3, 2, 3, 2);
            btnDeleteTaskHomePage.Name = "btnDeleteTaskHomePage";
            btnDeleteTaskHomePage.Size = new Size(82, 22);
            btnDeleteTaskHomePage.TabIndex = 16;
            btnDeleteTaskHomePage.Text = "Delete Task";
            btnDeleteTaskHomePage.UseVisualStyleBackColor = true;
            btnDeleteTaskHomePage.Click += btnDeleteTaskHomePage_Click;
            // 
            // labelDeleteTaskHomePage
            // 
            labelDeleteTaskHomePage.AutoSize = true;
            labelDeleteTaskHomePage.BorderStyle = BorderStyle.FixedSingle;
            labelDeleteTaskHomePage.Location = new Point(206, 38);
            labelDeleteTaskHomePage.Name = "labelDeleteTaskHomePage";
            labelDeleteTaskHomePage.Padding = new Padding(88, 8, 88, 112);
            labelDeleteTaskHomePage.Size = new Size(243, 137);
            labelDeleteTaskHomePage.TabIndex = 17;
            labelDeleteTaskHomePage.Text = "Delete Task";
            labelDeleteTaskHomePage.Visible = false;
            // 
            // btnClearDeleteHomePage
            // 
            btnClearDeleteHomePage.Location = new Point(220, 142);
            btnClearDeleteHomePage.Margin = new Padding(3, 2, 3, 2);
            btnClearDeleteHomePage.Name = "btnClearDeleteHomePage";
            btnClearDeleteHomePage.Size = new Size(82, 22);
            btnClearDeleteHomePage.TabIndex = 18;
            btnClearDeleteHomePage.Text = "Clear";
            btnClearDeleteHomePage.UseVisualStyleBackColor = true;
            btnClearDeleteHomePage.Visible = false;
            btnClearDeleteHomePage.Click += btnClearDeleteHomePage_Click;
            // 
            // btnDeleteDeleteHomePage
            // 
            btnDeleteDeleteHomePage.Location = new Point(355, 142);
            btnDeleteDeleteHomePage.Margin = new Padding(3, 2, 3, 2);
            btnDeleteDeleteHomePage.Name = "btnDeleteDeleteHomePage";
            btnDeleteDeleteHomePage.Size = new Size(82, 22);
            btnDeleteDeleteHomePage.TabIndex = 19;
            btnDeleteDeleteHomePage.Text = "Delete";
            btnDeleteDeleteHomePage.UseVisualStyleBackColor = true;
            btnDeleteDeleteHomePage.Visible = false;
            btnDeleteDeleteHomePage.Click += btnDeleteDeleteHomePage_Click;
            // 
            // labelTaskIdDeleteHomePage
            // 
            labelTaskIdDeleteHomePage.AutoSize = true;
            labelTaskIdDeleteHomePage.Location = new Point(229, 87);
            labelTaskIdDeleteHomePage.Name = "labelTaskIdDeleteHomePage";
            labelTaskIdDeleteHomePage.Size = new Size(45, 15);
            labelTaskIdDeleteHomePage.TabIndex = 20;
            labelTaskIdDeleteHomePage.Text = "Task Id:";
            labelTaskIdDeleteHomePage.Visible = false;
            // 
            // tBTaskIdDeleteHomePage
            // 
            tBTaskIdDeleteHomePage.Location = new Point(284, 85);
            tBTaskIdDeleteHomePage.Margin = new Padding(3, 2, 3, 2);
            tBTaskIdDeleteHomePage.Name = "tBTaskIdDeleteHomePage";
            tBTaskIdDeleteHomePage.Size = new Size(110, 23);
            tBTaskIdDeleteHomePage.TabIndex = 21;
            tBTaskIdDeleteHomePage.Visible = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tBTaskIdDeleteHomePage);
            Controls.Add(labelTaskIdDeleteHomePage);
            Controls.Add(btnDeleteDeleteHomePage);
            Controls.Add(btnClearDeleteHomePage);
            Controls.Add(labelDeleteTaskHomePage);
            Controls.Add(tBTaskIdUpdateHomePage);
            Controls.Add(labelTaskIdUpdateHomePage);
            Controls.Add(btnSaveUpdateTaskHomePage);
            Controls.Add(btnClearInfoTaskHomePage);
            Controls.Add(btnSaveNewTaskHomePage);
            Controls.Add(labelEndDateTaskHomePage);
            Controls.Add(dTPTaskHomePage);
            Controls.Add(tBTitleTaskHomePage);
            Controls.Add(labelTitleTaskHomePage);
            Controls.Add(labelUsernameHomePage);
            Controls.Add(labelHomeHomePage);
            Controls.Add(labelNewTaskHomePage);
            Controls.Add(labelUpdateTaskHomePage);
            Controls.Add(dGVTasksHomePage);
            Controls.Add(btnDeleteTaskHomePage);
            Controls.Add(btnNewTaskHomePage);
            Controls.Add(btnUpdateTaskHomePage);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePage";
            Text = "Tasky";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dGVTasksHomePage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHomeHomePage;
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
        private Label labelTaskIdUpdateHomePage;
        private TextBox tBTaskIdUpdateHomePage;
        private Button btnDeleteTaskHomePage;
        private Label labelDeleteTaskHomePage;
        private Button btnClearDeleteHomePage;
        private Button btnDeleteDeleteHomePage;
        private Label labelTaskIdDeleteHomePage;
        private TextBox tBTaskIdDeleteHomePage;
    }
}