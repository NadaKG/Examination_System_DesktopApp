namespace Examanation_System.Resources
{
    partial class TeacherForm
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
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 28);
            comboBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Highlight;
            pictureBox1.BackgroundImage = Properties.Resources.top_view_office_supplies_with_copy_space;
            pictureBox1.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 6;
            label1.Text = "Subject:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(149, 88);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(376, 99);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 303);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(376, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(376, 27);
            textBox3.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(417, 378);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(298, 378);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 13;
            label2.Text = "Question";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 14;
            label3.Text = "Answer 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label4.Location = new Point(12, 255);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 15;
            label4.Text = "Answer 2";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label5.Location = new Point(12, 302);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 16;
            label5.Text = "Answer 3";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.top_view_office_supplies_with_copy_space;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DarkOrange;
            button3.Location = new Point(518, 6);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(149, 357);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 27);
            textBox4.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label6.Location = new Point(12, 359);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 19;
            label6.Text = "Right Answer";
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
        private TextBox textBox4;
        private Label label6;
    }
}