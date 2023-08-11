namespace LibraryManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            viewBookToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentInfoToolStripMenuItem = new ToolStripMenuItem();
            returnBookToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            bookDetailsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBookToolStripMenuItem, viewBookToolStripMenuItem });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(101, 29);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBookToolStripMenuItem
            // 
            addNewBookToolStripMenuItem.BackColor = SystemColors.Info;
            addNewBookToolStripMenuItem.Image = (Image)resources.GetObject("addNewBookToolStripMenuItem.Image");
            addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            addNewBookToolStripMenuItem.Size = new Size(234, 34);
            addNewBookToolStripMenuItem.Text = "Add New Book";
            addNewBookToolStripMenuItem.Click += addNewBookToolStripMenuItem_Click;
            // 
            // viewBookToolStripMenuItem
            // 
            viewBookToolStripMenuItem.BackColor = SystemColors.Info;
            viewBookToolStripMenuItem.Image = (Image)resources.GetObject("viewBookToolStripMenuItem.Image");
            viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            viewBookToolStripMenuItem.Size = new Size(234, 34);
            viewBookToolStripMenuItem.Text = "View Book";
            viewBookToolStripMenuItem.Click += viewBookToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.BackColor = SystemColors.Info;
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentInfoToolStripMenuItem });
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(113, 29);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.BackColor = SystemColors.Info;
            addStudentToolStripMenuItem.Image = (Image)resources.GetObject("addStudentToolStripMenuItem.Image");
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(254, 34);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentInfoToolStripMenuItem
            // 
            viewStudentInfoToolStripMenuItem.BackColor = SystemColors.Info;
            viewStudentInfoToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentInfoToolStripMenuItem.Image");
            viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
            viewStudentInfoToolStripMenuItem.Size = new Size(254, 34);
            viewStudentInfoToolStripMenuItem.Text = "View Student Info";
            viewStudentInfoToolStripMenuItem.Click += viewStudentInfoToolStripMenuItem_Click;
            // 
            // returnBookToolStripMenuItem
            // 
            returnBookToolStripMenuItem.Image = (Image)resources.GetObject("returnBookToolStripMenuItem.Image");
            returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            returnBookToolStripMenuItem.Size = new Size(149, 29);
            returnBookToolStripMenuItem.Text = "Return Book";
            returnBookToolStripMenuItem.Click += returnBookToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(79, 29);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(138, 29);
            toolStripMenuItem1.Text = "Issue Book";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Info;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, toolStripMenuItem1, returnBookToolStripMenuItem, bookDetailsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(752, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // bookDetailsToolStripMenuItem
            // 
            bookDetailsToolStripMenuItem.Image = (Image)resources.GetObject("bookDetailsToolStripMenuItem.Image");
            bookDetailsToolStripMenuItem.Name = "bookDetailsToolStripMenuItem";
            bookDetailsToolStripMenuItem.Size = new Size(159, 29);
            bookDetailsToolStripMenuItem.Text = "Books Details";
            bookDetailsToolStripMenuItem.Click += bookDetailsToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 355);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem viewBookToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentInfoToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bookDetailsToolStripMenuItem;
    }
}