namespace LibraryManagementSystem
{
    partial class Add_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnSave = new Button();
            btnClose = new Button();
            button1 = new Button();
            txtID = new TextBox();
            txtDepartment = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtSemester = new TextBox();
            txtName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(294, 22);
            label1.Name = "label1";
            label1.Size = new Size(181, 39);
            label1.TabIndex = 1;
            label1.Text = "Add Student";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Info;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 339);
            panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Wheat;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(294, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button3_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Wheat;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(421, 284);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 16;
            btnClose.Text = "Exit";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(161, 284);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(294, 68);
            txtID.Name = "txtID";
            txtID.Size = new Size(208, 31);
            txtID.TabIndex = 14;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(294, 108);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(208, 31);
            txtDepartment.TabIndex = 13;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(294, 241);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(208, 31);
            txtContact.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(294, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 31);
            txtEmail.TabIndex = 11;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(294, 149);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(208, 31);
            txtSemester.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(294, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 31);
            txtName.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(67, 108);
            label8.Name = "label8";
            label8.Size = new Size(148, 29);
            label8.TabIndex = 8;
            label8.Text = "Department";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(90, 149);
            label7.Name = "label7";
            label7.Size = new Size(125, 29);
            label7.TabIndex = 7;
            label7.Text = "Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(37, 60);
            label6.Name = "label6";
            label6.Size = new Size(242, 29);
            label6.TabIndex = 6;
            label6.Text = " Student Enrollment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 243);
            label5.Name = "label5";
            label5.Size = new Size(197, 29);
            label5.TabIndex = 5;
            label5.Text = "Student Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 193);
            label4.Name = "label4";
            label4.Size = new Size(175, 29);
            label4.TabIndex = 4;
            label4.Text = "Student Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 28);
            label2.Name = "label2";
            label2.Size = new Size(178, 29);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // Add_Student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(554, 420);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Add_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Student";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtName;
        private Button btnSave;
        private Button btnClose;
        private Button button1;
        private TextBox txtID;
        private TextBox txtDepartment;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtSemester;
    }
}