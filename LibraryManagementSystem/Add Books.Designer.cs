namespace LibraryManagementSystem
{
    partial class Add_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Books));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            txtBookQuan = new TextBox();
            txtBookPrice = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtBookPub = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 19);
            label1.Name = "label1";
            label1.Size = new Size(144, 39);
            label1.TabIndex = 1;
            label1.Text = "Add Book";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LavenderBlush;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtBookQuan);
            panel2.Controls.Add(txtBookPrice);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtBookPub);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 339);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.NavajoWhite;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(377, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.NavajoWhite;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(248, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBookQuan
            // 
            txtBookQuan.Location = new Point(248, 240);
            txtBookQuan.Name = "txtBookQuan";
            txtBookQuan.Size = new Size(241, 31);
            txtBookQuan.TabIndex = 11;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Location = new Point(248, 194);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(241, 31);
            txtBookPrice.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(288, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtBookPub
            // 
            txtBookPub.Location = new Point(248, 106);
            txtBookPub.Name = "txtBookPub";
            txtBookPub.Size = new Size(241, 31);
            txtBookPub.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(248, 70);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(241, 31);
            txtAuthor.TabIndex = 7;
            txtAuthor.TextChanged += textBox2_TextChanged;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(248, 29);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(241, 31);
            txtBookName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 108);
            label7.Name = "label7";
            label7.Size = new Size(210, 29);
            label7.TabIndex = 5;
            label7.Text = "Book Publication";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(32, 151);
            label6.Name = "label6";
            label6.Size = new Size(250, 29);
            label6.TabIndex = 4;
            label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(32, 194);
            label5.Name = "label5";
            label5.Size = new Size(141, 29);
            label5.TabIndex = 3;
            label5.Text = "Book Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(32, 242);
            label4.Name = "label4";
            label4.Size = new Size(175, 29);
            label4.TabIndex = 2;
            label4.Text = "Book Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(32, 72);
            label3.Name = "label3";
            label3.Size = new Size(155, 29);
            label3.TabIndex = 1;
            label3.Text = "Book Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(32, 31);
            label2.Name = "label2";
            label2.Size = new Size(149, 29);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // Add_Books
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 420);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Add_Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Books";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBookPub;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private TextBox txtBookQuan;
        private TextBox txtBookPrice;
        private Button btnCancel;
        private Button btnSave;
    }
}