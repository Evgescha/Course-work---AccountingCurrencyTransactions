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
    public partial class AccauntingTransaction : Form
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public AccauntingTransaction()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, срабадывающий при загрузке формы на экран. Обновляет все таблицы и выпадающие списки
        /// </summary>
        /// <param name="sender">Входящий объект</param>
        /// <param name="e">Аргументы события</param>
        private void AccauntingTransaction_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        /// <summary>
        /// Метод, выводящий предыдущую форму при закрытии текущей
        /// </summary>
        /// <param name="sender">Входящий объект</param>
        /// <param name="e">Аргументы события</param>
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
        /// Метод заполнение таблицы данными из бд
        /// </summary>
        private void fillGrid()
        {
            this.courseYMTableAdapter.Fill(this.accountingCurrencyTransactionsDataSet.CourseYM);
            this.typeOperationYMTableAdapter.Fill(this.accountingCurrencyTransactionsDataSet.typeOperationYM);
            this.currencyYMTableAdapter.Fill(this.accountingCurrencyTransactionsDataSet.currencyYM);
            this.accountingForTransactionsYMTableAdapter.Fill(this.accountingCurrencyTransactionsDataSet.AccountingForTransactionsYM);
            fixName();
        }
        /// <summary>
        /// Метод проверки полей на заполнение
        /// </summary>
        /// <returns></returns>
        private bool isFill()
        {
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Не все поля заполнены!");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод очистки полей
        /// </summary>
        private void clearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        //add
        /// <summary>
        /// Метод добавления значения а базу данных. Он получает все значения из введенных полей и выбранных выпадающий списков и вносит в новую строку таблицы
        /// После добавление данных в таблицу идет перезагрузка таблиц и списков формы
        /// </summary>
        /// <param name="sender">Входящий объект</param>
        /// <param name="e">Аргументы события</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    DataRowView row = (DataRowView)accountingForTransactionsYMBindingSource.AddNew();

                    row[1] = dateTimePicker1.Value;
                    row[2] = comboBox1.SelectedValue;
                    row[3] = textBox1.Text;
                    row[4] = comboBox2.SelectedValue;
                    row[5] = textBox2.Text;

                    accountingForTransactionsYMBindingSource.EndEdit();
                    this.accountingForTransactionsYMTableAdapter.Update(accountingCurrencyTransactionsDataSet);
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            fillGrid();
        }
        //edit
        /// <summary>
        /// Метод редактирования данных в базе данных. К выбранной записи обновляются соответствующие поля, после чего ижет сохранение изменений в базе данных
        /// После изменений обновляются все таблицы и выпадающие списки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    dataGridView1.CurrentRow.Cells[1].Value = dateTimePicker1.Value;
                    dataGridView1.CurrentRow.Cells[2].Value = comboBox1.SelectedValue;
                    dataGridView1.CurrentRow.Cells[4].Value = textBox1.Text;
                    dataGridView1.CurrentRow.Cells[5].Value = comboBox2.SelectedValue;
                    dataGridView1.CurrentRow.Cells[7].Value = textBox2.Text;

                    accountingForTransactionsYMBindingSource.EndEdit();
                    this.accountingForTransactionsYMTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);

                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            fillGrid();
        }

        //delete
        /// <summary>
        /// Метод удаления данных  из базы данных
        /// Берется ид выбранной записи и удаляется из бд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                try
                {
                    accountingCurrencyTransactionsDataSet.AcceptChanges();
                    accountingForTransactionsYMBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    accountingForTransactionsYMBindingSource.EndEdit();
                    accountingForTransactionsYMTableAdapter.Update(accountingCurrencyTransactionsDataSet.AccountingForTransactionsYM);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                fillGrid();
            }
        }

        /// <summary>
        /// Метод вывода данных выбранной записи из таблицы в формы приложения. Так, при каждом нажатии на запись в таблице, метод получает данные из нее и в каждое поле заполняется значением из соответствующего столбца.
        /// </summary>
        /// <param name="sender">Входящий объект</param>
        /// <param name="e">Аргументы события</param>
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox2.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
        }
        /// <summary>
        /// Метод, исправляющий отобращение наименований из других таблиц. 
        /// Походу в базе данных идет работа по Ид, приходится эти ИД выводить в таблицу. 
        /// Чтобы пользвоатель понимал о чем речь, этот метод по Ид получает наименование записи в таблице и выводти его имя в таблицу
        /// </summary>
        private void fixName()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox1.SelectedItem = comboBox1.Items[
                                                           currencyYMBindingSource.Find(
                                                                       "id",
                                                                       int.Parse(dataGridView1[2, i].Value.ToString())
                                                                       )
                                                           ];
                dataGridView1[3, i].Value = comboBox1.Text;


                comboBox2.SelectedItem = comboBox2.Items[
                                                          typeOperationYMBindingSource.Find(
                                                                      "id",
                                                                      int.Parse(dataGridView1[5, i].Value.ToString())
                                                                      )
                                                          ];
                dataGridView1[6, i].Value = comboBox2.Text;
            }
        }
        /// <summary>
        /// Расчет значения Общей суммы
        /// </summary>
        private void setSumm() {
            textBox2.Text = "";
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (dataGridView2[1, i].Value.ToString().Equals(comboBox1.SelectedValue.ToString()))
                        {
                        double summ = double.Parse(dataGridView2[2, i].Value.ToString()) * int.Parse(textBox1.Text);
                        textBox2.Text = summ.ToString();
                    }
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
                MessageBox.Show("Не удается преобразовать количество валюты в число \n" +
                                "или не внесен курс отношения валюты к доллару");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) setSumm();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (textBox1.Text.Length > 0) setSumm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Saver.Save(dataGridView1);
        }
    }
}
