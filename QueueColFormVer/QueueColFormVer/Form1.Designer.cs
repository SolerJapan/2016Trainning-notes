namespace QueueColFormVer
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
            this.QueueButton = new System.Windows.Forms.Button();
            this.QueueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QueueButton
            // 
            this.QueueButton.Location = new System.Drawing.Point(186, 238);
            this.QueueButton.Name = "QueueButton";
            this.QueueButton.Size = new System.Drawing.Size(278, 131);
            this.QueueButton.TabIndex = 0;
            this.QueueButton.Text = "QueueButton";
            this.QueueButton.UseVisualStyleBackColor = true;
            this.QueueButton.Click += new System.EventHandler(this.QueueButton_Click);
            // 
            // QueueLabel
            // 
            this.QueueLabel.AutoSize = true;
            this.QueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QueueLabel.Location = new System.Drawing.Point(186, 116);
            this.QueueLabel.Name = "QueueLabel";
            this.QueueLabel.Size = new System.Drawing.Size(163, 25);
            this.QueueLabel.TabIndex = 1;
            this.QueueLabel.Text = "C Sharp Queue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(627, 479);
            this.Controls.Add(this.QueueLabel);
            this.Controls.Add(this.QueueButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QueueButton;
        private System.Windows.Forms.Label QueueLabel;
    }
}

