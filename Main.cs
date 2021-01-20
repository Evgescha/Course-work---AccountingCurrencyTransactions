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
    public partial class Main : Form
    {
        public static Main main;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            main = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Currency().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TypeOperation().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Course().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AccauntingTransaction().Show();
            this.Hide();
        }
    }
}
