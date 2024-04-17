namespace Examanation_System.Resources
{
    partial class YourGrade
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Highlight;
            pictureBox1.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            pictureBox1.Location = new Point(-8, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(816, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label3.Location = new Point(78, 72);
            label3.Name = "label3";
            label3.Size = new Size(442, 39);
            label3.TabIndex = 5;
            label3.Text = "You Finished Your Exam";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label1.Location = new Point(151, 175);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 6;
            label1.Text = "Your Grade Is :";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Peru;
            button1.Location = new Point(216, 324);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 7;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // YourGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "YourGrade";
            Text = "YourGrade";
            Load += YourGrade_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private Button button1;
    }
}