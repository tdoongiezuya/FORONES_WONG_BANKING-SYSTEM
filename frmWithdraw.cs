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
    public partial class frmWithdraw : Form
    {
        double currentBalance = 0;
        string accountName = "";
        public frmWithdraw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accNum = txtAccNum.Text.Trim();

            if (string.IsNullOrEmpty(accNum))
            {
                MessageBox.Show("Please enter an account number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                string query = "SELECT Name, Balance FROM Customers WHERE AccountNumber = @accNum";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNum", accNum);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        accountName = reader["Name"].ToString();
                        currentBalance = Convert.ToDouble(reader["Balance"]);

                        lblResultName.Text = accountName;
                        lblResultBalance.Text = "₱" + currentBalance.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblResultName.Text = "";
                        lblResultBalance.Text = "";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(accountName))
            {
                MessageBox.Show("Please search for an existing account first.");
                return;
            }

            if (!double.TryParse(txtWithdraw.Text.Trim(), out double withdrawAmount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (withdrawAmount <= 0)
            {
                MessageBox.Show("Amount must be greater than 0.");
                return;
            }

            if (withdrawAmount > currentBalance)
            {
                MessageBox.Show("Insufficient balance. Withdrawal failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double newBalance = currentBalance - withdrawAmount;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                string updateQuery = "UPDATE Customers SET Balance = @newBalance WHERE AccountNumber = @accNum";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@newBalance", newBalance);
                cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim());

                string insertTransaction = "INSERT INTO Transactions (AccountNumber, Type, Amount, Date) VALUES (@accNum, 'Withdraw', @amount, @date)";
                SqlCommand cmd2 = new SqlCommand(insertTransaction, conn);
                cmd2.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim());
                cmd2.Parameters.AddWithValue("@amount", withdrawAmount);
                cmd2.Parameters.AddWithValue("@date", DateTime.Now);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Withdrawal successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblResultBalance.Text = "₱" + newBalance.ToString("N2");
                    txtWithdraw.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            txtAccNum.Clear();
            txtWithdraw.Clear();

            // Clear labels
            lblResultName.Text = "";
            lblResultBalance.Text = "";

            // Reset stored values
            accountName = "";
            currentBalance = 0;

            // Optional: set focus back to Account Number textbox
            txtAccNum.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmDashboard().Show();
            this.Hide();
        }
    }
}
