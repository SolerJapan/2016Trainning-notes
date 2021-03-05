namespace winFormTester
{
    partial class winFormTester2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winFormTester2));
            this.AskIdLabel = new System.Windows.Forms.Label();
            this.qAbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.qABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDatabaseDataSet = new winFormTester.testDatabaseDataSet();
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
            this.oTsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.AskLabel = new System.Windows.Forms.Label();
            this.Ans1Label = new System.Windows.Forms.Label();
            this.Ans2Label = new System.Windows.Forms.Label();
            this.Ans3Label = new System.Windows.Forms.Label();
            this.Ans4Label = new System.Windows.Forms.Label();
            this.AskIdText = new System.Windows.Forms.TextBox();
            this.askText = new System.Windows.Forms.TextBox();
            this.oRad1 = new System.Windows.Forms.RadioButton();
            this.oRad2 = new System.Windows.Forms.RadioButton();
            this.oRad3 = new System.Windows.Forms.RadioButton();
            this.oRad4 = new System.Windows.Forms.RadioButton();
            this.oBtnCheck = new System.Windows.Forms.Button();
            this.oLabCheck = new System.Windows.Forms.Label();
            this.qATableAdapter = new winFormTester.testDatabaseDataSetTableAdapters.QATableAdapter();
            this.tableAdapterManager = new winFormTester.testDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.qAbindingNavigator)).BeginInit();
            this.qAbindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AskIdLabel
            // 
            this.AskIdLabel.AutoSize = true;
            this.AskIdLabel.Location = new System.Drawing.Point(52, 76);
            this.AskIdLabel.Name = "AskIdLabel";
            this.AskIdLabel.Size = new System.Drawing.Size(53, 17);
            this.AskIdLabel.TabIndex = 0;
            this.AskIdLabel.Text = "ask Id :";
            // 
            // qAbindingNavigator
            // 
            this.qAbindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qAbindingNavigator.BindingSource = this.qABindingSource;
            this.qAbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qAbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qAbindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.qAbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.qABindingNavigatorSaveItem,
            this.oTsBtnEdit});
            this.qAbindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qAbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qAbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qAbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qAbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qAbindingNavigator.Name = "qAbindingNavigator";
            this.qAbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qAbindingNavigator.Size = new System.Drawing.Size(736, 27);
            this.qAbindingNavigator.TabIndex = 1;
            this.qAbindingNavigator.Text = "bindingNavigator";
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
            // qABindingSource
            // 
            this.qABindingSource.DataMember = "QA";
            this.qABindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // testDatabaseDataSet
            // 
            this.testDatabaseDataSet.DataSetName = "testDatabaseDataSet";
            this.testDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.qABindingNavigatorSaveItem.Text = "Save Data";
            this.qABindingNavigatorSaveItem.Click += new System.EventHandler(this.qABindingNavigatorSaveItem_Click_1);
            // 
            // oTsBtnEdit
            // 
            this.oTsBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oTsBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("oTsBtnEdit.Image")));
            this.oTsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.oTsBtnEdit.Name = "oTsBtnEdit";
            this.oTsBtnEdit.Size = new System.Drawing.Size(24, 24);
            this.oTsBtnEdit.Text = "Edit";
            this.oTsBtnEdit.Click += new System.EventHandler(this.oTsBtnEdit_Click);
            // 
            // AskLabel
            // 
            this.AskLabel.AutoSize = true;
            this.AskLabel.Location = new System.Drawing.Point(52, 152);
            this.AskLabel.Name = "AskLabel";
            this.AskLabel.Size = new System.Drawing.Size(38, 17);
            this.AskLabel.TabIndex = 2;
            this.AskLabel.Text = "ask :";
            // 
            // Ans1Label
            // 
            this.Ans1Label.AutoSize = true;
            this.Ans1Label.Location = new System.Drawing.Point(52, 276);
            this.Ans1Label.Name = "Ans1Label";
            this.Ans1Label.Size = new System.Drawing.Size(48, 17);
            this.Ans1Label.TabIndex = 3;
            this.Ans1Label.Text = "Ans1 :";
            // 
            // Ans2Label
            // 
            this.Ans2Label.AutoSize = true;
            this.Ans2Label.Location = new System.Drawing.Point(52, 353);
            this.Ans2Label.Name = "Ans2Label";
            this.Ans2Label.Size = new System.Drawing.Size(48, 17);
            this.Ans2Label.TabIndex = 4;
            this.Ans2Label.Text = "Ans2 :";
            // 
            // Ans3Label
            // 
            this.Ans3Label.AutoSize = true;
            this.Ans3Label.Location = new System.Drawing.Point(52, 433);
            this.Ans3Label.Name = "Ans3Label";
            this.Ans3Label.Size = new System.Drawing.Size(48, 17);
            this.Ans3Label.TabIndex = 5;
            this.Ans3Label.Text = "Ans3 :";
            // 
            // Ans4Label
            // 
            this.Ans4Label.AutoSize = true;
            this.Ans4Label.Location = new System.Drawing.Point(52, 504);
            this.Ans4Label.Name = "Ans4Label";
            this.Ans4Label.Size = new System.Drawing.Size(48, 17);
            this.Ans4Label.TabIndex = 6;
            this.Ans4Label.Text = "Ans4 :";
            // 
            // AskIdText
            // 
            this.AskIdText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "AskId", true));
            this.AskIdText.Location = new System.Drawing.Point(152, 76);
            this.AskIdText.Name = "AskIdText";
            this.AskIdText.Size = new System.Drawing.Size(400, 22);
            this.AskIdText.TabIndex = 7;
            // 
            // askText
            // 
            this.askText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qABindingSource, "Ask", true));
            this.askText.Location = new System.Drawing.Point(152, 152);
            this.askText.Multiline = true;
            this.askText.Name = "askText";
            this.askText.Size = new System.Drawing.Size(400, 60);
            this.askText.TabIndex = 8;
            // 
            // oRad1
            // 
            this.oRad1.AutoSize = true;
            this.oRad1.Location = new System.Drawing.Point(152, 276);
            this.oRad1.Name = "oRad1";
            this.oRad1.Size = new System.Drawing.Size(110, 21);
            this.oRad1.TabIndex = 9;
            this.oRad1.TabStop = true;
            this.oRad1.Text = "radioButton1";
            this.oRad1.UseVisualStyleBackColor = true;
            // 
            // oRad2
            // 
            this.oRad2.AutoSize = true;
            this.oRad2.Location = new System.Drawing.Point(152, 353);
            this.oRad2.Name = "oRad2";
            this.oRad2.Size = new System.Drawing.Size(110, 21);
            this.oRad2.TabIndex = 10;
            this.oRad2.TabStop = true;
            this.oRad2.Text = "radioButton2";
            this.oRad2.UseVisualStyleBackColor = true;
            // 
            // oRad3
            // 
            this.oRad3.AutoSize = true;
            this.oRad3.Location = new System.Drawing.Point(152, 433);
            this.oRad3.Name = "oRad3";
            this.oRad3.Size = new System.Drawing.Size(110, 21);
            this.oRad3.TabIndex = 11;
            this.oRad3.TabStop = true;
            this.oRad3.Text = "radioButton3";
            this.oRad3.UseVisualStyleBackColor = true;
            // 
            // oRad4
            // 
            this.oRad4.AutoSize = true;
            this.oRad4.Location = new System.Drawing.Point(152, 499);
            this.oRad4.Name = "oRad4";
            this.oRad4.Size = new System.Drawing.Size(110, 21);
            this.oRad4.TabIndex = 12;
            this.oRad4.TabStop = true;
            this.oRad4.Text = "radioButton4";
            this.oRad4.UseVisualStyleBackColor = true;
            // 
            // oBtnCheck
            // 
            this.oBtnCheck.Location = new System.Drawing.Point(152, 540);
            this.oBtnCheck.Name = "oBtnCheck";
            this.oBtnCheck.Size = new System.Drawing.Size(139, 41);
            this.oBtnCheck.TabIndex = 13;
            this.oBtnCheck.Text = "Check Answer";
            this.oBtnCheck.UseVisualStyleBackColor = true;
            this.oBtnCheck.Click += new System.EventHandler(this.oBtnCheck_Click);
            // 
            // oLabCheck
            // 
            this.oLabCheck.AutoSize = true;
            this.oLabCheck.Location = new System.Drawing.Point(363, 558);
            this.oLabCheck.Name = "oLabCheck";
            this.oLabCheck.Size = new System.Drawing.Size(0, 17);
            this.oLabCheck.TabIndex = 14;
            // 
            // qATableAdapter
            // 
            this.qATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QATableAdapter = this.qATableAdapter;
            this.tableAdapterManager.UpdateOrder = winFormTester.testDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // winFormTester2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(736, 604);
            this.Controls.Add(this.oLabCheck);
            this.Controls.Add(this.oBtnCheck);
            this.Controls.Add(this.oRad4);
            this.Controls.Add(this.oRad3);
            this.Controls.Add(this.oRad2);
            this.Controls.Add(this.oRad1);
            this.Controls.Add(this.askText);
            this.Controls.Add(this.AskIdText);
            this.Controls.Add(this.Ans4Label);
            this.Controls.Add(this.Ans3Label);
            this.Controls.Add(this.Ans2Label);
            this.Controls.Add(this.Ans1Label);
            this.Controls.Add(this.AskLabel);
            this.Controls.Add(this.qAbindingNavigator);
            this.Controls.Add(this.AskIdLabel);
            this.Name = "winFormTester2";
            this.Text = "Tester";
            this.Load += new System.EventHandler(this.winFormTester2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qAbindingNavigator)).EndInit();
            this.qAbindingNavigator.ResumeLayout(false);
            this.qAbindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AskIdLabel;
        private System.Windows.Forms.BindingNavigator qAbindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oTsBtnEdit;
        private System.Windows.Forms.Label AskLabel;
        private System.Windows.Forms.Label Ans1Label;
        private System.Windows.Forms.Label Ans2Label;
        private System.Windows.Forms.Label Ans3Label;
        private System.Windows.Forms.Label Ans4Label;
        private System.Windows.Forms.TextBox AskIdText;
        private System.Windows.Forms.TextBox askText;
        private System.Windows.Forms.RadioButton oRad1;
        private System.Windows.Forms.RadioButton oRad2;
        private System.Windows.Forms.RadioButton oRad3;
        private System.Windows.Forms.RadioButton oRad4;
        private System.Windows.Forms.Button oBtnCheck;
        private System.Windows.Forms.Label oLabCheck;
        private testDatabaseDataSet testDatabaseDataSet;
        private System.Windows.Forms.BindingSource qABindingSource;
        private testDatabaseDataSetTableAdapters.QATableAdapter qATableAdapter;
        private testDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

