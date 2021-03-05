namespace WindowsFormsApplication1
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
            this.ArrayListButton = new System.Windows.Forms.Button();
            this.ArrayListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArrayListButton
            // 
            this.ArrayListButton.Location = new System.Drawing.Point(152, 197);
            this.ArrayListButton.Name = "ArrayListButton";
            this.ArrayListButton.Size = new System.Drawing.Size(308, 159);
            this.ArrayListButton.TabIndex = 0;
            this.ArrayListButton.Text = "ArrayList Button";
            this.ArrayListButton.UseVisualStyleBackColor = true;
            this.ArrayListButton.Click += new System.EventHandler(this.ArrayListButton_Click);
            // 
            // ArrayListLabel
            // 
            this.ArrayListLabel.AutoSize = true;
            this.ArrayListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ArrayListLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ArrayListLabel.Location = new System.Drawing.Point(152, 87);
            this.ArrayListLabel.Name = "ArrayListLabel";
            this.ArrayListLabel.Size = new System.Drawing.Size(167, 25);
            this.ArrayListLabel.TabIndex = 1;
            this.ArrayListLabel.Text = "C Sharp ArrayList";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(659, 554);
            this.Controls.Add(this.ArrayListLabel);
            this.Controls.Add(this.ArrayListButton);
            this.Name = "Form1";
            this.Text = "ArrayListFormVer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ArrayListButton;
        private System.Windows.Forms.Label ArrayListLabel;
    }
}

