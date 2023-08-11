namespace LibraryManagementSystem
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtEnroll = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            txtDepartment = new TextBox();
            txtSemester = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtBName = new ComboBox();
            txtDate = new DateTimePicker();
            label10 = new Label();
            panel3 = new Panel();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(432, 16);
            label1.Name = "label1";
            label1.Size = new Size(177, 44);
            label1.TabIndex = 1;
            label1.Text = "Issue Book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtEnroll);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 411);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Wheat;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(35, 302);
            button3.Name = "button3";
            button3.Size = new Size(107, 41);
            button3.TabIndex = 5;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Wheat;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(148, 302);
            button2.Name = "button2";
            button2.Size = new Size(107, 41);
            button2.TabIndex = 4;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(52, 231);
            button1.Name = "button1";
            button1.Size = new Size(193, 51);
            button1.TabIndex = 3;
            button1.Text = "Search Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtEnroll
            // 
            txtEnroll.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtEnroll.Location = new Point(32, 175);
            txtEnroll.Name = "txtEnroll";
            txtEnroll.Size = new Size(235, 30);
            txtEnroll.TabIndex = 2;
            txtEnroll.TextChanged += txtEnroll_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 126);
            label2.Name = "label2";
            label2.Size = new Size(235, 26);
            label2.TabIndex = 1;
            label2.Text = "Enter Enrollment No:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(85, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(164, 26);
            label3.TabIndex = 2;
            label3.Text = "Student Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 47);
            label4.Name = "label4";
            label4.Size = new Size(136, 26);
            label4.TabIndex = 3;
            label4.Text = "Dapartment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 83);
            label5.Name = "label5";
            label5.Size = new Size(203, 26);
            label5.TabIndex = 4;
            label5.Text = "Student Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 119);
            label6.Name = "label6";
            label6.Size = new Size(183, 26);
            label6.TabIndex = 5;
            label6.Text = "Student Contact";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 155);
            label7.Name = "label7";
            label7.Size = new Size(162, 26);
            label7.TabIndex = 6;
            label7.Text = "Student Email";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 194);
            label8.Name = "label8";
            label8.Size = new Size(148, 26);
            label8.TabIndex = 7;
            label8.Text = "Books Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 231);
            label9.Name = "label9";
            label9.Size = new Size(187, 26);
            label9.TabIndex = 8;
            label9.Text = "Book Issue Date";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(220, 7);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(235, 30);
            txtName.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDepartment.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtDepartment.Location = new Point(220, 43);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(235, 30);
            txtDepartment.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSemester.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtSemester.Location = new Point(220, 79);
            txtSemester.Name = "txtSemester";
            txtSemester.ReadOnly = true;
            txtSemester.Size = new Size(235, 30);
            txtSemester.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtContact.Location = new Point(220, 115);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(235, 30);
            txtContact.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(220, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(235, 30);
            txtEmail.TabIndex = 13;
            // 
            // txtBName
            // 
            txtBName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBName.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBName.FlatStyle = FlatStyle.Popup;
            txtBName.FormattingEnabled = true;
            txtBName.Location = new Point(220, 187);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(235, 34);
            txtBName.TabIndex = 3;
            // 
            // txtDate
            // 
            txtDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDate.Location = new Point(220, 226);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(235, 32);
            txtDate.TabIndex = 14;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(56, 372);
            label10.Name = "label10";
            label10.Size = new Size(399, 20);
            label10.TabIndex = 15;
            label10.Text = "Maximum 2 Books Can Be ISSUED To 1 Student";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Wheat;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtDate);
            panel3.Controls.Add(txtBName);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtSemester);
            panel3.Controls.Add(txtDepartment);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.Location = new Point(318, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 411);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.Wheat;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(279, 285);
            button4.Name = "button4";
            button4.Size = new Size(176, 41);
            button4.TabIndex = 16;
            button4.Text = "Issue Book";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 523);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBook";
            Load += IssueBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private TextBox txtEnroll;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtName;
        private TextBox txtDepartment;
        private TextBox txtSemester;
        private TextBox txtContact;
        private TextBox txtEmail;
        private ComboBox txtBName;
        private DateTimePicker txtDate;
        private Label label10;
        private Panel panel3;
        private Button button4;
    }
}