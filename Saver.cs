using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingCurrencyTransactions
{
    class Saver
    {
        public static void Save(DataGridView dataGridView1) {
            try
            {
                int rowCounter = dataGridView1.RowCount;
                int columnCount = dataGridView1.ColumnCount;
                string[] line = new string[columnCount];
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                if (dataGridView1.Rows[i].Cells[j].Value != null)
                                    line[j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                            writer.WriteLine(string.Join(";", line));
                        }
                        writer.Flush();
                        MessageBox.Show("Сохранено!");
                    }

                }
            }
            catch (Exception e) {
                MessageBox.Show("Ошибка сохранения\n"+e.Message);
            }
        
        }
    }
}
