namespace LibraryManagementSystem
{
    partial class View_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Book));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtBookName = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtPDate = new TextBox();
            btnDelete = new Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            txtBName = new TextBox();
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
            label1.ForeColor = Color.Black;
            label1.Location = new Point(518, 25);
            label1.Name = "label1";
            label1.Size = new Size(177, 44);
            label1.TabIndex = 1;
            label1.Text = "View Book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(374, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(242, 131);
            label2.Name = "label2";
            label2.Size = new Size(127, 26);
            label2.TabIndex = 2;
            label2.Text = "Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookName.Location = new Point(374, 125);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(150, 32);
            txtBookName.TabIndex = 3;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Info;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(530, 123);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Wheat;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(940, 226);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(txtPDate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtPublication);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtBName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 431);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 244);
            panel2.TabIndex = 6;
            // 
            // txtPDate
            // 
            txtPDate.Location = new Point(636, 42);
            txtPDate.Name = "txtPDate";
            txtPDate.Size = new Size(180, 31);
            txtPDate.TabIndex = 16;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(606, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 36);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button4_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(716, 196);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 36);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(494, 196);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 36);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(636, 147);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 31);
            txtQuantity.TabIndex = 11;
            txtQuantity.TextChanged += textBox7_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(636, 89);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 31);
            txtPrice.TabIndex = 10;
            txtPrice.TextChanged += textBox6_TextChanged;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(219, 147);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(172, 31);
            txtPublication.TabIndex = 8;
            txtPublication.TextChanged += textBox4_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(219, 89);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(172, 31);
            txtAuthor.TabIndex = 7;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(219, 42);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(172, 31);
            txtBName.TabIndex = 6;
            txtBName.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(494, 156);
            label8.Name = "label8";
            label8.Size = new Size(136, 22);
            label8.TabIndex = 5;
            label8.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(523, 98);
            label7.Name = "label7";
            label7.Size = new Size(107, 22);
            label7.TabIndex = 4;
            label7.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(437, 51);
            label6.Name = "label6";
            label6.Size = new Size(193, 22);
            label6.TabIndex = 3;
            label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(93, 89);
            label5.Name = "label5";
            label5.Size = new Size(120, 22);
            label5.TabIndex = 2;
            label5.Text = "Book Author";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(53, 152);
            label4.Name = "label4";
            label4.Size = new Size(160, 22);
            label4.TabIndex = 1;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(101, 53);
            label3.Name = "label3";
            label3.Size = new Size(112, 22);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // View_Book
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(964, 713);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(txtBookName);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Name = "View_Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Book";
            Load += View_Book_Load;
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
        private Button btnRefresh;
        private TextBox txtBookName;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPrice;
        private TextBox txtPublication;
        private TextBox txtAuthor;
        private TextBox txtBName;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtQuantity;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtPDate;
    }
}