namespace stackCollection
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
            this.stackCollectionLabel = new System.Windows.Forms.Label();
            this.stackCollection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stackCollectionLabel
            // 
            this.stackCollectionLabel.AutoSize = true;
            this.stackCollectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stackCollectionLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.stackCollectionLabel.Location = new System.Drawing.Point(109, 77);
            this.stackCollectionLabel.Name = "stackCollectionLabel";
            this.stackCollectionLabel.Size = new System.Drawing.Size(232, 29);
            this.stackCollectionLabel.TabIndex = 0;
            this.stackCollectionLabel.Text = "C Sharp Collection";
            // 
            // stackCollection
            // 
            this.stackCollection.Location = new System.Drawing.Point(112, 178);
            this.stackCollection.Name = "stackCollection";
            this.stackCollection.Size = new System.Drawing.Size(376, 136);
            this.stackCollection.TabIndex = 1;
            this.stackCollection.Text = "Stack Collection";
            this.stackCollection.UseVisualStyleBackColor = true;
            this.stackCollection.Click += new System.EventHandler(this.stackCollection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(670, 543);
            this.Controls.Add(this.stackCollection);
            this.Controls.Add(this.stackCollectionLabel);
            this.Name = "Form1";
            this.Text = "Stack Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stackCollectionLabel;
        private System.Windows.Forms.Button stackCollection;
    }
}

