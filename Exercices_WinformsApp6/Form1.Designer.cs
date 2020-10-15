namespace Exercices_WinformsApp6
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
            this.RedButton = new System.Windows.Forms.RadioButton();
            this.BlueButton = new System.Windows.Forms.RadioButton();
            this.WhiteButton = new System.Windows.Forms.RadioButton();
            this.OkButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RedButton
            // 
            this.RedButton.AutoSize = true;
            this.RedButton.Location = new System.Drawing.Point(180, 112);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(55, 21);
            this.RedButton.TabIndex = 0;
            this.RedButton.TabStop = true;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = true;
            // 
            // BlueButton
            // 
            this.BlueButton.AutoSize = true;
            this.BlueButton.Location = new System.Drawing.Point(178, 152);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(57, 21);
            this.BlueButton.TabIndex = 1;
            this.BlueButton.TabStop = true;
            this.BlueButton.Text = "Blue";
            this.BlueButton.UseVisualStyleBackColor = true;
            // 
            // WhiteButton
            // 
            this.WhiteButton.AutoSize = true;
            this.WhiteButton.Location = new System.Drawing.Point(178, 194);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(65, 21);
            this.WhiteButton.TabIndex = 2;
            this.WhiteButton.TabStop = true;
            this.WhiteButton.Text = "White";
            this.WhiteButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(65, 269);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 367);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(654, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.WhiteButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.RedButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RedButton;
        private System.Windows.Forms.RadioButton BlueButton;
        private System.Windows.Forms.RadioButton WhiteButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

