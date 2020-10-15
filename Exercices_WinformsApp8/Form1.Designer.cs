namespace Exercice_WinformsApp8
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.Classroom1Button = new System.Windows.Forms.Button();
            this.Classroom2Button = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 31);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 84);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox.SelectedValueChanged += new System.EventHandler(this.listBox_SelectedValueChanged);
            // 
            // Classroom1Button
            // 
            this.Classroom1Button.Location = new System.Drawing.Point(37, 208);
            this.Classroom1Button.Name = "Classroom1Button";
            this.Classroom1Button.Size = new System.Drawing.Size(106, 35);
            this.Classroom1Button.TabIndex = 1;
            this.Classroom1Button.Text = "Classroom1";
            this.Classroom1Button.UseVisualStyleBackColor = true;
            this.Classroom1Button.Click += new System.EventHandler(this.Classroom1Button_Click);
            // 
            // Classroom2Button
            // 
            this.Classroom2Button.Location = new System.Drawing.Point(37, 272);
            this.Classroom2Button.Name = "Classroom2Button";
            this.Classroom2Button.Size = new System.Drawing.Size(106, 34);
            this.Classroom2Button.TabIndex = 2;
            this.Classroom2Button.Text = "Classroom2";
            this.Classroom2Button.UseVisualStyleBackColor = true;
            this.Classroom2Button.Click += new System.EventHandler(this.Classroom2Button_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Location = new System.Drawing.Point(37, 368);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(106, 32);
            this.clearListButton.TabIndex = 3;
            this.clearListButton.Text = "Clear List";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.Classroom2Button);
            this.Controls.Add(this.Classroom1Button);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button Classroom1Button;
        private System.Windows.Forms.Button Classroom2Button;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

