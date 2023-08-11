namespace LibraryManagementSystem
{
    partial class Return_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return_Book));
            panel1 = new Panel();
            btnRefresh = new Button();
            btnExit = new Button();
            btnSearch = new Button();
            txtEnterEnroll = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            dateTimePicker = new DateTimePicker();
            txtBIDate = new TextBox();
            txtBooksName = new TextBox();
            btnReturn = new Button();
            label1 = new Label();
            btnCancel = new Button();
            label9 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtEnterEnroll);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 372);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Wheat;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(29, 303);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 41);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Wheat;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(142, 303);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 41);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Wheat;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(46, 232);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(193, 51);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEnterEnroll
            // 
            txtEnterEnroll.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtEnterEnroll.Location = new Point(26, 176);
            txtEnterEnroll.Name = "txtEnterEnroll";
            txtEnterEnroll.Size = new Size(235, 30);
            txtEnterEnroll.TabIndex = 8;
            txtEnterEnroll.TextChanged += txtEnterEnroll_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 127);
            label2.Name = "label2";
            label2.Size = new Size(235, 26);
            label2.TabIndex = 7;
            label2.Text = "Enter Enrollment No:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(79, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Wheat;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(318, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(575, 372);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker);
            panel2.Controls.Add(txtBIDate);
            panel2.Controls.Add(txtBooksName);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(318, 390);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 192);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(223, 140);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(190, 31);
            dateTimePicker.TabIndex = 16;
            dateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtBIDate
            // 
            txtBIDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBIDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtBIDate.Location = new Point(209, 76);
            txtBIDate.Name = "txtBIDate";
            txtBIDate.ReadOnly = true;
            txtBIDate.Size = new Size(204, 30);
            txtBIDate.TabIndex = 15;
            // 
            // txtBooksName
            // 
            txtBooksName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBooksName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtBooksName.Location = new Point(209, 22);
            txtBooksName.Name = "txtBooksName";
            txtBooksName.ReadOnly = true;
            txtBooksName.Size = new Size(235, 30);
            txtBooksName.TabIndex = 14;
            txtBooksName.TextChanged += txtBooksName_TextChanged;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Wheat;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(465, 76);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 41);
            btnReturn.TabIndex = 11;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 145);
            label1.Name = "label1";
            label1.Size = new Size(201, 26);
            label1.TabIndex = 11;
            label1.Text = "Book Return Date";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Wheat;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(465, 130);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 41);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(8, 83);
            label9.Name = "label9";
            label9.Size = new Size(187, 26);
            label9.TabIndex = 10;
            label9.Text = "Book Issue Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(47, 26);
            label8.Name = "label8";
            label8.Size = new Size(148, 26);
            label8.TabIndex = 9;
            label8.Text = "Books Name";
            // 
            // Return_Book
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Ivory;
            ClientSize = new Size(905, 582);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Return_Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return_Book";
            Load += Return_Book_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRefresh;
        private Button btnExit;
        private Button btnSearch;
        private TextBox txtEnterEnroll;
        private Label label2;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private Label label9;
        private Label label8;
        private Button btnReturn;
        private Button btnCancel;
        private DateTimePicker dateTimePicker;
        private TextBox txtBIDate;
        private TextBox txtBooksName;
    }
}