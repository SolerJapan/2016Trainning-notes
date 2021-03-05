namespace arrayCollection
{
    partial class Form
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
            this.ArrayLabel = new System.Windows.Forms.Label();
            this.ArrayCollection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ArrayLabel
            // 
            this.ArrayLabel.AutoSize = true;
            this.ArrayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ArrayLabel.Location = new System.Drawing.Point(116, 81);
            this.ArrayLabel.Name = "ArrayLabel";
            this.ArrayLabel.Size = new System.Drawing.Size(172, 25);
            this.ArrayLabel.TabIndex = 0;
            this.ArrayLabel.Text = "C sharp Collection";
            // 
            // ArrayCollection
            // 
            this.ArrayCollection.Location = new System.Drawing.Point(119, 185);
            this.ArrayCollection.Name = "ArrayCollection";
            this.ArrayCollection.Size = new System.Drawing.Size(225, 54);
            this.ArrayCollection.TabIndex = 1;
            this.ArrayCollection.Text = "ArrayCollection";
            this.ArrayCollection.UseVisualStyleBackColor = true;
            this.ArrayCollection.Click += new System.EventHandler(this.ArrayCollection_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(566, 517);
            this.Controls.Add(this.ArrayCollection);
            this.Controls.Add(this.ArrayLabel);
            this.Name = "Form";
            this.Text = "Array Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArrayLabel;
        private System.Windows.Forms.Button ArrayCollection;
    }
}

