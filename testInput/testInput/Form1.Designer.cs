namespace testInput
{
    partial class tFormInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tFormInput));
            this.askIdLabel = new System.Windows.Forms.Label();
            this.askLabel = new System.Windows.Forms.Label();
            this.ans1Label = new System.Windows.Forms.Label();
            this.ans2Label = new System.Windows.Forms.Label();
            this.ans3Label = new System.Windows.Forms.Label();
            this.askIdTextBox = new System.Windows.Forms.TextBox();
            this.qABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataDataSet = new testInput.testDataDataSet();
            this.askTextBox = new System.Windows.Forms.TextBox();
            this.ans1TextBox = new System.Windows.Forms.TextBox();
            this.ans2TextBox = new System.Windows.Forms.TextBox();
            this.ans3TextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ans4TextBox = new System.Windows.Forms.Label();
            this.qABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.qABingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.qATableAdapter = new testInput.testDataDataSetTableAdapters.QATableAdapter();
            this.tableAdapterManager = new testInput.testDataDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.qABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qABindingNavigator)).BeginInit();
            this.qABindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // askIdLabel
            // 
            this.askIdLabel.AutoSize = true;
            this.askIdLabel.Location = new System.Drawing.Point(67, 81);
            this.askIdLabel.Name = "askIdLabel";
            this.askIdLabel.Size = new System.Drawing.Size(54, 17);
            this.askIdLabel.TabIndex = 0;
            this.askIdLabel.Text = "Ask Id :";
            // 
            // askLabel
            // 
            this.askLabel.AutoSize = true;
            this.askLabel.Location = new System.Drawing.Point(67, 151);
            this.askLabel.Name = "askLabel";
            this.askLabel.Size = new System.Drawing.Size(39, 17);
            this.askLabel.TabIndex = 1;
            this.askLabel.Text = "Ask :";
            // 
            // ans1Label
            // 
            this.ans1Label.AutoSize = true;
            this.ans1Label.Location = new System.Drawing.Point(67, 225);
            this.ans1Label.Name = "ans1Label";
            this.ans1Label.Size = new System.Drawing.Size(52, 17);
            this.ans1Label.TabIndex = 2;
            this.ans1Label.Text = "Ans 1 :";
            // 
            // ans2Label
            // 
            this.ans2Label.AutoSize = true;
            this.ans2Label.Location = new System.Drawing.Point(67, 297);
            this.ans2Label.Name = "ans2Label";
            this.ans2Label.Size = new System.Drawing.Size(52, 17);
            this.ans2Label.TabIndex = 3;
            this.ans2Label.Text = "Ans 2 :";
            // 
            // ans3Label
            // 
            this.ans3Label.AutoSize = true;
            this.ans3Label.Location = new System.Drawing.Point(67, 379);
            this.ans3Label.Name = "ans3Label";
            this.ans3Label.Size = new System.Drawing.Size(52, 17);
            this.ans3Label.TabIndex = 4;
            this.ans3Label.Text = "Ans 3 :";
            // 
            // askIdTextBox
            // 
            this.askIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "AskId", true));
            this.askIdTextBox.Location = new System.Drawing.Point(265, 81);
            this.askIdTextBox.Name = "askIdTextBox";
            this.askIdTextBox.Size = new System.Drawing.Size(400, 22);
            this.askIdTextBox.TabIndex = 5;
            // 
            // qABindingSource
            // 
            this.qABindingSource.DataMember = "QA";
            this.qABindingSource.DataSource = this.testDataDataSet;
            // 
            // testDataDataSet
            // 
            this.testDataDataSet.DataSetName = "testDataDataSet";
            this.testDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // askTextBox
            // 
            this.askTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ask", true));
            this.askTextBox.Location = new System.Drawing.Point(265, 151);
            this.askTextBox.Name = "askTextBox";
            this.askTextBox.Size = new System.Drawing.Size(400, 22);
            this.askTextBox.TabIndex = 6;
            // 
            // ans1TextBox
            // 
            this.ans1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ans1", true));
            this.ans1TextBox.Location = new System.Drawing.Point(265, 225);
            this.ans1TextBox.Name = "ans1TextBox";
            this.ans1TextBox.Size = new System.Drawing.Size(400, 22);
            this.ans1TextBox.TabIndex = 7;
            // 
            // ans2TextBox
            // 
            this.ans2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ans2", true));
            this.ans2TextBox.Location = new System.Drawing.Point(265, 297);
            this.ans2TextBox.Name = "ans2TextBox";
            this.ans2TextBox.Size = new System.Drawing.Size(400, 22);
            this.ans2TextBox.TabIndex = 8;
            // 
            // ans3TextBox
            // 
            this.ans3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ans3", true));
            this.ans3TextBox.Location = new System.Drawing.Point(265, 379);
            this.ans3TextBox.Name = "ans3TextBox";
            this.ans3TextBox.Size = new System.Drawing.Size(400, 22);
            this.ans3TextBox.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ans4", true));
            this.textBox1.Location = new System.Drawing.Point(265, 447);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 22);
            this.textBox1.TabIndex = 10;
            // 
            // ans4TextBox
            // 
            this.ans4TextBox.AutoSize = true;
            this.ans4TextBox.Location = new System.Drawing.Point(70, 451);
            this.ans4TextBox.Name = "ans4TextBox";
            this.ans4TextBox.Size = new System.Drawing.Size(52, 17);
            this.ans4TextBox.TabIndex = 11;
            this.ans4TextBox.Text = "Ans 4 :";
            // 
            // qABindingNavigator
            // 
            this.qABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qABindingNavigator.BindingSource = this.qABindingSource;
            this.qABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qABindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.qABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.qABingNavigatorSaveItem});
            this.qABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qABindingNavigator.Name = "qABindingNavigator";
            this.qABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qABindingNavigator.Size = new System.Drawing.Size(736, 27);
            this.qABindingNavigator.TabIndex = 12;
            this.qABindingNavigator.Text = "bindingNavigator1";
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
            // qABingNavigatorSaveItem
            // 
            this.qABingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qABingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qABingNavigatorSaveItem.Image")));
            this.qABingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.qABingNavigatorSaveItem.Name = "qABingNavigatorSaveItem";
            this.qABingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.qABingNavigatorSaveItem.Text = "save";
            this.qABingNavigatorSaveItem.Click += new System.EventHandler(this.qABingNavigatorSaveItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(736, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // qATableAdapter
            // 
            this.qATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QATableAdapter = this.qATableAdapter;
            this.tableAdapterManager.UpdateOrder = testInput.testDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tFormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 532);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.qABindingNavigator);
            this.Controls.Add(this.ans4TextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ans3TextBox);
            this.Controls.Add(this.ans2TextBox);
            this.Controls.Add(this.ans1TextBox);
            this.Controls.Add(this.askTextBox);
            this.Controls.Add(this.askIdTextBox);
            this.Controls.Add(this.ans3Label);
            this.Controls.Add(this.ans2Label);
            this.Controls.Add(this.ans1Label);
            this.Controls.Add(this.askLabel);
            this.Controls.Add(this.askIdLabel);
            this.Name = "tFormInput";
            this.Text = "Tester Input";
            this.Load += new System.EventHandler(this.tFormInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qABindingNavigator)).EndInit();
            this.qABindingNavigator.ResumeLayout(false);
            this.qABindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label askIdLabel;
        private System.Windows.Forms.Label askLabel;
        private System.Windows.Forms.Label ans1Label;
        private System.Windows.Forms.Label ans2Label;
        private System.Windows.Forms.Label ans3Label;
        private System.Windows.Forms.TextBox askIdTextBox;
        private System.Windows.Forms.TextBox askTextBox;
        private System.Windows.Forms.TextBox ans1TextBox;
        private System.Windows.Forms.TextBox ans2TextBox;
        private System.Windows.Forms.TextBox ans3TextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ans4TextBox;
        private System.Windows.Forms.BindingNavigator qABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton qABingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private testDataDataSet testDataDataSet;
        private System.Windows.Forms.BindingSource qABindingSource;
        private testDataDataSetTableAdapters.QATableAdapter qATableAdapter;
        private testDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

