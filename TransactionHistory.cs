using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WONG_BANKING
{
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
        {
            InitializeComponent();
        }

        private void transactionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.bankDBDataSet.Transactions);

        }

        private void transactionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void transactionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = transactionsDataGridView.Rows[e.RowIndex];

                lblTransType.Text = row.Cells[0].Value.ToString();
                lblAmount.Text = row.Cells[1].Value.ToString();
                lblPrevBalance.Text = row.Cells[2].Value.ToString();
                lblNewBalance.Text = row.Cells[3].Value.ToString();
                lblTransDate.Text = row.Cells[4].Value.ToString();
                
            }
        }
    }
}
