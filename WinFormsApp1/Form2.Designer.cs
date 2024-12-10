namespace WinFormsApp1
{
    partial class Form2
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 246);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "By for Pedro Henrique";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1, 18);
            label2.Name = "label2";
            label2.Size = new Size(420, 29);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Bloco de Notas Simples";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_20201206_114540;
            pictureBox1.Location = new Point(261, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 277);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}