namespace Journal
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
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.MardownCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(12, 12);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(100, 37);
            this.SaveFileButton.TabIndex = 0;
            this.SaveFileButton.Text = "Opslaan";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(572, 397);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(118, 12);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(100, 37);
            this.OpenFileButton.TabIndex = 2;
            this.OpenFileButton.Text = "Openen";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // MardownCheckBox
            // 
            this.MardownCheckBox.AutoSize = true;
            this.MardownCheckBox.Location = new System.Drawing.Point(225, 22);
            this.MardownCheckBox.Name = "MardownCheckBox";
            this.MardownCheckBox.Size = new System.Drawing.Size(105, 17);
            this.MardownCheckBox.TabIndex = 3;
            this.MardownCheckBox.Text = "Markdown mode";
            this.MardownCheckBox.UseVisualStyleBackColor = true;
            this.MardownCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 477);
            this.Controls.Add(this.MardownCheckBox);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.CheckBox MardownCheckBox;
    }
}

