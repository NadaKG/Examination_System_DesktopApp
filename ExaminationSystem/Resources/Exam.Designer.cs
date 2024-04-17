namespace Examanation_System.Resources
{
    partial class Exam
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
            label1 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label1.Location = new Point(41, 103);
            label1.Name = "label1";
            label1.Size = new Size(515, 28);
            label1.TabIndex = 0;
            label1.Text = "Question Body : asmdm awdasd rawfdmad moaitr asdfrt ?";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label3.Location = new Point(41, 31);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 2;
            label3.Text = "Question No of No";
            label3.Click += label3_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackgroundImage = Properties.Resources.top_view_office_supplies_with_copy_space;
            radioButton1.Location = new Point(62, 197);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(289, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Answer 1 asdas kasdmrj masidu rfkejf e";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackgroundImage = Properties.Resources.top_view_office_supplies_with_copy_space;
            radioButton2.Location = new Point(62, 248);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(371, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Answer 2 ajsndajh nakfnnkajek nharkn habefie kaiw ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackgroundImage = Properties.Resources.top_view_office_supplies_with_copy_space;
            radioButton3.Location = new Point(62, 294);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(438, 24);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Answer 3 amskdj nwefnak kawuen erqrk jmoaifui rntiw nkjnasf";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(565, 357);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 6;
            button1.Text = "Next Question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Highlight;
            pictureBox1.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 454);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(41, 357);
            button2.Name = "button2";
            button2.Size = new Size(156, 29);
            button2.TabIndex = 8;
            button2.Text = "Previous Question";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Exam";
            Text = "Exam";
            Load += Exam_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}