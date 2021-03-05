namespace listCollection
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
            this.ListButton = new System.Windows.Forms.Button();
            this.listLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListButton
            // 
            this.ListButton.Location = new System.Drawing.Point(95, 189);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(301, 59);
            this.ListButton.TabIndex = 0;
            this.ListButton.Text = "List Button";
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listLabel.ForeColor = System.Drawing.Color.Lime;
            this.listLabel.Location = new System.Drawing.Point(95, 90);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(194, 25);
            this.listLabel.TabIndex = 1;
            this.listLabel.Text = "C Sharp Collection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(581, 538);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.ListButton);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Text = "List Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Label listLabel;
    }
}

