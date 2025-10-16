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
        double prevBalance = 0, currentBalance = 0;
        string accountName = "";
        public frmWithdraw()
        {
            InitializeComponent();
        }

       

        private void frmWithdraw_Load(object sender, EventArgs e)
        {

        }

        private void txtAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Allow only one period
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                        prevBalance = Convert.ToDouble(reader["Balance"]);

                        MessageBox.Show($"Account Found!\nAccount Name: {accountName}\nCurrent Balance: {prevBalance}");
                    }
                    else
                    {
                        MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                    currentBalance = prevBalance;
                    lblCurrentBalance.Text = currentBalance.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
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

            if (withdrawAmount > prevBalance)
            {
                MessageBox.Show("Insufficient balance. Withdrawal failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double newBalance = prevBalance - withdrawAmount;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                string updateQuery = "UPDATE Customers SET Balance = @newBalance WHERE AccountNumber = @accNum";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@newBalance", newBalance);
                cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim());

                string insertQuery = "INSERT INTO Transactions(AccountNumber, TransactionType, Amount, PreviousBalance, NewBalance, TransactionDate) VALUES (@AccNum, 'Withdraw', @Amount, @PreviousBalance, @NewBalance, GETDATE())";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@AccNum", txtAccNum.Text.Trim());
                insertCmd.Parameters.AddWithValue("@Amount", withdrawAmount);
                insertCmd.Parameters.AddWithValue("@PreviousBalance", prevBalance);
                insertCmd.Parameters.AddWithValue("@NewBalance", newBalance);
               

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    insertCmd.ExecuteNonQuery();

                    lblCurrentBalance.Text = newBalance.ToString();
                    MessageBox.Show($"Withdrawal successful!\nNew Balance: {newBalance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
        
        private void clearItems()
        {
            lblCurrentBalance.Text = "0";
            txtAccNum.Text = txtWithdraw.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
