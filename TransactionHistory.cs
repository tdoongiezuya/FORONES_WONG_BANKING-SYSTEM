using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WONG_BANKING
{
    public partial class TransactionHistory : Form
    {
        string accountNumber;
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

            Customer cust = Session.CurrentCustomer;
            accountNumber = cust.AccNum;
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "SELECT * FROM Transactions WHERE AccountNumber = @AccNum";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AccNum", accountNumber);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    transactionsDataGridView.DataSource = dt;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("database error");
            }
            
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

                lblTransDate.Text = row.Cells[0].Value.ToString();
                lblTransType.Text = row.Cells[1].Value.ToString();
                lblAmount.Text = row.Cells[2].Value.ToString();
                lblPrevBalance.Text = row.Cells[3].Value.ToString();
                lblNewBalance.Text = row.Cells[4].Value.ToString();
                
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
