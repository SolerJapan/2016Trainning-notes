namespace winFormTester
{
    partial class tformProto
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
            this.oTxtBox = new System.Windows.Forms.TextBox();
            this.oBtnPrev = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Ans = new System.Windows.Forms.RadioButton();
            this.oBtnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oTxtBox
            // 
            this.oTxtBox.Location = new System.Drawing.Point(38, 48);
            this.oTxtBox.Multiline = true;
            this.oTxtBox.Name = "oTxtBox";
            this.oTxtBox.Size = new System.Drawing.Size(400, 62);
            this.oTxtBox.TabIndex = 0;
            // 
            // oBtnPrev
            // 
            this.oBtnPrev.Location = new System.Drawing.Point(52, 484);
            this.oBtnPrev.Name = "oBtnPrev";
            this.oBtnPrev.Size = new System.Drawing.Size(110, 36);
            this.oBtnPrev.TabIndex = 1;
            this.oBtnPrev.Text = "Previous";
            this.oBtnPrev.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(52, 188);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(52, 262);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(52, 336);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.Location = new System.Drawing.Point(52, 410);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(110, 21);
            this.Ans.TabIndex = 5;
            this.Ans.TabStop = true;
            this.Ans.Text = "radioButton4";
            this.Ans.UseVisualStyleBackColor = true;
            // 
            // oBtnNext
            // 
            this.oBtnNext.Location = new System.Drawing.Point(322, 484);
            this.oBtnNext.Name = "oBtnNext";
            this.oBtnNext.Size = new System.Drawing.Size(116, 36);
            this.oBtnNext.TabIndex = 6;
            this.oBtnNext.Text = "Next";
            this.oBtnNext.UseVisualStyleBackColor = true;
            // 
            // tformProto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 562);
            this.Controls.Add(this.oBtnNext);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.oBtnPrev);
            this.Controls.Add(this.oTxtBox);
            this.Name = "tformProto";
            this.Text = "Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oTxtBox;
        private System.Windows.Forms.Button oBtnPrev;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton Ans;
        private System.Windows.Forms.Button oBtnNext;
    }
}