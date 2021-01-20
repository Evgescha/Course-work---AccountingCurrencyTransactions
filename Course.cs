using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingCurrencyTransactions
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        private void Position_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
        /// <summary>
        /// Метод, разрешающий вставлять только определенный набор символы. Только цифры
        /// </summary>
        /// <param name="sender">Входящий объект</param>
        /// <param name="e">Входящее событие</param>
        private void textBox_OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number!=',') // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
     

        /// <summary>
        /// Метод заполнение таблицы данными из бд
        /// </summary>
        private void fillGrid()
        {
            this.currencyYMTableAdapter.Fill(this.accountingCurrencyTransactionsDataSet.currencyYM);
            this.courseYMTableAdapter.Fill(this.accountingCurrencyTransactionsDataSet.CourseYM);
            fixName();
        }
        private bool isFill()
        {
            if (textBox1.Text.Length < 1 )
            {
                MessageBox.Show("Не все поля заполнены!");
                return false;
            }
            return true;
        }
        private void clearFields()
        {
            textBox1.Text = "";
        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    DataRowView row = (DataRowView)courseYMBindingSource.AddNew();

                    row[1] = comboBox1.SelectedValue;
                    row[2] = textBox1.Text;

                    courseYMBindingSource.EndEdit();
                    this.courseYMTableAdapter.Update(accountingCurrencyTransactionsDataSet);
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            fillGrid();
        }
        //edit
        private void button2_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    dataGridView1.CurrentRow.Cells[1].Value = comboBox1.SelectedValue;
                    dataGridView1.CurrentRow.Cells[2].Value = textBox1.Text;
                    courseYMBindingSource.EndEdit();
                    this.courseYMTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);

                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            fillGrid();
        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                try
                {
                    accountingCurrencyTransactionsDataSet.AcceptChanges();
                    courseYMBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    courseYMBindingSource.EndEdit();
                    courseYMTableAdapter.Update(accountingCurrencyTransactionsDataSet.CourseYM);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                fillGrid();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }
        private void fixName()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox1.SelectedItem = comboBox1.Items[
                                                           currencyYMBindingSource.Find(
                                                                       "id",
                                                                       int.Parse(dataGridView1[1, i].Value.ToString())
                                                                       )
                                                           ];
                dataGridView1[3, i].Value = comboBox1.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Saver.Save(dataGridView1);
        }
    }
}
