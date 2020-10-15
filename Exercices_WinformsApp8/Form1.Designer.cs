namespace Exercices_WinformsApp8
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Classroom1Button = new System.Windows.Forms.Button();
            this.Classroom2Button = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Classroom1Button
            // 
            this.Classroom1Button.Location = new System.Drawing.Point(55, 165);
            this.Classroom1Button.Name = "Classroom1Button";
            this.Classroom1Button.Size = new System.Drawing.Size(92, 30);
            this.Classroom1Button.TabIndex = 2;
            this.Classroom1Button.Text = "Classroom1";
            this.Classroom1Button.UseVisualStyleBackColor = true;
            this.Classroom1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Classroom2Button
            // 
            this.Classroom2Button.Location = new System.Drawing.Point(55, 218);
            this.Classroom2Button.Name = "Classroom2Button";
            this.Classroom2Button.Size = new System.Drawing.Size(92, 29);
            this.Classroom2Button.TabIndex = 3;
            this.Classroom2Button.Text = "Classroom2";
            this.Classroom2Button.UseVisualStyleBackColor = true;
            this.Classroom2Button.Click += new System.EventHandler(this.Classroom2Button_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Location = new System.Drawing.Point(55, 315);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(92, 39);
            this.clearListButton.TabIndex = 4;
            this.clearListButton.Text = "Clear List";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.Classroom2Button);
            this.Controls.Add(this.Classroom1Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Classroom1Button;
        private System.Windows.Forms.Button Classroom2Button;
        private System.Windows.Forms.Button clearListButton;
    }
}

