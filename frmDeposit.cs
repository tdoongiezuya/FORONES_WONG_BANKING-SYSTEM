using System;
using System.Collections;
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
        string customerID, accNum;

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            if (Session.UserLevel == "Customer")
            {   
                panelAccNum.Visible = false;

                Customer cust = Session.CurrentCustomer;
                if (cust != null)
                {
                    prevBalance = cust.Balance;
                    customerID = cust.CustomerID;
                    accNum = cust.AccNum;
                }
                

            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearItems();
        }

        private void clearItems()
        {
            txt1000.Text = txt500.Text = txt200.Text = txt100.Text = txt50.Text = txt20.Text = txt10.Text = txt5.Text = txt1.Text = "0";
            txtAccNum.Text = txtDepositAmount.Text= "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAcc_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
               
                string query = "SELECT Balance,CustomerID,AccountNumber FROM Customers WHERE AccountNumber=@accNum";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    prevBalance = Convert.ToDouble(reader["Balance"]);
                    customerID = reader["CustomerID"].ToString();
                    accNum = reader["AccountNumber"].ToString();

                    MessageBox.Show($"Account Found!\nCustomer ID: {customerID}\nCurrent Balance: {prevBalance}");
                }
                else
                {
                    MessageBox.Show("Account Number not found.");
                }

                reader.Close();

            }
            
        }

        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelAccNum_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            depositAmount = string.IsNullOrWhiteSpace(txtDepositAmount.Text) || !double.TryParse(txtDepositAmount.Text, out double amount) ? 0 : Convert.ToDouble(txtDepositAmount.Text);
             

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Please search for an existing account first.");
                return;
            }
            updateBalance();

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

        private void Computation_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown txt = sender as NumericUpDown;


            q1000 = Convert.ToInt32(txt1000.Value) * 1000;
            q500 = Convert.ToInt32(txt500.Value) * 500;
            q200 = Convert.ToInt32(txt200.Value) * 200;
            q100 = Convert.ToInt32(txt100.Value) * 100;
            q50 = Convert.ToInt32(txt50.Value) * 50;
            q10 = Convert.ToInt32(txt10.Value) * 10;
            q20 = Convert.ToInt32(txt20.Value) * 20;
            q5 = Convert.ToInt32(txt5.Value) * 5;
            q1 = Convert.ToInt32(txt1.Value) * 1;

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
            // Allow only one period
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }


        private void updateBalance()
        {
            newBalance = prevBalance + depositAmount;
            if (total == Math.Truncate(depositAmount) && depositAmount > 0)
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string updateQuery = "UPDATE Customers SET Balance=@newBalance where CustomerID=@CustomerID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@newBalance", newBalance);
                    updateCmd.Parameters.AddWithValue("@CustomerID", customerID);
                    updateCmd.ExecuteNonQuery();

                    string insertQuery = "INSERT INTO Transactions(AccountNumber, TransactionType, Amount, PreviousBalance, NewBalance, TransactionDate) VALUES (@AccNum, 'Deposit', @Amount, @PreviousBalance, @NewBalance, GETDATE())";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@AccNum", accNum);
                    insertCmd.Parameters.AddWithValue("@Amount", depositAmount);
                    insertCmd.Parameters.AddWithValue("@PreviousBalance", prevBalance);
                    insertCmd.Parameters.AddWithValue("@NewBalance", newBalance);
                    insertCmd.ExecuteNonQuery();

                }
                MessageBox.Show($"Deposit Successful\nPrevbalance: {prevBalance}\nNewBalance: {newBalance}");
                clearItems();
            }
            else
            {
                MessageBox.Show($"Deposit Unsuccessful.\nThe amount to be deposited and total amount based on denominations should be equal and should be valid.\nDep amt : {depositAmount}, total: {total}, prev balance : {prevBalance}");
            }
        }




    }
}
