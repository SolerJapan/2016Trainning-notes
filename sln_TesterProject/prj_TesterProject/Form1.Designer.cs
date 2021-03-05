namespace prj_TesterProject
{
    partial class testerPrj
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tAnsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testerPrj));
            this.oSubBtn = new System.Windows.Forms.Button();
            this.orad1 = new System.Windows.Forms.RadioButton();
            this.questionNo = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orad2 = new System.Windows.Forms.RadioButton();
            this.orad3 = new System.Windows.Forms.RadioButton();
            this.orad4 = new System.Windows.Forms.RadioButton();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.tAnsTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.testerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            tAnsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tAnsLabel
            // 
            tAnsLabel.AutoSize = true;
            tAnsLabel.Location = new System.Drawing.Point(247, 540);
            tAnsLabel.Name = "tAnsLabel";
            tAnsLabel.Size = new System.Drawing.Size(45, 17);
            tAnsLabel.TabIndex = 13;
            tAnsLabel.Text = "TAns:";
            // 
            // oSubBtn
            // 
            this.oSubBtn.Location = new System.Drawing.Point(46, 516);
            this.oSubBtn.Name = "oSubBtn";
            this.oSubBtn.Size = new System.Drawing.Size(123, 47);
            this.oSubBtn.TabIndex = 0;
            this.oSubBtn.Text = "Submit";
            this.oSubBtn.UseVisualStyleBackColor = true;
            // 
            // orad1
            // 
            this.orad1.AutoSize = true;
            this.orad1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.testerBindingSource, "askAns1", true));
            this.orad1.Location = new System.Drawing.Point(158, 227);
            this.orad1.Name = "orad1";
            this.orad1.Size = new System.Drawing.Size(110, 21);
            this.orad1.TabIndex = 1;
            this.orad1.TabStop = true;
            this.orad1.Text = "radioButton1";
            this.orad1.UseVisualStyleBackColor = true;
            // 
            // questionNo
            // 
            this.questionNo.AutoSize = true;
            this.questionNo.Location = new System.Drawing.Point(43, 47);
            this.questionNo.Name = "questionNo";
            this.questionNo.Size = new System.Drawing.Size(73, 17);
            this.questionNo.TabIndex = 2;
            this.questionNo.Text = "Question#";
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(43, 107);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(65, 17);
            this.Question.TabIndex = 3;
            this.Question.Text = "Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // orad2
            // 
            this.orad2.AutoSize = true;
            this.orad2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.testerBindingSource, "askAns2", true));
            this.orad2.Location = new System.Drawing.Point(158, 296);
            this.orad2.Name = "orad2";
            this.orad2.Size = new System.Drawing.Size(110, 21);
            this.orad2.TabIndex = 8;
            this.orad2.TabStop = true;
            this.orad2.Text = "radioButton2";
            this.orad2.UseVisualStyleBackColor = true;
            // 
            // orad3
            // 
            this.orad3.AutoSize = true;
            this.orad3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.testerBindingSource, "askAns3", true));
            this.orad3.Location = new System.Drawing.Point(158, 359);
            this.orad3.Name = "orad3";
            this.orad3.Size = new System.Drawing.Size(110, 21);
            this.orad3.TabIndex = 9;
            this.orad3.TabStop = true;
            this.orad3.Text = "radioButton3";
            this.orad3.UseVisualStyleBackColor = true;
            // 
            // orad4
            // 
            this.orad4.AutoSize = true;
            this.orad4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.testerBindingSource, "askAns4", true));
            this.orad4.Location = new System.Drawing.Point(158, 426);
            this.orad4.Name = "orad4";
            this.orad4.Size = new System.Drawing.Size(110, 21);
            this.orad4.TabIndex = 10;
            this.orad4.TabStop = true;
            this.orad4.Text = "radioButton4";
            this.orad4.UseVisualStyleBackColor = true;
            // 
            // numberBox
            // 
            this.numberBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "QId", true));
            this.numberBox.Location = new System.Drawing.Point(158, 42);
            this.numberBox.Name = "numberBox";
            this.numberBox.ReadOnly = true;
            this.numberBox.Size = new System.Drawing.Size(176, 22);
            this.numberBox.TabIndex = 11;
            // 
            // questionBox
            // 
            this.questionBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "Question", true));
            this.questionBox.Location = new System.Drawing.Point(158, 107);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.ReadOnly = true;
            this.questionBox.Size = new System.Drawing.Size(505, 75);
            this.questionBox.TabIndex = 12;
            // 
            // tAnsTextBox
            // 
            this.tAnsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "TAns", true));
            this.tAnsTextBox.Location = new System.Drawing.Point(298, 537);
            this.tAnsTextBox.Name = "tAnsTextBox";
            this.tAnsTextBox.ReadOnly = true;
            this.tAnsTextBox.Size = new System.Drawing.Size(248, 22);
            this.tAnsTextBox.TabIndex = 14;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(750, 27);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 22);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "askAns2", true));
            this.textBox2.Location = new System.Drawing.Point(298, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "askAns3", true));
            this.textBox3.Location = new System.Drawing.Point(298, 359);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "askAns4", true));
            this.textBox4.Location = new System.Drawing.Point(298, 426);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 22);
            this.textBox4.TabIndex = 19;
            // 
            // testerBindingSource
            // 
            this.testerBindingSource.DataSource = typeof(prj_TesterProject.Models.Tester);
            // 
            // testerPrj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(750, 587);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(tAnsLabel);
            this.Controls.Add(this.tAnsTextBox);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.orad4);
            this.Controls.Add(this.orad3);
            this.Controls.Add(this.orad2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.questionNo);
            this.Controls.Add(this.orad1);
            this.Controls.Add(this.oSubBtn);
            this.Name = "testerPrj";
            this.Text = "TesterProj";
            this.Load += new System.EventHandler(this.testerPrj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oSubBtn;
        private System.Windows.Forms.RadioButton orad1;
        private System.Windows.Forms.Label questionNo;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton orad2;
        private System.Windows.Forms.RadioButton orad3;
        private System.Windows.Forms.RadioButton orad4;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.BindingSource testerBindingSource;
        private System.Windows.Forms.TextBox tAnsTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

