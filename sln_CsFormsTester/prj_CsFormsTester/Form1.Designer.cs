namespace prj_CsFormsTester
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label answer1Label;
            System.Windows.Forms.Label answer2Label;
            System.Windows.Forms.Label answer3Label;
            System.Windows.Forms.Label answer4Label;
            System.Windows.Forms.Label questionLabel;
            System.Windows.Forms.Label questionIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.testerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.testerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oRadAns1 = new System.Windows.Forms.RadioButton();
            this.oRadAns2 = new System.Windows.Forms.RadioButton();
            this.oRadAns3 = new System.Windows.Forms.RadioButton();
            this.oRadAns4 = new System.Windows.Forms.RadioButton();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.questionIdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.oTsLabTally = new System.Windows.Forms.ToolStripStatusLabel();
            this.testerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            answer1Label = new System.Windows.Forms.Label();
            answer2Label = new System.Windows.Forms.Label();
            answer3Label = new System.Windows.Forms.Label();
            answer4Label = new System.Windows.Forms.Label();
            questionLabel = new System.Windows.Forms.Label();
            questionIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testerBindingNavigator)).BeginInit();
            this.testerBindingNavigator.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // answer1Label
            // 
            answer1Label.AutoSize = true;
            answer1Label.Location = new System.Drawing.Point(48, 241);
            answer1Label.Name = "answer1Label";
            answer1Label.Size = new System.Drawing.Size(66, 17);
            answer1Label.TabIndex = 11;
            answer1Label.Text = "Answer1:";
            // 
            // answer2Label
            // 
            answer2Label.AutoSize = true;
            answer2Label.Location = new System.Drawing.Point(48, 294);
            answer2Label.Name = "answer2Label";
            answer2Label.Size = new System.Drawing.Size(66, 17);
            answer2Label.TabIndex = 12;
            answer2Label.Text = "Answer2:";
            // 
            // answer3Label
            // 
            answer3Label.AutoSize = true;
            answer3Label.Location = new System.Drawing.Point(48, 346);
            answer3Label.Name = "answer3Label";
            answer3Label.Size = new System.Drawing.Size(66, 17);
            answer3Label.TabIndex = 13;
            answer3Label.Text = "Answer3:";
            // 
            // answer4Label
            // 
            answer4Label.AutoSize = true;
            answer4Label.Location = new System.Drawing.Point(48, 405);
            answer4Label.Name = "answer4Label";
            answer4Label.Size = new System.Drawing.Size(66, 17);
            answer4Label.TabIndex = 14;
            answer4Label.Text = "Answer4:";
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(48, 105);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(69, 17);
            questionLabel.TabIndex = 10;
            questionLabel.Text = "Question:";
            // 
            // questionIdLabel
            // 
            questionIdLabel.AutoSize = true;
            questionIdLabel.Location = new System.Drawing.Point(48, 61);
            questionIdLabel.Name = "questionIdLabel";
            questionIdLabel.Size = new System.Drawing.Size(84, 17);
            questionIdLabel.TabIndex = 9;
            questionIdLabel.Text = "Question Id:";
            // 
            // testerBindingNavigator
            // 
            this.testerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.testerBindingNavigator.BindingSource = this.testerBindingSource;
            this.testerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.testerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.testerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.testerBindingNavigatorSaveItem});
            this.testerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testerBindingNavigator.Name = "testerBindingNavigator";
            this.testerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testerBindingNavigator.Size = new System.Drawing.Size(739, 27);
            this.testerBindingNavigator.TabIndex = 8;
            this.testerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
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
            this.bindingNavigatorDeleteItem.Enabled = false;
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
            // testerBindingNavigatorSaveItem
            // 
            this.testerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testerBindingNavigatorSaveItem.Enabled = false;
            this.testerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testerBindingNavigatorSaveItem.Image")));
            this.testerBindingNavigatorSaveItem.Name = "testerBindingNavigatorSaveItem";
            this.testerBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.testerBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // oRadAns1
            // 
            this.oRadAns1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "Answer1", true));
            this.oRadAns1.Location = new System.Drawing.Point(138, 235);
            this.oRadAns1.Name = "oRadAns1";
            this.oRadAns1.Size = new System.Drawing.Size(516, 24);
            this.oRadAns1.TabIndex = 2;
            this.oRadAns1.TabStop = true;
            this.oRadAns1.Tag = "1";
            this.oRadAns1.Text = "radioButton1";
            this.oRadAns1.UseVisualStyleBackColor = true;
            // 
            // oRadAns2
            // 
            this.oRadAns2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "Answer2", true));
            this.oRadAns2.Location = new System.Drawing.Point(138, 288);
            this.oRadAns2.Name = "oRadAns2";
            this.oRadAns2.Size = new System.Drawing.Size(516, 24);
            this.oRadAns2.TabIndex = 3;
            this.oRadAns2.TabStop = true;
            this.oRadAns2.Tag = "2";
            this.oRadAns2.Text = "radioButton1";
            this.oRadAns2.UseVisualStyleBackColor = true;
            // 
            // oRadAns3
            // 
            this.oRadAns3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "Answer3", true));
            this.oRadAns3.Location = new System.Drawing.Point(138, 340);
            this.oRadAns3.Name = "oRadAns3";
            this.oRadAns3.Size = new System.Drawing.Size(516, 24);
            this.oRadAns3.TabIndex = 4;
            this.oRadAns3.TabStop = true;
            this.oRadAns3.Tag = "3";
            this.oRadAns3.Text = "radioButton1";
            this.oRadAns3.UseVisualStyleBackColor = true;
            // 
            // oRadAns4
            // 
            this.oRadAns4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "Answer4", true));
            this.oRadAns4.Location = new System.Drawing.Point(138, 399);
            this.oRadAns4.Name = "oRadAns4";
            this.oRadAns4.Size = new System.Drawing.Size(516, 24);
            this.oRadAns4.TabIndex = 5;
            this.oRadAns4.TabStop = true;
            this.oRadAns4.Tag = "4";
            this.oRadAns4.Text = "radioButton1";
            this.oRadAns4.UseVisualStyleBackColor = true;
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "Question", true));
            this.questionTextBox.Location = new System.Drawing.Point(161, 102);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(493, 83);
            this.questionTextBox.TabIndex = 1;
            // 
            // questionIdTextBox
            // 
            this.questionIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testerBindingSource, "QuestionId", true));
            this.questionIdTextBox.Location = new System.Drawing.Point(161, 56);
            this.questionIdTextBox.Name = "questionIdTextBox";
            this.questionIdTextBox.Size = new System.Drawing.Size(170, 22);
            this.questionIdTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oTsLabTally});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(739, 25);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "Ready";
            // 
            // oTsLabTally
            // 
            this.oTsLabTally.Name = "oTsLabTally";
            this.oTsLabTally.Size = new System.Drawing.Size(50, 20);
            this.oTsLabTally.Text = "Ready";
            // 
            // testerBindingSource
            // 
            this.testerBindingSource.DataSource = typeof(prj_CsFormsTester.Tester);
            this.testerBindingSource.PositionChanged += new System.EventHandler(this.testerBindingSource_PositionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 584);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(answer1Label);
            this.Controls.Add(this.oRadAns1);
            this.Controls.Add(answer2Label);
            this.Controls.Add(this.oRadAns2);
            this.Controls.Add(answer3Label);
            this.Controls.Add(this.oRadAns3);
            this.Controls.Add(answer4Label);
            this.Controls.Add(this.oRadAns4);
            this.Controls.Add(questionLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(questionIdLabel);
            this.Controls.Add(this.questionIdTextBox);
            this.Controls.Add(this.testerBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testerBindingNavigator)).EndInit();
            this.testerBindingNavigator.ResumeLayout(false);
            this.testerBindingNavigator.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource testerBindingSource;
        private System.Windows.Forms.BindingNavigator testerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton testerBindingNavigatorSaveItem;
        private System.Windows.Forms.RadioButton oRadAns1;
        private System.Windows.Forms.RadioButton oRadAns2;
        private System.Windows.Forms.RadioButton oRadAns3;
        private System.Windows.Forms.RadioButton oRadAns4;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox questionIdTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel oTsLabTally;
    }
}

