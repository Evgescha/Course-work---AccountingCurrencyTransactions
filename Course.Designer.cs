namespace AccountingCurrencyTransactions
{
    partial class Course
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseYMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingCurrencyTransactionsDataSet = new AccountingCurrencyTransactions.AccountingCurrencyTransactionsDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.currencyYMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseYMTableAdapter = new AccountingCurrencyTransactions.AccountingCurrencyTransactionsDataSetTableAdapters.CourseYMTableAdapter();
            this.currencyYMTableAdapter = new AccountingCurrencyTransactions.AccountingCurrencyTransactionsDataSetTableAdapters.currencyYMTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseYMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingCurrencyTransactionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyYMBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.currencyDataGridViewTextBoxColumn,
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.courseYMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(234, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(392, 219);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 49;
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
            // ratioToTheDollarUnitDataGridViewTextBoxColumn
            // 
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn.DataPropertyName = "ratioToTheDollarUnit";
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn.HeaderText = "Отношение 1 валюты к 1$";
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn.Name = "ratioToTheDollarUnitDataGridViewTextBoxColumn";
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratioToTheDollarUnitDataGridViewTextBoxColumn.Width = 136;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Валюта";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // courseYMBindingSource
            // 
            this.courseYMBindingSource.DataMember = "CourseYM";
            this.courseYMBindingSource.DataSource = this.accountingCurrencyTransactionsDataSet;
            // 
            // accountingCurrencyTransactionsDataSet
            // 
            this.accountingCurrencyTransactionsDataSet.DataSetName = "AccountingCurrencyTransactionsDataSet";
            this.accountingCurrencyTransactionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnlyNumbers);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "Отношение единицы валюты к одному доллару";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Валюта";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.currencyYMBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "id";
            // 
            // currencyYMBindingSource
            // 
            this.currencyYMBindingSource.DataMember = "currencyYM";
            this.currencyYMBindingSource.DataSource = this.accountingCurrencyTransactionsDataSet;
            // 
            // courseYMTableAdapter
            // 
            this.courseYMTableAdapter.ClearBeforeFill = true;
            // 
            // currencyYMTableAdapter
            // 
            this.currencyYMTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 237);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Course";
            this.Text = "Курс";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Position_FormClosing);
            this.Load += new System.EventHandler(this.Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseYMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingCurrencyTransactionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyYMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private AccountingCurrencyTransactionsDataSet accountingCurrencyTransactionsDataSet;
        private System.Windows.Forms.BindingSource courseYMBindingSource;
        private AccountingCurrencyTransactionsDataSetTableAdapters.CourseYMTableAdapter courseYMTableAdapter;
        private System.Windows.Forms.BindingSource currencyYMBindingSource;
        private AccountingCurrencyTransactionsDataSetTableAdapters.currencyYMTableAdapter currencyYMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratioToTheDollarUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button4;
    }
}