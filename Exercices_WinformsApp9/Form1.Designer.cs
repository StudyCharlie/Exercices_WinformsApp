namespace Exercices_WinformsApp9
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.evenButton = new System.Windows.Forms.Button();
            this.oddButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // evenButton
            // 
            this.evenButton.Location = new System.Drawing.Point(426, 43);
            this.evenButton.Name = "evenButton";
            this.evenButton.Size = new System.Drawing.Size(75, 23);
            this.evenButton.TabIndex = 1;
            this.evenButton.Text = "Even";
            this.evenButton.UseVisualStyleBackColor = true;
            this.evenButton.Click += new System.EventHandler(this.evenButton_Click);
            // 
            // oddButton
            // 
            this.oddButton.Location = new System.Drawing.Point(624, 43);
            this.oddButton.Name = "oddButton";
            this.oddButton.Size = new System.Drawing.Size(75, 23);
            this.oddButton.TabIndex = 2;
            this.oddButton.Text = "Odd";
            this.oddButton.UseVisualStyleBackColor = true;
            this.oddButton.Click += new System.EventHandler(this.oddButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 378);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(652, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.oddButton);
            this.Controls.Add(this.evenButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button evenButton;
        private System.Windows.Forms.Button oddButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

