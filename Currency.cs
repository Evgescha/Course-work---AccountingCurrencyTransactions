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
    public partial class Currency : Form
    {
        public Currency()
        {
            InitializeComponent();
        }

        private void Currency_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        /// <summary>
        /// Метод закрытия формы. При закрытии открывает предыдущую форму
        /// </summary>
        /// <param name="sender">Dходящий объект</param>
        /// <param name="e">Входящее событие</param>
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
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Метод, разрешающий вставлять только определенный набор символы. Только текст
        /// </summary>
        /// <param name="sender">Входящий объект</param>
        /// <param name="e">Входящее событие</param>
        private void textBox_OnlyLetter(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8 && number != ' ') // буквы и клавиша BackSpace
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
            
        }
        private bool isFill()
        {
            if (textBox1.Text.Length < 1)
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
                    DataRowView row = (DataRowView)currencyYMBindingSource.AddNew();

                    row[1] = textBox1.Text;

                    currencyYMBindingSource.EndEdit();
                    this.currencyYMTableAdapter.Update(accountingCurrencyTransactionsDataSet);
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
                    dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                    currencyYMBindingSource.EndEdit();
                    this.currencyYMTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);

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
                    currencyYMBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    currencyYMBindingSource.EndEdit();
                    currencyYMTableAdapter.Update(accountingCurrencyTransactionsDataSet.currencyYM);
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
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Saver.Save(dataGridView1);
        }
    }
}
