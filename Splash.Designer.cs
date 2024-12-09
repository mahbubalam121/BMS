namespace Blood
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            Myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Myprogress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(43, 25);
            label1.Name = "label1";
            label1.Size = new Size(404, 29);
            label1.TabIndex = 1;
            label1.Text = "Blood Bank Management System";
            // 
            // Myprogress
            // 
            Myprogress.Controls.Add(pictureBox1);
            Myprogress.FillColor = Color.FromArgb(200, 213, 218, 223);
            Myprogress.FillThickness = 8;
            Myprogress.Font = new Font("Segoe UI", 12F);
            Myprogress.ForeColor = Color.White;
            Myprogress.Location = new Point(173, 81);
            Myprogress.Minimum = 0;
            Myprogress.Name = "Myprogress";
            Myprogress.ProgressColor = Color.Brown;
            Myprogress.ProgressColor2 = Color.Brown;
            Myprogress.ProgressThickness = 10;
            Myprogress.ShadowDecoration.CustomizableEdges = customizableEdges1;
            Myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Myprogress.Size = new Size(130, 130);
            Myprogress.TabIndex = 2;
            Myprogress.Text = "guna2CircleProgressBar1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 292);
            Controls.Add(Myprogress);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Myprogress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogress;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}