namespace GeriSayimApp
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            Minimum = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar2 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(123, 41);
            progressBar1.Margin = new Padding(5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(778, 68);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 50;
            // 
            // Minimum
            // 
            Minimum.AutoSize = true;
            Minimum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Minimum.Location = new Point(123, 150);
            Minimum.Name = "Minimum";
            Minimum.Size = new Size(96, 28);
            Minimum.TabIndex = 1;
            Minimum.Text = "Minimum";
            Minimum.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(791, 150);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 2;
            label1.Text = "Maximum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(484, 150);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 3;
            label2.Text = "Value";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(649, 69);
            label3.Name = "label3";
            label3.Size = new Size(156, 31);
            label3.TabIndex = 4;
            label3.Text = "10 second left";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(38, 71);
            progressBar2.Maximum = 10;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(568, 29);
            progressBar2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(40, 146);
            button1.Name = "button1";
            button1.Size = new Size(120, 45);
            button1.TabIndex = 6;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 146);
            button2.Name = "button2";
            button2.Size = new Size(119, 45);
            button2.TabIndex = 7;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(progressBar2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(93, 242);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 203);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Countdown";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 513);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Minimum);
            Controls.Add(progressBar1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label Minimum;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar2;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
