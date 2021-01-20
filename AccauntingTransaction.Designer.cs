namespace AccountingCurrencyTransactions
{
    partial class AccauntingTransaction
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.accountingCurrencyTransactionsDataSet = new AccountingCurrencyTransactions.AccountingCurrencyTransactionsDataSet();
            this.accountingForTransactionsYMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingForTransactionsYMTableAdapter = new AccountingCurrencyTransactions.AccountingCurrencyTransactionsDataSetTableAdapters.AccountingForTransactionsYMTableAdapter();
            this.currencyYMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyYMTableAdapter = new AccountingCurrencyTransactions.AccountingCurrencyTransactionsDataSetTableAdapters.currencyYMTableAdapter();
            this.typeOperationYMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeOperationYMTableAdapter = new AccountingCurrencyTransactions.AccountingCurrencyTransactionsDataSetTableAdapters.typeOperationYMTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.courseYMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseYMTableAdapter = new AccountingCurrencyTransactions.AccountingCurrencyTransactionsDataSetTableAdapters.CourseYMTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingCurrencyTransactionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingForTransactionsYMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyYMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationYMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseYMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.currencyYMBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Валюта";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnlyNumbers);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Количество";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datesDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.Column1,
            this.countDataGridViewTextBoxColumn,
            this.typeOperationDataGridViewTextBoxColumn,
            this.Column2,
            this.summDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountingForTransactionsYMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(228, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(730, 360);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.typeOperationYMBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(96, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.ValueMember = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Операция";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Всего (в $)";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(96, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 33;
            // 
            // accountingCurrencyTransactionsDataSet
            // 
            this.accountingCurrencyTransactionsDataSet.DataSetName = "AccountingCurrencyTransactionsDataSet";
            this.accountingCurrencyTransactionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingForTransactionsYMBindingSource
            // 
            this.accountingForTransactionsYMBindingSource.DataMember = "AccountingForTransactionsYM";
            this.accountingForTransactionsYMBindingSource.DataSource = this.accountingCurrencyTransactionsDataSet;
            // 
            // accountingForTransactionsYMTableAdapter
            // 
            this.accountingForTransactionsYMTableAdapter.ClearBeforeFill = true;
            // 
            // currencyYMBindingSource
            // 
            this.currencyYMBindingSource.DataMember = "currencyYM";
            this.currencyYMBindingSource.DataSource = this.accountingCurrencyTransactionsDataSet;
            // 
            // currencyYMTableAdapter
            // 
            this.currencyYMTableAdapter.ClearBeforeFill = true;
            // 
            // typeOperationYMBindingSource
            // 
            this.typeOperationYMBindingSource.DataMember = "typeOperationYM";
            this.typeOperationYMBindingSource.DataSource = this.accountingCurrencyTransactionsDataSet;
            // 
            // typeOperationYMTableAdapter
            // 
            this.typeOperationYMTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.currencyDataGridViewTextBoxColumn1,
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.courseYMBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 233);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(210, 136);
            this.dataGridView2.TabIndex = 35;
            this.dataGridView2.Visible = false;
            // 
            // courseYMBindingSource
            // 
            this.courseYMBindingSource.DataMember = "CourseYM";
            this.courseYMBindingSource.DataSource = this.accountingCurrencyTransactionsDataSet;
            // 
            // courseYMTableAdapter
            // 
            this.courseYMTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // currencyDataGridViewTextBoxColumn1
            // 
            this.currencyDataGridViewTextBoxColumn1.DataPropertyName = "currency";
            this.currencyDataGridViewTextBoxColumn1.HeaderText = "currency";
            this.currencyDataGridViewTextBoxColumn1.Name = "currencyDataGridViewTextBoxColumn1";
            this.currencyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ratioToTheDollarUnitDataGridViewTextBoxColumn
            // 
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn.DataPropertyName = "ratioToTheDollarUnit";
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn.HeaderText = "ratioToTheDollarUnit";
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn.Name = "ratioToTheDollarUnitDataGridViewTextBoxColumn";
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 49;
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            this.datesDataGridViewTextBoxColumn.ReadOnly = true;
            this.datesDataGridViewTextBoxColumn.Width = 58;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Валюта";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyDataGridViewTextBoxColumn.Visible = false;
            this.currencyDataGridViewTextBoxColumn.Width = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Валюта";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество валюты";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 122;
            // 
            // typeOperationDataGridViewTextBoxColumn
            // 
            this.typeOperationDataGridViewTextBoxColumn.DataPropertyName = "typeOperation";
            this.typeOperationDataGridViewTextBoxColumn.HeaderText = "Тип операции";
            this.typeOperationDataGridViewTextBoxColumn.Name = "typeOperationDataGridViewTextBoxColumn";
            this.typeOperationDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeOperationDataGridViewTextBoxColumn.Visible = false;
            this.typeOperationDataGridViewTextBoxColumn.Width = 94;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Тип операции";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 94;
            // 
            // summDataGridViewTextBoxColumn
            // 
            this.summDataGridViewTextBoxColumn.DataPropertyName = "summ";
            this.summDataGridViewTextBoxColumn.HeaderText = "Всего";
            this.summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
            this.summDataGridViewTextBoxColumn.ReadOnly = true;
            this.summDataGridViewTextBoxColumn.Width = 62;
            // 
            // AccauntingTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 381);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "AccauntingTransaction";
            this.Text = "Учет операций";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Position_FormClosing);
            this.Load += new System.EventHandler(this.AccauntingTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingCurrencyTransactionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingForTransactionsYMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyYMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationYMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseYMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private AccountingCurrencyTransactionsDataSet accountingCurrencyTransactionsDataSet;
        private System.Windows.Forms.BindingSource accountingForTransactionsYMBindingSource;
        private AccountingCurrencyTransactionsDataSetTableAdapters.AccountingForTransactionsYMTableAdapter accountingForTransactionsYMTableAdapter;
        private System.Windows.Forms.BindingSource currencyYMBindingSource;
        private AccountingCurrencyTransactionsDataSetTableAdapters.currencyYMTableAdapter currencyYMTableAdapter;
        private System.Windows.Forms.BindingSource typeOperationYMBindingSource;
        private AccountingCurrencyTransactionsDataSetTableAdapters.typeOperationYMTableAdapter typeOperationYMTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource courseYMBindingSource;
        private AccountingCurrencyTransactionsDataSetTableAdapters.CourseYMTableAdapter courseYMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratioToTheDollarUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
    }
}