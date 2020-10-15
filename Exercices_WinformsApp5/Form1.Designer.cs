namespace Exercices_WinformsApp5
{
    partial class Form1
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
            this.MouseBox = new System.Windows.Forms.CheckBox();
            this.catBox = new System.Windows.Forms.CheckBox();
            this.dogBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MouseBox
            // 
            this.MouseBox.AutoSize = true;
            this.MouseBox.Location = new System.Drawing.Point(93, 80);
            this.MouseBox.Name = "MouseBox";
            this.MouseBox.Size = new System.Drawing.Size(72, 21);
            this.MouseBox.TabIndex = 0;
            this.MouseBox.Text = "Mouse";
            this.MouseBox.UseVisualStyleBackColor = true;
            this.MouseBox.CheckedChanged += new System.EventHandler(this.MouseBox_CheckedChanged);
            // 
            // catBox
            // 
            this.catBox.AutoSize = true;
            this.catBox.Location = new System.Drawing.Point(93, 121);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(51, 21);
            this.catBox.TabIndex = 1;
            this.catBox.Text = "Cat";
            this.catBox.UseVisualStyleBackColor = true;
            this.catBox.CheckedChanged += new System.EventHandler(this.catBox_CheckedChanged);
            // 
            // dogBox
            // 
            this.dogBox.AutoSize = true;
            this.dogBox.Location = new System.Drawing.Point(93, 166);
            this.dogBox.Name = "dogBox";
            this.dogBox.Size = new System.Drawing.Size(56, 21);
            this.dogBox.TabIndex = 2;
            this.dogBox.Text = "Dog";
            this.dogBox.UseVisualStyleBackColor = true;
            this.dogBox.CheckedChanged += new System.EventHandler(this.dogBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(655, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Choosen animals: ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dogBox);
            this.Controls.Add(this.catBox);
            this.Controls.Add(this.MouseBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox MouseBox;
        private System.Windows.Forms.CheckBox catBox;
        private System.Windows.Forms.CheckBox dogBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

