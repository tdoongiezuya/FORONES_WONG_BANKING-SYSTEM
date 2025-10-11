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
                        lblResultName.Text = reader["Name"].ToString();
                        lblResultBalance.Text = Convert.ToDouble(reader["Balance"]).ToString("C2"); // format ₱1,000.00
                    }
                    else
                    {
                        MessageBox.Show("Account not found. Failed to view the account.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblResultName.Text = "";
                        lblResultBalance.Text = "";
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
            new frmDashboard().Show();
            this.Hide();
        }
    }
}
