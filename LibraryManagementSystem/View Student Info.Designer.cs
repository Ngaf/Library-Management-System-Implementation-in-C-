namespace LibraryManagementSystem
{
    partial class View_Student_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Student_Info));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtSearchEnroll = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtDelete = new Button();
            txtCancel = new Button();
            txtUpdate = new Button();
            txtSName = new TextBox();
            txtEnroll = new TextBox();
            txtDepartment = new TextBox();
            txtSem = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 91);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(436, 29);
            label1.Name = "label1";
            label1.Size = new Size(403, 44);
            label1.TabIndex = 1;
            label1.Text = "View Student Information";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InfoText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(297, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(265, 117);
            label2.Name = "label2";
            label2.Size = new Size(164, 26);
            label2.TabIndex = 2;
            label2.Text = "Enrollment No";
            // 
            // txtSearchEnroll
            // 
            txtSearchEnroll.Location = new Point(435, 109);
            txtSearchEnroll.Name = "txtSearchEnroll";
            txtSearchEnroll.Size = new Size(150, 31);
            txtSearchEnroll.TabIndex = 3;
            txtSearchEnroll.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(604, 109);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Wheat;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(940, 226);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(txtDelete);
            panel2.Controls.Add(txtCancel);
            panel2.Controls.Add(txtUpdate);
            panel2.Controls.Add(txtSName);
            panel2.Controls.Add(txtEnroll);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtSem);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 244);
            panel2.TabIndex = 5;
            // 
            // txtDelete
            // 
            txtDelete.FlatStyle = FlatStyle.Popup;
            txtDelete.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDelete.Location = new Point(609, 193);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(112, 34);
            txtDelete.TabIndex = 14;
            txtDelete.Text = "Delete";
            txtDelete.UseVisualStyleBackColor = true;
            txtDelete.Click += txtDelete_Click;
            // 
            // txtCancel
            // 
            txtCancel.FlatStyle = FlatStyle.Popup;
            txtCancel.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCancel.Location = new Point(727, 193);
            txtCancel.Name = "txtCancel";
            txtCancel.Size = new Size(112, 34);
            txtCancel.TabIndex = 13;
            txtCancel.Text = "Cancel";
            txtCancel.UseVisualStyleBackColor = true;
            txtCancel.Click += txtCancel_Click;
            // 
            // txtUpdate
            // 
            txtUpdate.FlatStyle = FlatStyle.Popup;
            txtUpdate.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUpdate.Location = new Point(491, 193);
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(112, 34);
            txtUpdate.TabIndex = 12;
            txtUpdate.Text = "Update";
            txtUpdate.UseVisualStyleBackColor = true;
            txtUpdate.Click += txtUpdate_Click;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(224, 30);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(193, 31);
            txtSName.TabIndex = 11;
            // 
            // txtEnroll
            // 
            txtEnroll.Location = new Point(224, 92);
            txtEnroll.Name = "txtEnroll";
            txtEnroll.Size = new Size(193, 31);
            txtEnroll.TabIndex = 10;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(224, 145);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(193, 31);
            txtDepartment.TabIndex = 9;
            // 
            // txtSem
            // 
            txtSem.Location = new Point(643, 30);
            txtSem.Name = "txtSem";
            txtSem.Size = new Size(196, 31);
            txtSem.TabIndex = 8;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(643, 92);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(196, 31);
            txtContact.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(643, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 31);
            txtEmail.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(503, 154);
            label8.Name = "label8";
            label8.Size = new Size(134, 22);
            label8.TabIndex = 5;
            label8.Text = "Student Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(483, 101);
            label7.Name = "label7";
            label7.Size = new Size(154, 22);
            label7.TabIndex = 4;
            label7.Text = "Student Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(468, 39);
            label6.Name = "label6";
            label6.Size = new Size(169, 22);
            label6.TabIndex = 3;
            label6.Text = "Student Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(105, 154);
            label5.Name = "label5";
            label5.Size = new Size(113, 22);
            label5.TabIndex = 2;
            label5.Text = "Department";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(82, 101);
            label4.Name = "label4";
            label4.Size = new Size(136, 22);
            label4.TabIndex = 1;
            label4.Text = "Enrollment No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(82, 39);
            label3.Name = "label3";
            label3.Size = new Size(136, 22);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // View_Student_Info
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(965, 633);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtSearchEnroll);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "View_Student_Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Student_Info";
            Load += View_Student_Info_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtSearchEnroll;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtSName;
        private TextBox txtEnroll;
        private TextBox txtDepartment;
        private TextBox txtSem;
        private TextBox txtContact;
        private TextBox txtEmail;
        private Button txtDelete;
        private Button txtCancel;
        private Button txtUpdate;
    }
}