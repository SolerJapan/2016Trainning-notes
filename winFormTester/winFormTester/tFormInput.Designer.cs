namespace winFormTester
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
            this.qABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.qABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataDataSet1 = new winFormTester.testDataDataSet1();
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
            this.qABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.askIdLabel = new System.Windows.Forms.Label();
            this.askLabel = new System.Windows.Forms.Label();
            this.ans1Label = new System.Windows.Forms.Label();
            this.ans2Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.askIdTextBox = new System.Windows.Forms.TextBox();
            this.askTextBox = new System.Windows.Forms.TextBox();
            this.ans1TextBox = new System.Windows.Forms.TextBox();
            this.ans2TextBox = new System.Windows.Forms.TextBox();
            this.ans3TextBox = new System.Windows.Forms.TextBox();
            this.ans4TextBox = new System.Windows.Forms.TextBox();
            this.qATableAdapter = new winFormTester.testDataDataSet1TableAdapters.QATableAdapter();
            this.tableAdapterManager = new winFormTester.testDataDataSet1TableAdapters.TableAdapterManager();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qABindingNavigator)).BeginInit();
            this.qABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataDataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.qABindingNavigatorSaveItem});
            this.qABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qABindingNavigator.Name = "qABindingNavigator";
            this.qABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qABindingNavigator.Size = new System.Drawing.Size(651, 27);
            this.qABindingNavigator.TabIndex = 0;
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // qABindingSource
            // 
            this.qABindingSource.DataMember = "QA";
            this.qABindingSource.DataSource = this.testDataDataSet1;
            // 
            // testDataDataSet1
            // 
            this.testDataDataSet1.DataSetName = "testDataDataSet1";
            this.testDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // qABindingNavigatorSaveItem
            // 
            this.qABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qABindingNavigatorSaveItem.Image")));
            this.qABindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.qABindingNavigatorSaveItem.Name = "qABindingNavigatorSaveItem";
            this.qABindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.qABindingNavigatorSaveItem.Text = "Save";
            this.qABindingNavigatorSaveItem.Click += new System.EventHandler(this.qABindingNavigatorSaveItem_Click);
            // 
            // askIdLabel
            // 
            this.askIdLabel.AutoSize = true;
            this.askIdLabel.Location = new System.Drawing.Point(48, 59);
            this.askIdLabel.Name = "askIdLabel";
            this.askIdLabel.Size = new System.Drawing.Size(60, 17);
            this.askIdLabel.TabIndex = 1;
            this.askIdLabel.Text = "Ask ID : ";
            // 
            // askLabel
            // 
            this.askLabel.AutoSize = true;
            this.askLabel.Location = new System.Drawing.Point(48, 142);
            this.askLabel.Name = "askLabel";
            this.askLabel.Size = new System.Drawing.Size(39, 17);
            this.askLabel.TabIndex = 2;
            this.askLabel.Text = "Ask :";
            // 
            // ans1Label
            // 
            this.ans1Label.AutoSize = true;
            this.ans1Label.Location = new System.Drawing.Point(48, 225);
            this.ans1Label.Name = "ans1Label";
            this.ans1Label.Size = new System.Drawing.Size(52, 17);
            this.ans1Label.TabIndex = 3;
            this.ans1Label.Text = "Ans 1 :";
            // 
            // ans2Label
            // 
            this.ans2Label.AutoSize = true;
            this.ans2Label.Location = new System.Drawing.Point(48, 308);
            this.ans2Label.Name = "ans2Label";
            this.ans2Label.Size = new System.Drawing.Size(48, 17);
            this.ans2Label.TabIndex = 4;
            this.ans2Label.Text = "Ans 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ans 3 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ans 4 :";
            // 
            // askIdTextBox
            // 
            this.askIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "AskId", true));
            this.askIdTextBox.Location = new System.Drawing.Point(134, 53);
            this.askIdTextBox.Name = "askIdTextBox";
            this.askIdTextBox.Size = new System.Drawing.Size(400, 22);
            this.askIdTextBox.TabIndex = 7;
            // 
            // askTextBox
            // 
            this.askTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ask", true));
            this.askTextBox.Location = new System.Drawing.Point(134, 136);
            this.askTextBox.Name = "askTextBox";
            this.askTextBox.Size = new System.Drawing.Size(400, 22);
            this.askTextBox.TabIndex = 8;
            // 
            // ans1TextBox
            // 
            this.ans1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ans1", true));
            this.ans1TextBox.Location = new System.Drawing.Point(134, 219);
            this.ans1TextBox.Name = "ans1TextBox";
            this.ans1TextBox.Size = new System.Drawing.Size(400, 22);
            this.ans1TextBox.TabIndex = 9;
            // 
            // ans2TextBox
            // 
            this.ans2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ans2", true));
            this.ans2TextBox.Location = new System.Drawing.Point(134, 302);
            this.ans2TextBox.Name = "ans2TextBox";
            this.ans2TextBox.Size = new System.Drawing.Size(400, 22);
            this.ans2TextBox.TabIndex = 10;
            // 
            // ans3TextBox
            // 
            this.ans3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ans3", true));
            this.ans3TextBox.Location = new System.Drawing.Point(134, 385);
            this.ans3TextBox.Name = "ans3TextBox";
            this.ans3TextBox.Size = new System.Drawing.Size(400, 22);
            this.ans3TextBox.TabIndex = 11;
            // 
            // ans4TextBox
            // 
            this.ans4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ans4", true));
            this.ans4TextBox.Location = new System.Drawing.Point(134, 468);
            this.ans4TextBox.Name = "ans4TextBox";
            this.ans4TextBox.Size = new System.Drawing.Size(400, 22);
            this.ans4TextBox.TabIndex = 12;
            // 
            // qATableAdapter
            // 
            this.qATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QATableAdapter = this.qATableAdapter;
            this.tableAdapterManager.UpdateOrder = winFormTester.testDataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(51, 527);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // tFormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 572);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.ans4TextBox);
            this.Controls.Add(this.ans3TextBox);
            this.Controls.Add(this.ans2TextBox);
            this.Controls.Add(this.ans1TextBox);
            this.Controls.Add(this.askTextBox);
            this.Controls.Add(this.askIdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ans2Label);
            this.Controls.Add(this.ans1Label);
            this.Controls.Add(this.askLabel);
            this.Controls.Add(this.askIdLabel);
            this.Controls.Add(this.qABindingNavigator);
            this.Name = "tFormInput";
            this.Text = "tFormInput";
            this.Load += new System.EventHandler(this.tFormInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qABindingNavigator)).EndInit();
            this.qABindingNavigator.ResumeLayout(false);
            this.qABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripButton qABindingNavigatorSaveItem;
        private System.Windows.Forms.Label askIdLabel;
        private System.Windows.Forms.Label askLabel;
        private System.Windows.Forms.Label ans1Label;
        private System.Windows.Forms.Label ans2Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox askIdTextBox;
        private System.Windows.Forms.TextBox askTextBox;
        private System.Windows.Forms.TextBox ans1TextBox;
        private System.Windows.Forms.TextBox ans2TextBox;
        private System.Windows.Forms.TextBox ans3TextBox;
        private System.Windows.Forms.TextBox ans4TextBox;
        private testDataDataSet1 testDataDataSet1;
        private System.Windows.Forms.BindingSource qABindingSource;
        private testDataDataSet1TableAdapters.QATableAdapter qATableAdapter;
        private testDataDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button resetBtn;
    }
}