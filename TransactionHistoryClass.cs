using Azure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_C_
{
    public partial class TransactionHistoryClass : Form
    {
        private int userID;
        private Operations o = new Operations();

        public TransactionHistoryClass(int userId)
        {
            InitializeComponent();
            this.userID = userId;
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {

            var trans = o.GetUserAccountTransactions(userID);

            dgv_display.DataSource = trans;
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addTransactionForm = new AddTransactions(userID, o);
            addTransactionForm.ShowDialog();

            LoadTransactionHistory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv_display.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Please select a transaction to update.");
                return;
            }

            int transactionId = (int)selectedRow.Cells["TransactionId"].Value;
            var updateTransactionForm = new AddTransactions(userID, o, transactionId);
            updateTransactionForm.ShowDialog();

            LoadTransactionHistory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv_display.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Please select a transaction to delete.");
                return;
            }

            int transactionId = (int)selectedRow.Cells["TransactionId"].Value;
            o.DeleteTransaction(transactionId);


            LoadTransactionHistory();
        }
    }
}
