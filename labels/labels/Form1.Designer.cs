namespace labels
{
    partial class LabelTextBoxButtonTestForm
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
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.displayPaswwordButton = new System.Windows.Forms.Button();
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Location = new System.Drawing.Point(60, 58);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.Size = new System.Drawing.Size(403, 22);
            this.inputPasswordTextBox.TabIndex = 0;
            this.inputPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // displayPaswwordButton
            // 
            this.displayPaswwordButton.Location = new System.Drawing.Point(60, 306);
            this.displayPaswwordButton.Name = "displayPaswwordButton";
            this.displayPaswwordButton.Size = new System.Drawing.Size(403, 75);
            this.displayPaswwordButton.TabIndex = 1;
            this.displayPaswwordButton.Text = "show me";
            this.displayPaswwordButton.UseVisualStyleBackColor = true;
            this.displayPaswwordButton.Click += new System.EventHandler(this.displayPaswwordButton_Click);
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.AutoSize = true;
            this.displayPasswordLabel.Location = new System.Drawing.Point(60, 208);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(0, 17);
            this.displayPasswordLabel.TabIndex = 2;
            // 
            // LabelTextBoxButtonTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(602, 547);
            this.Controls.Add(this.displayPasswordLabel);
            this.Controls.Add(this.displayPaswwordButton);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Name = "LabelTextBoxButtonTestForm";
            this.Text = "Label, Textbox, and button Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPasswordTextBox;
        private System.Windows.Forms.Button displayPaswwordButton;
        private System.Windows.Forms.Label displayPasswordLabel;
    }
}

