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
using System.Xml.Linq;

namespace WONG_BANKING
{
    public partial class frmDeposit : Form
    {
        int q1000, q500, q200, q100, q50, q20, q10, q5, q1, total;
        double depositAmount, newBalance, prevBalance;
        string customerID;

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            if (Session.UserLevel == "Customer")
            {
                lblAcc.Visible = false;
                txtAccNum.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt1000.Text = txt500.Text = txt200.Text = txt100.Text = txt50.Text = txt20.Text = txt10.Text = txt5.Text = txt1.Text = txtDepositAmount.Text = txtAccNum.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmDashboard().Show();
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            depositAmount = string.IsNullOrWhiteSpace(txtDepositAmount.Text) ? 0 : Convert.ToDouble(txtDepositAmount.Text);

            if (Session.UserLevel == "Admin")
            {

                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Checkpoint 4: DB connection opened");
                    string query = "SELECT Balance,CustomerID FROM Customers WHERE AccountNumber=@accNum";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                        prevBalance = Convert.ToDouble(reader["Balance"]);
                        customerID = reader["CustomerID"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Account Number not found.");
                    }

                    reader.Close();

                }
                updateBalance();
            }
            else if (Session.UserLevel == "Customer")
            {
                Customer cust = Session.CurrentCustomer;
                if (cust != null)
                {
                    prevBalance = cust.Balance;
                    customerID = cust.CustomerID;

                    updateBalance();
                }
            }
            else
            {
                MessageBox.Show("User level not detected.");
            }

        }

        public frmDeposit()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Computation_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            q1000 = string.IsNullOrWhiteSpace(txt1000.Text) ? 0 : Convert.ToInt32(txt1000.Text) * 1000;
            q500 = string.IsNullOrWhiteSpace(txt500.Text) ? 0 : Convert.ToInt32(txt500.Text) * 500;
            q200 = string.IsNullOrWhiteSpace(txt200.Text) ? 0 : Convert.ToInt32(txt200.Text) * 200;
            q100 = string.IsNullOrWhiteSpace(txt100.Text) ? 0 : Convert.ToInt32(txt100.Text) * 100;
            q50 = string.IsNullOrWhiteSpace(txt50.Text) ? 0 : Convert.ToInt32(txt50.Text) * 50;
            q10 = string.IsNullOrWhiteSpace(txt10.Text) ? 0 : Convert.ToInt32(txt10.Text) * 10;
            q20 = string.IsNullOrWhiteSpace(txt20.Text) ? 0 : Convert.ToInt32(txt20.Text) * 20;
            q5 = string.IsNullOrWhiteSpace(txt5.Text) ? 0 : Convert.ToInt32(txt5.Text) * 5;
            q1 = string.IsNullOrWhiteSpace(txt1.Text) ? 0 : Convert.ToInt32(txt1.Text) * 1;

            if (txt == txt1000) lbl1000.Text = q1000.ToString();
            else if (txt == txt500) lbl500.Text = q500.ToString();
            else if (txt == txt200) lbl200.Text = q200.ToString();
            else if (txt == txt100) lbl100.Text = q100.ToString();
            else if (txt == txt50) lbl50.Text = q50.ToString();
            else if (txt == txt20) lbl20.Text = q20.ToString();
            else if (txt == txt10) lbl10.Text = q10.ToString();
            else if (txt == txt5) lbl5.Text = q5.ToString();
            else if (txt == txt1) lbl1.Text = q1.ToString();

            total = q1000 + q500 + q200 + q100 + q50 + q20 + q10 + q5 + q1;

            lblTotal.Text = total.ToString();
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
        }


        private void updateBalance()
        {
            newBalance = prevBalance + depositAmount;
            if (total == Math.Truncate(depositAmount) && depositAmount > 1 && prevBalance > 1)
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string updateQuery = "UPDATE Customers SET Balance=@newBalance where CustomerID=@CustomerID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@newBalance", newBalance);
                    updateCmd.Parameters.AddWithValue("@CustomerID", customerID);
                    updateCmd.ExecuteNonQuery();

                    string insertQuery = "INSERT INTO Transactions(CustomerID, TransactionType, Amount, PreviousBalance, NewBalance, TransactionDate) VALUES (@CustomerID, 'Deposit', @Amount, @PreviousBalance, @NewBalance, GETDATE())";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@CustomerID", customerID);
                    insertCmd.Parameters.AddWithValue("@Amount", depositAmount);
                    insertCmd.Parameters.AddWithValue("@PreviousBalance", prevBalance);
                    insertCmd.Parameters.AddWithValue("@NewBalance", newBalance);
                    insertCmd.ExecuteNonQuery();

                }
                MessageBox.Show($"Deposit Successful\ncustomerId:{customerID}, Amount:{depositAmount}, Prevbalance: {prevBalance}, NewBalance: {newBalance}");
            }
            else
            {
                MessageBox.Show("Deposit Unsuccessful.\nThe amount to be deposited and total amount based on denominations should be equal and should have value");
            }
        }




    }
}
