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
            labelHomeHomePage.Location = new Point(347, 78);
            labelHomeHomePage.Name = "labelHomeHomePage";
            labelHomeHomePage.Size = new Size(50, 20);
            labelHomeHomePage.TabIndex = 0;
            labelHomeHomePage.Text = "Home";
            // 
            // labelUsernameHomePage
            // 
            labelUsernameHomePage.AutoSize = true;
            labelUsernameHomePage.Location = new Point(10, 14);
            labelUsernameHomePage.Name = "labelUsernameHomePage";
            labelUsernameHomePage.Size = new Size(0, 20);
            labelUsernameHomePage.TabIndex = 1;
            // 
            // dGVTasksHomePage
            // 
            dGVTasksHomePage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVTasksHomePage.Location = new Point(418, 132);
            dGVTasksHomePage.Name = "dGVTasksHomePage";
            dGVTasksHomePage.RowHeadersWidth = 51;
            dGVTasksHomePage.Size = new Size(337, 247);
            dGVTasksHomePage.TabIndex = 2;
            // 
            // btnNewTaskHomePage
            // 
            btnNewTaskHomePage.Location = new Point(51, 216);
            btnNewTaskHomePage.Name = "btnNewTaskHomePage";
            btnNewTaskHomePage.Size = new Size(116, 29);
            btnNewTaskHomePage.TabIndex = 3;
            btnNewTaskHomePage.Text = "New Task";
            btnNewTaskHomePage.UseVisualStyleBackColor = true;
            btnNewTaskHomePage.Click += btnNewTaskHomePage_Click;
            // 
            // labelNewTaskHomePage
            // 
            labelNewTaskHomePage.AutoSize = true;
            labelNewTaskHomePage.BorderStyle = BorderStyle.FixedSingle;
            labelNewTaskHomePage.Location = new Point(147, 38);
            labelNewTaskHomePage.Margin = new Padding(20);
            labelNewTaskHomePage.Name = "labelNewTaskHomePage";
            labelNewTaskHomePage.Padding = new Padding(200, 20, 200, 350);
            labelNewTaskHomePage.RightToLeft = RightToLeft.Yes;
            labelNewTaskHomePage.Size = new Size(472, 392);
            labelNewTaskHomePage.TabIndex = 4;
            labelNewTaskHomePage.Text = "New Task";
            // 
            // labelTitleTaskHomePage
            // 
            labelTitleTaskHomePage.AutoSize = true;
            labelTitleTaskHomePage.Location = new Point(205, 159);
            labelTitleTaskHomePage.Name = "labelTitleTaskHomePage";
            labelTitleTaskHomePage.Size = new Size(41, 20);
            labelTitleTaskHomePage.TabIndex = 5;
            labelTitleTaskHomePage.Text = "Title:";
            // 
            // tBTitleTaskHomePage
            // 
            tBTitleTaskHomePage.Location = new Point(252, 156);
            tBTitleTaskHomePage.Name = "tBTitleTaskHomePage";
            tBTitleTaskHomePage.Size = new Size(125, 27);
            tBTitleTaskHomePage.TabIndex = 6;
            // 
            // labelEndDateTaskHomePage
            // 
            labelEndDateTaskHomePage.AutoSize = true;
            labelEndDateTaskHomePage.Location = new Point(173, 216);
            labelEndDateTaskHomePage.Name = "labelEndDateTaskHomePage";
            labelEndDateTaskHomePage.Size = new Size(73, 20);
            labelEndDateTaskHomePage.TabIndex = 7;
            labelEndDateTaskHomePage.Text = "End Date:";
            // 
            // dTPTaskHomePage
            // 
            dTPTaskHomePage.Location = new Point(252, 211);
            dTPTaskHomePage.Name = "dTPTaskHomePage";
            dTPTaskHomePage.Size = new Size(199, 27);
            dTPTaskHomePage.TabIndex = 8;
            // 
            // btnSaveNewTaskHomePage
            // 
            btnSaveNewTaskHomePage.Location = new Point(427, 324);
            btnSaveNewTaskHomePage.Name = "btnSaveNewTaskHomePage";
            btnSaveNewTaskHomePage.Size = new Size(94, 29);
            btnSaveNewTaskHomePage.TabIndex = 9;
            btnSaveNewTaskHomePage.Text = "Save";
            btnSaveNewTaskHomePage.UseVisualStyleBackColor = true;
            btnSaveNewTaskHomePage.Click += btnSaveNewTaskHomePage_Click;
            // 
            // btnClearInfoTaskHomePage
            // 
            btnClearInfoTaskHomePage.Location = new Point(224, 324);
            btnClearInfoTaskHomePage.Name = "btnClearInfoTaskHomePage";
            btnClearInfoTaskHomePage.Size = new Size(94, 29);
            btnClearInfoTaskHomePage.TabIndex = 10;
            btnClearInfoTaskHomePage.Text = "Clear";
            btnClearInfoTaskHomePage.UseVisualStyleBackColor = true;
            btnClearInfoTaskHomePage.Click += btnClearInfoTaskHomePage_Click;
            // 
            // btnUpdateTaskHomePage
            // 
            btnUpdateTaskHomePage.Location = new Point(224, 216);
            btnUpdateTaskHomePage.Name = "btnUpdateTaskHomePage";
            btnUpdateTaskHomePage.Size = new Size(129, 29);
            btnUpdateTaskHomePage.TabIndex = 11;
            btnUpdateTaskHomePage.Text = "Update Task";
            btnUpdateTaskHomePage.UseVisualStyleBackColor = true;
            btnUpdateTaskHomePage.Click += btnUpdateTaskHomePage_Click;
            // 
            // labelUpdateTaskHomePage
            // 
            labelUpdateTaskHomePage.AutoSize = true;
            labelUpdateTaskHomePage.BorderStyle = BorderStyle.FixedSingle;
            labelUpdateTaskHomePage.Location = new Point(147, 38);
            labelUpdateTaskHomePage.Margin = new Padding(20);
            labelUpdateTaskHomePage.Name = "labelUpdateTaskHomePage";
            labelUpdateTaskHomePage.Padding = new Padding(200, 20, 200, 350);
            labelUpdateTaskHomePage.RightToLeft = RightToLeft.Yes;
            labelUpdateTaskHomePage.Size = new Size(491, 392);
            labelUpdateTaskHomePage.TabIndex = 12;
            labelUpdateTaskHomePage.Text = "Update Task";
            // 
            // btnSaveUpdateTaskHomePage
            // 
            btnSaveUpdateTaskHomePage.Location = new Point(427, 324);
            btnSaveUpdateTaskHomePage.Name = "btnSaveUpdateTaskHomePage";
            btnSaveUpdateTaskHomePage.Size = new Size(94, 29);
            btnSaveUpdateTaskHomePage.TabIndex = 13;
            btnSaveUpdateTaskHomePage.Text = "Save";
            btnSaveUpdateTaskHomePage.UseVisualStyleBackColor = true;
            btnSaveUpdateTaskHomePage.Click += btnSaveUpdateTaskHomePage_Click;
            // 
            // labelTaskIdUpdateHomePage
            // 
            labelTaskIdUpdateHomePage.AutoSize = true;
            labelTaskIdUpdateHomePage.Location = new Point(190, 115);
            labelTaskIdUpdateHomePage.Name = "labelTaskIdUpdateHomePage";
            labelTaskIdUpdateHomePage.Size = new Size(56, 20);
            labelTaskIdUpdateHomePage.TabIndex = 14;
            labelTaskIdUpdateHomePage.Text = "Task Id:";
            // 
            // tBTaskIdUpdateHomePage
            // 
            tBTaskIdUpdateHomePage.Location = new Point(252, 112);
            tBTaskIdUpdateHomePage.Name = "tBTaskIdUpdateHomePage";
            tBTaskIdUpdateHomePage.Size = new Size(125, 27);
            tBTaskIdUpdateHomePage.TabIndex = 15;
            // 
            // btnDeleteTaskHomePage
            // 
            btnDeleteTaskHomePage.Location = new Point(152, 303);
            btnDeleteTaskHomePage.Name = "btnDeleteTaskHomePage";
            btnDeleteTaskHomePage.Size = new Size(94, 29);
            btnDeleteTaskHomePage.TabIndex = 16;
            btnDeleteTaskHomePage.Text = "Delete Task";
            btnDeleteTaskHomePage.UseVisualStyleBackColor = true;
            btnDeleteTaskHomePage.Click += btnDeleteTaskHomePage_Click;
            // 
            // labelDeleteTaskHomePage
            // 
            labelDeleteTaskHomePage.AutoSize = true;
            labelDeleteTaskHomePage.BorderStyle = BorderStyle.FixedSingle;
            labelDeleteTaskHomePage.Location = new Point(235, 51);
            labelDeleteTaskHomePage.Name = "labelDeleteTaskHomePage";
            labelDeleteTaskHomePage.Padding = new Padding(100, 10, 100, 150);
            labelDeleteTaskHomePage.Size = new Size(286, 182);
            labelDeleteTaskHomePage.TabIndex = 17;
            labelDeleteTaskHomePage.Text = "Delete Task";
            // 
            // btnClearDeleteHomePage
            // 
            btnClearDeleteHomePage.Location = new Point(252, 189);
            btnClearDeleteHomePage.Name = "btnClearDeleteHomePage";
            btnClearDeleteHomePage.Size = new Size(94, 29);
            btnClearDeleteHomePage.TabIndex = 18;
            btnClearDeleteHomePage.Text = "Clear";
            btnClearDeleteHomePage.UseVisualStyleBackColor = true;
            btnClearDeleteHomePage.Click += btnClearDeleteHomePage_Click;
            // 
            // btnDeleteDeleteHomePage
            // 
            btnDeleteDeleteHomePage.Location = new Point(406, 189);
            btnDeleteDeleteHomePage.Name = "btnDeleteDeleteHomePage";
            btnDeleteDeleteHomePage.Size = new Size(94, 29);
            btnDeleteDeleteHomePage.TabIndex = 19;
            btnDeleteDeleteHomePage.Text = "Delete";
            btnDeleteDeleteHomePage.UseVisualStyleBackColor = true;
            btnDeleteDeleteHomePage.Click += btnDeleteDeleteHomePage_Click;
            // 
            // labelTaskIdDeleteHomePage
            // 
            labelTaskIdDeleteHomePage.AutoSize = true;
            labelTaskIdDeleteHomePage.Location = new Point(262, 116);
            labelTaskIdDeleteHomePage.Name = "labelTaskIdDeleteHomePage";
            labelTaskIdDeleteHomePage.Size = new Size(56, 20);
            labelTaskIdDeleteHomePage.TabIndex = 20;
            labelTaskIdDeleteHomePage.Text = "Task Id:";
            // 
            // tBTaskIdDeleteHomePage
            // 
            tBTaskIdDeleteHomePage.Location = new Point(324, 113);
            tBTaskIdDeleteHomePage.Name = "tBTaskIdDeleteHomePage";
            tBTaskIdDeleteHomePage.Size = new Size(125, 27);
            tBTaskIdDeleteHomePage.TabIndex = 21;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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