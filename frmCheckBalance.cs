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
    public partial class frmCheckBalance : Form
    {
       
        public frmCheckBalance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

                    if (reader.Read()) // Account exists
                    {
                        lblAccNum.Text = accNum;
                        lblResultName.Text = reader["Name"].ToString();
                        lblResultBalance.Text = Convert.ToDouble(reader["Balance"]).ToString("C2"); // format ₱1,000.00
                    }
                    else
                    {
                        MessageBox.Show("Account not found. Failed to view the account.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
        private void frmCheckBalance_Load(object sender, EventArgs e)
        {
            
            if (Session.UserLevel == "Admin")
            {
                panelCustomer.Visible = false;
                panelAdmin.Visible = true;
                panelAdmin.BringToFront();

            } else if (Session.UserLevel == "Customer")
            {
                panelCustomer.Visible = true;
                panelAdmin.Visible = false;
                panelCustomer.BringToFront();

                Customer cust = Session.CurrentCustomer;
                lblAccNumC.Text = cust.AccNum;
                lblAccNameC.Text = cust.Name;
                lblBalanceC.Text = cust.Balance.ToString("C2");
            } else
            {
                MessageBox.Show("User not found");
            }
            this.Refresh();
        }

        private void panelCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAccNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
