namespace sqlServerConnection
{
    partial class SQLServerConnectionTest
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
            this.SqlServerLabel = new System.Windows.Forms.Label();
            this.sqlServerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SqlServerLabel
            // 
            this.SqlServerLabel.AutoSize = true;
            this.SqlServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SqlServerLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SqlServerLabel.Location = new System.Drawing.Point(123, 84);
            this.SqlServerLabel.Name = "SqlServerLabel";
            this.SqlServerLabel.Size = new System.Drawing.Size(209, 25);
            this.SqlServerLabel.TabIndex = 0;
            this.SqlServerLabel.Text = "Sql Server Connection";
            // 
            // sqlServerButton
            // 
            this.sqlServerButton.Location = new System.Drawing.Point(126, 204);
            this.sqlServerButton.Name = "sqlServerButton";
            this.sqlServerButton.Size = new System.Drawing.Size(337, 124);
            this.sqlServerButton.TabIndex = 1;
            this.sqlServerButton.Text = "Sql Servel Connection";
            this.sqlServerButton.UseVisualStyleBackColor = true;
            this.sqlServerButton.Click += new System.EventHandler(this.sqlServerButton_Click);
            // 
            // SQLServerConnectionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(642, 563);
            this.Controls.Add(this.sqlServerButton);
            this.Controls.Add(this.SqlServerLabel);
            this.Name = "SQLServerConnectionTest";
            this.Text = "Sql Server Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SqlServerLabel;
        private System.Windows.Forms.Button sqlServerButton;
    }
}

