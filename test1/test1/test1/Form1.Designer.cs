namespace test1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stopWordsDataSet = new test1.StopWordsDataSet();
            this.stopWordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stopWordsTableAdapter = new test1.StopWordsDataSetTableAdapters.StopWordsTableAdapter();
            this.tableAdapterManager = new test1.StopWordsDataSetTableAdapters.TableAdapterManager();
            this.stopWordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stopWordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stopWordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_entry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.add_word = new System.Windows.Forms.TextBox();
            this.database_manipulation = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.update_entry = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.update_frequency = new System.Windows.Forms.TextBox();
            this.update_word = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.search_entry = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.search_word = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remove_entry = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_word = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.scan_files = new System.Windows.Forms.Button();
            this.select_folder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stopWordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopWordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopWordsBindingNavigator)).BeginInit();
            this.stopWordsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopWordsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.database_manipulation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopWordsDataSet
            // 
            this.stopWordsDataSet.DataSetName = "StopWordsDataSet";
            this.stopWordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stopWordsBindingSource
            // 
            this.stopWordsBindingSource.DataMember = "StopWords";
            this.stopWordsBindingSource.DataSource = this.stopWordsDataSet;
            // 
            // stopWordsTableAdapter
            // 
            this.stopWordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StopWordsTableAdapter = this.stopWordsTableAdapter;
            this.tableAdapterManager.UpdateOrder = test1.StopWordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stopWordsBindingNavigator
            // 
            this.stopWordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stopWordsBindingNavigator.BindingSource = this.stopWordsBindingSource;
            this.stopWordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stopWordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stopWordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stopWordsBindingNavigatorSaveItem});
            this.stopWordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stopWordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stopWordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stopWordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stopWordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stopWordsBindingNavigator.Name = "stopWordsBindingNavigator";
            this.stopWordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stopWordsBindingNavigator.Size = new System.Drawing.Size(816, 25);
            this.stopWordsBindingNavigator.TabIndex = 0;
            this.stopWordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // stopWordsBindingNavigatorSaveItem
            // 
            this.stopWordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopWordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stopWordsBindingNavigatorSaveItem.Image")));
            this.stopWordsBindingNavigatorSaveItem.Name = "stopWordsBindingNavigatorSaveItem";
            this.stopWordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stopWordsBindingNavigatorSaveItem.Text = "Save Data";
            this.stopWordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.stopWordsBindingNavigatorSaveItem_Click);
            // 
            // stopWordsDataGridView
            // 
            this.stopWordsDataGridView.AutoGenerateColumns = false;
            this.stopWordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stopWordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.stopWordsDataGridView.DataSource = this.stopWordsBindingSource;
            this.stopWordsDataGridView.Location = new System.Drawing.Point(25, 28);
            this.stopWordsDataGridView.Name = "stopWordsDataGridView";
            this.stopWordsDataGridView.Size = new System.Drawing.Size(389, 183);
            this.stopWordsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "word";
            this.dataGridViewTextBoxColumn1.HeaderText = "word";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Frequency";
            this.dataGridViewTextBoxColumn2.HeaderText = "Frequency";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_entry);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.add_word);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Stop Word";
            // 
            // add_entry
            // 
            this.add_entry.Location = new System.Drawing.Point(6, 57);
            this.add_entry.Name = "add_entry";
            this.add_entry.Size = new System.Drawing.Size(339, 23);
            this.add_entry.TabIndex = 4;
            this.add_entry.Text = "Add Stop Word";
            this.add_entry.UseVisualStyleBackColor = true;
            this.add_entry.Click += new System.EventHandler(this.add_entry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Word:";
            // 
            // add_word
            // 
            this.add_word.Location = new System.Drawing.Point(78, 19);
            this.add_word.Name = "add_word";
            this.add_word.Size = new System.Drawing.Size(265, 20);
            this.add_word.TabIndex = 0;
            // 
            // database_manipulation
            // 
            this.database_manipulation.Controls.Add(this.groupBox3);
            this.database_manipulation.Controls.Add(this.groupBox4);
            this.database_manipulation.Controls.Add(this.groupBox2);
            this.database_manipulation.Controls.Add(this.groupBox1);
            this.database_manipulation.Location = new System.Drawing.Point(25, 217);
            this.database_manipulation.Name = "database_manipulation";
            this.database_manipulation.Size = new System.Drawing.Size(389, 420);
            this.database_manipulation.TabIndex = 4;
            this.database_manipulation.TabStop = false;
            this.database_manipulation.Text = "Database Manipulation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.update_entry);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.update_frequency);
            this.groupBox3.Controls.Add(this.update_word);
            this.groupBox3.Location = new System.Drawing.Point(15, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 95);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Stop Word Frequency";
            // 
            // update_entry
            // 
            this.update_entry.Location = new System.Drawing.Point(9, 60);
            this.update_entry.Name = "update_entry";
            this.update_entry.Size = new System.Drawing.Size(336, 23);
            this.update_entry.TabIndex = 4;
            this.update_entry.Text = "Update Frequency";
            this.update_entry.UseVisualStyleBackColor = true;
            this.update_entry.Click += new System.EventHandler(this.update_entry_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "New Frequency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Word:";
            // 
            // update_frequency
            // 
            this.update_frequency.Location = new System.Drawing.Point(243, 22);
            this.update_frequency.Name = "update_frequency";
            this.update_frequency.Size = new System.Drawing.Size(100, 20);
            this.update_frequency.TabIndex = 1;
            // 
            // update_word
            // 
            this.update_word.Location = new System.Drawing.Point(78, 22);
            this.update_word.Name = "update_word";
            this.update_word.Size = new System.Drawing.Size(66, 20);
            this.update_word.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.search_entry);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.search_word);
            this.groupBox4.Location = new System.Drawing.Point(6, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 102);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query Stop Word";
            // 
            // search_entry
            // 
            this.search_entry.Location = new System.Drawing.Point(11, 54);
            this.search_entry.Name = "search_entry";
            this.search_entry.Size = new System.Drawing.Size(334, 23);
            this.search_entry.TabIndex = 4;
            this.search_entry.Text = "Check if Stop Word Exists";
            this.search_entry.UseVisualStyleBackColor = true;
            this.search_entry.Click += new System.EventHandler(this.search_entry_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Word:";
            // 
            // search_word
            // 
            this.search_word.Location = new System.Drawing.Point(78, 19);
            this.search_word.Name = "search_word";
            this.search_word.Size = new System.Drawing.Size(265, 20);
            this.search_word.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remove_entry);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.delete_word);
            this.groupBox2.Location = new System.Drawing.Point(6, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 81);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Stop Word";
            // 
            // remove_entry
            // 
            this.remove_entry.Location = new System.Drawing.Point(9, 52);
            this.remove_entry.Name = "remove_entry";
            this.remove_entry.Size = new System.Drawing.Size(336, 23);
            this.remove_entry.TabIndex = 4;
            this.remove_entry.Text = "Remove Stop Word";
            this.remove_entry.UseVisualStyleBackColor = true;
            this.remove_entry.Click += new System.EventHandler(this.remove_entry_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Word:";
            // 
            // delete_word
            // 
            this.delete_word.Location = new System.Drawing.Point(78, 19);
            this.delete_word.Name = "delete_word";
            this.delete_word.Size = new System.Drawing.Size(265, 20);
            this.delete_word.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.browse_button);
            this.groupBox5.Controls.Add(this.scan_files);
            this.groupBox5.Controls.Add(this.select_folder);
            this.groupBox5.Location = new System.Drawing.Point(430, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(358, 95);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Folder";
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(277, 17);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 23);
            this.browse_button.TabIndex = 6;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // scan_files
            // 
            this.scan_files.Location = new System.Drawing.Point(13, 46);
            this.scan_files.Name = "scan_files";
            this.scan_files.Size = new System.Drawing.Size(339, 23);
            this.scan_files.TabIndex = 5;
            this.scan_files.Text = "Scan Files";
            this.scan_files.UseVisualStyleBackColor = true;
            this.scan_files.Click += new System.EventHandler(this.scan_files_Click);
            // 
            // select_folder
            // 
            this.select_folder.Location = new System.Drawing.Point(24, 19);
            this.select_folder.Name = "select_folder";
            this.select_folder.Size = new System.Drawing.Size(232, 20);
            this.select_folder.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(430, 129);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(386, 504);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Array List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 35);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(307, 147);
            this.listBox1.TabIndex = 44;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox6);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.button5);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.textBox5);
            this.groupBox9.Location = new System.Drawing.Point(10, 302);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(361, 157);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Display Frequency";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(78, 98);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(264, 20);
            this.textBox6.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Frequency:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(339, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Display Frequency of Word";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Word:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(78, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(265, 20);
            this.textBox5.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button4);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.textBox4);
            this.groupBox8.Location = new System.Drawing.Point(192, 207);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(176, 89);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Remove Frequent Word";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove form ArrayList";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Word:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 20);
            this.textBox4.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Location = new System.Drawing.Point(10, 201);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(176, 89);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Add Frequent Word";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add Word to ArrayList";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Word:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Most Frequent Terms:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 668);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.database_manipulation);
            this.Controls.Add(this.stopWordsDataGridView);
            this.Controls.Add(this.stopWordsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stopWordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopWordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopWordsBindingNavigator)).EndInit();
            this.stopWordsBindingNavigator.ResumeLayout(false);
            this.stopWordsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopWordsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.database_manipulation.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StopWordsDataSet stopWordsDataSet;
        private System.Windows.Forms.BindingSource stopWordsBindingSource;
        private StopWordsDataSetTableAdapters.StopWordsTableAdapter stopWordsTableAdapter;
        private StopWordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stopWordsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stopWordsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView stopWordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_entry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox add_word;
        private System.Windows.Forms.GroupBox database_manipulation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button update_entry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox update_frequency;
        private System.Windows.Forms.TextBox update_word;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button search_entry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox search_word;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button remove_entry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox delete_word;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Button scan_files;
        private System.Windows.Forms.TextBox select_folder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}

