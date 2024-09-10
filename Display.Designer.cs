namespace makeup
{
    partial class Display
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
            System.Windows.Forms.Label student_IDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label quiz_marksLabel;
            System.Windows.Forms.Label lab_test_marksLabel;
            System.Windows.Forms.Label lecture_test_marksLabel;
            System.Windows.Forms.Label research_project_marksLabel;
            System.Windows.Forms.Label fInals_project_marksLabel;
            System.Windows.Forms.Label averageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.reportDataSet = new makeup.reportDataSet();
            this.studentReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentReportTableAdapter = new makeup.reportDataSetTableAdapters.studentReportTableAdapter();
            this.tableAdapterManager = new makeup.reportDataSetTableAdapters.TableAdapterManager();
            this.studentReportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentReportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.comboBoxExam = new System.Windows.Forms.ComboBox();
            this.comboBoxMarks = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.student_IDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.quiz_marksTextBox = new System.Windows.Forms.TextBox();
            this.lab_test_marksTextBox = new System.Windows.Forms.TextBox();
            this.lecture_test_marksTextBox = new System.Windows.Forms.TextBox();
            this.research_project_marksTextBox = new System.Windows.Forms.TextBox();
            this.fInals_project_marksTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.studentReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            student_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            quiz_marksLabel = new System.Windows.Forms.Label();
            lab_test_marksLabel = new System.Windows.Forms.Label();
            lecture_test_marksLabel = new System.Windows.Forms.Label();
            research_project_marksLabel = new System.Windows.Forms.Label();
            fInals_project_marksLabel = new System.Windows.Forms.Label();
            averageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingNavigator)).BeginInit();
            this.studentReportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // student_IDLabel
            // 
            student_IDLabel.AutoSize = true;
            student_IDLabel.Location = new System.Drawing.Point(366, 85);
            student_IDLabel.Name = "student_IDLabel";
            student_IDLabel.Size = new System.Drawing.Size(78, 17);
            student_IDLabel.TabIndex = 21;
            student_IDLabel.Text = "Student ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(366, 113);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(80, 17);
            first_NameLabel.TabIndex = 23;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(366, 141);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(80, 17);
            last_NameLabel.TabIndex = 25;
            last_NameLabel.Text = "Last Name:";
            // 
            // quiz_marksLabel
            // 
            quiz_marksLabel.AutoSize = true;
            quiz_marksLabel.Location = new System.Drawing.Point(366, 169);
            quiz_marksLabel.Name = "quiz_marksLabel";
            quiz_marksLabel.Size = new System.Drawing.Size(83, 17);
            quiz_marksLabel.TabIndex = 27;
            quiz_marksLabel.Text = "Quiz marks:";
            // 
            // lab_test_marksLabel
            // 
            lab_test_marksLabel.AutoSize = true;
            lab_test_marksLabel.Location = new System.Drawing.Point(366, 197);
            lab_test_marksLabel.Name = "lab_test_marksLabel";
            lab_test_marksLabel.Size = new System.Drawing.Size(105, 17);
            lab_test_marksLabel.TabIndex = 29;
            lab_test_marksLabel.Text = "Lab test marks:";
            // 
            // lecture_test_marksLabel
            // 
            lecture_test_marksLabel.AutoSize = true;
            lecture_test_marksLabel.Location = new System.Drawing.Point(366, 225);
            lecture_test_marksLabel.Name = "lecture_test_marksLabel";
            lecture_test_marksLabel.Size = new System.Drawing.Size(129, 17);
            lecture_test_marksLabel.TabIndex = 31;
            lecture_test_marksLabel.Text = "Lecture test marks:";
            // 
            // research_project_marksLabel
            // 
            research_project_marksLabel.AutoSize = true;
            research_project_marksLabel.Location = new System.Drawing.Point(366, 253);
            research_project_marksLabel.Name = "research_project_marksLabel";
            research_project_marksLabel.Size = new System.Drawing.Size(162, 17);
            research_project_marksLabel.TabIndex = 33;
            research_project_marksLabel.Text = "Research project marks:";
            // 
            // fInals_project_marksLabel
            // 
            fInals_project_marksLabel.AutoSize = true;
            fInals_project_marksLabel.Location = new System.Drawing.Point(366, 281);
            fInals_project_marksLabel.Name = "fInals_project_marksLabel";
            fInals_project_marksLabel.Size = new System.Drawing.Size(138, 17);
            fInals_project_marksLabel.TabIndex = 35;
            fInals_project_marksLabel.Text = "FInals project marks:";
            // 
            // averageLabel
            // 
            averageLabel.AutoSize = true;
            averageLabel.Location = new System.Drawing.Point(366, 309);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new System.Drawing.Size(65, 17);
            averageLabel.TabIndex = 37;
            averageLabel.Text = "Average:";
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "reportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentReportBindingSource
            // 
            this.studentReportBindingSource.DataMember = "studentReport";
            this.studentReportBindingSource.DataSource = this.reportDataSet;
            // 
            // studentReportTableAdapter
            // 
            this.studentReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.studentReportTableAdapter = this.studentReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = makeup.reportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentReportBindingNavigator
            // 
            this.studentReportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentReportBindingNavigator.BindingSource = this.studentReportBindingSource;
            this.studentReportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentReportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentReportBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentReportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentReportBindingNavigatorSaveItem});
            this.studentReportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentReportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentReportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentReportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentReportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentReportBindingNavigator.Name = "studentReportBindingNavigator";
            this.studentReportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentReportBindingNavigator.Size = new System.Drawing.Size(745, 27);
            this.studentReportBindingNavigator.TabIndex = 0;
            this.studentReportBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // studentReportBindingNavigatorSaveItem
            // 
            this.studentReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentReportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentReportBindingNavigatorSaveItem.Image")));
            this.studentReportBindingNavigatorSaveItem.Name = "studentReportBindingNavigatorSaveItem";
            this.studentReportBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.studentReportBindingNavigatorSaveItem.Text = "Save Data";
            this.studentReportBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentReportBindingNavigatorSaveItem_Click_1);
            // 
            // comboBoxExam
            // 
            this.comboBoxExam.FormattingEnabled = true;
            this.comboBoxExam.Items.AddRange(new object[] {
            "Quiz",
            "Lab test",
            "Lecture Test",
            "Research Project",
            "Final Project"});
            this.comboBoxExam.Location = new System.Drawing.Point(101, 85);
            this.comboBoxExam.Name = "comboBoxExam";
            this.comboBoxExam.Size = new System.Drawing.Size(121, 24);
            this.comboBoxExam.TabIndex = 3;
            this.comboBoxExam.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxMarks
            // 
            this.comboBoxMarks.FormattingEnabled = true;
            this.comboBoxMarks.Items.AddRange(new object[] {
            "more than 80",
            "Less than 50",
            "between 60 and 70"});
            this.comboBoxMarks.Location = new System.Drawing.Point(101, 129);
            this.comboBoxMarks.Name = "comboBoxMarks";
            this.comboBoxMarks.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMarks.TabIndex = 4;
            this.comboBoxMarks.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarks_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.studentReportBindingSource;
            this.listBox1.DisplayMember = "Student ID";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(101, 244);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 21;
            // 
            // student_IDTextBox
            // 
            this.student_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentReportBindingSource, "Student ID", true));
            this.student_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reportDataSet, "studentReport.Student ID", true));
            this.student_IDTextBox.Location = new System.Drawing.Point(534, 82);
            this.student_IDTextBox.Name = "student_IDTextBox";
            this.student_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.student_IDTextBox.TabIndex = 22;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentReportBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(534, 110);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.first_NameTextBox.TabIndex = 24;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentReportBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(534, 138);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.last_NameTextBox.TabIndex = 26;
            // 
            // quiz_marksTextBox
            // 
            this.quiz_marksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentReportBindingSource, "Quiz marks", true));
            this.quiz_marksTextBox.Location = new System.Drawing.Point(534, 166);
            this.quiz_marksTextBox.Name = "quiz_marksTextBox";
            this.quiz_marksTextBox.Size = new System.Drawing.Size(100, 22);
            this.quiz_marksTextBox.TabIndex = 28;
            // 
            // lab_test_marksTextBox
            // 
            this.lab_test_marksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentReportBindingSource, "Lab test marks", true));
            this.lab_test_marksTextBox.Location = new System.Drawing.Point(534, 194);
            this.lab_test_marksTextBox.Name = "lab_test_marksTextBox";
            this.lab_test_marksTextBox.Size = new System.Drawing.Size(100, 22);
            this.lab_test_marksTextBox.TabIndex = 30;
            // 
            // lecture_test_marksTextBox
            // 
            this.lecture_test_marksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentReportBindingSource, "Lecture test marks", true));
            this.lecture_test_marksTextBox.Location = new System.Drawing.Point(534, 222);
            this.lecture_test_marksTextBox.Name = "lecture_test_marksTextBox";
            this.lecture_test_marksTextBox.Size = new System.Drawing.Size(100, 22);
            this.lecture_test_marksTextBox.TabIndex = 32;
            // 
            // research_project_marksTextBox
            // 
            this.research_project_marksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentReportBindingSource, "Research project marks", true));
            this.research_project_marksTextBox.Location = new System.Drawing.Point(534, 250);
            this.research_project_marksTextBox.Name = "research_project_marksTextBox";
            this.research_project_marksTextBox.Size = new System.Drawing.Size(100, 22);
            this.research_project_marksTextBox.TabIndex = 34;
            // 
            // fInals_project_marksTextBox
            // 
            this.fInals_project_marksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentReportBindingSource, "FInals project marks", true));
            this.fInals_project_marksTextBox.Location = new System.Drawing.Point(534, 278);
            this.fInals_project_marksTextBox.Name = "fInals_project_marksTextBox";
            this.fInals_project_marksTextBox.Size = new System.Drawing.Size(100, 22);
            this.fInals_project_marksTextBox.TabIndex = 36;
            // 
            // averageTextBox
            // 
            this.averageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentReportBindingSource, "Average", true));
            this.averageTextBox.Location = new System.Drawing.Point(534, 306);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(100, 22);
            this.averageTextBox.TabIndex = 38;
            // 
            // studentReportBindingSource1
            // 
            this.studentReportBindingSource1.DataMember = "studentReport";
            this.studentReportBindingSource1.DataSource = this.reportDataSet;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 430);
            this.Controls.Add(student_IDLabel);
            this.Controls.Add(this.student_IDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(quiz_marksLabel);
            this.Controls.Add(this.quiz_marksTextBox);
            this.Controls.Add(lab_test_marksLabel);
            this.Controls.Add(this.lab_test_marksTextBox);
            this.Controls.Add(lecture_test_marksLabel);
            this.Controls.Add(this.lecture_test_marksTextBox);
            this.Controls.Add(research_project_marksLabel);
            this.Controls.Add(this.research_project_marksTextBox);
            this.Controls.Add(fInals_project_marksLabel);
            this.Controls.Add(this.fInals_project_marksTextBox);
            this.Controls.Add(averageLabel);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxMarks);
            this.Controls.Add(this.comboBoxExam);
            this.Controls.Add(this.studentReportBindingNavigator);
            this.Name = "Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingNavigator)).EndInit();
            this.studentReportBindingNavigator.ResumeLayout(false);
            this.studentReportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private reportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource studentReportBindingSource;
        private reportDataSetTableAdapters.studentReportTableAdapter studentReportTableAdapter;
        private reportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentReportBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentReportBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox comboBoxExam;
        private System.Windows.Forms.ComboBox comboBoxMarks;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox student_IDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox quiz_marksTextBox;
        private System.Windows.Forms.TextBox lab_test_marksTextBox;
        private System.Windows.Forms.TextBox lecture_test_marksTextBox;
        private System.Windows.Forms.TextBox research_project_marksTextBox;
        private System.Windows.Forms.TextBox fInals_project_marksTextBox;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.BindingSource studentReportBindingSource1;
    }
}