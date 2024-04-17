namespace Examanation_System.Resources
{
    partial class SubjectStudent
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
            label1 = new Label();
            comboBox1 = new ComboBox();
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Image = Properties.Resources.top_view_office_supplies_with_copy_space;
            label1.Location = new Point(148, 151);
            label1.Name = "label1";
            label1.Size = new Size(207, 29);
            label1.TabIndex = 5;
            label1.Text = "Choose Subject:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(367, 251);
            button1.Name = "button1";
            button1.Size = new Size(102, 38);
            button1.TabIndex = 7;
            button1.Text = "Start Exam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SubjectStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SubjectStudent";
            Text = "SubjectChoose";
            Load += SubjectStudent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
    }
}