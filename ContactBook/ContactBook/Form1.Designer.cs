namespace ContactBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(676, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "new";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(513, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 15);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 2;
            label1.Text = "First Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(513, 31);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(676, 62);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "load";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Location = new Point(0, 62);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 5;
            label2.Text = "Last Name:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(513, 31);
            textBox3.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(676, 111);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.Location = new Point(0, 111);
            label3.Name = "label3";
            label3.Size = new Size(116, 31);
            label3.TabIndex = 8;
            label3.Text = "Phone:";
            // 
            // label4
            // 
            label4.Location = new Point(0, 161);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(122, 161);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(513, 31);
            textBox4.TabIndex = 10;
            // 
            // button4
            // 
            button4.Location = new Point(676, 161);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 11;
            button4.Text = "delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(776, 225);
            dataGridView1.TabIndex = 12;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button button2;
        private Label label2;
        private TextBox textBox3;
        private Button button3;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Button button4;
        private DataGridView dataGridView1;
    }
}