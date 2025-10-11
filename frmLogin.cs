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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WONG_BANKING
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim(), password = txtPassword.Text.Trim();

            if ((username.Equals("admin"))&&(password.Equals("admin")))
            {
                Session.UserLevel = "Admin";
                MessageBox.Show("Welcome, Admin!");
                new frmDashboard().Show();
                this.Hide();

                
            }
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                string query = "SELECT * FROM [dbo].[Customers] WHERE Email=@user AND AccountNumber=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
            else
            {
                try
                {
                    using (SqlConnection conn = DBHelper.GetConnection())
                    {
                        string query = "SELECT * FROM Customers WHERE Email=@user AND AccountNumber=@pass";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        MessageBox.Show($"Email: {username}\nPassword: {password}");
                        if (reader.Read()) //check if any record exists
                        {
                            Session.UserLevel = "Customer";
                            Customer customer = new Customer()
                            {
                                CustomerID = reader["CustomerID"].ToString(),
                                AccNum = reader["AccountNumber"].ToString(),
                                Name = reader["Name"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]),
                                Birthdate = reader["Birthdate"].ToString(),
                                Address = reader["Address"].ToString(),
                                CivilStatus = reader["CivilStatus"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                Email = reader["Email"].ToString(),
                                ImagePath = reader["ImagePath"].ToString(),
                                Balance = Convert.ToDouble(reader["Balance"])
                            };

                            Session.CurrentCustomer = customer;

                            MessageBox.Show($"Welcome, {customer.Name.Split(' ')[0]}!");

                            new frmDashboard().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Credentials.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception except)
                {
                    MessageBox.Show("DB Error found\n"+except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
            
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegistration().Show();
            this.Hide();
        }
    }
}
