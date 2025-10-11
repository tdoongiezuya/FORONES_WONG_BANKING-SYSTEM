using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WONG_BANKING
{

    public partial class frmRegistration : Form
    {
        string gender, customer_id, accNum;
        int age;
        int currentYear = DateTime.Now.Year, count = 1;
       
        public frmRegistration()
        {
            InitializeComponent();
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            
            customerID_Generator();
            
            cboCivilStatus.SelectedIndex = 5;
            rbtNone.Checked = true;
            rbtNone.Visible = false;

        }

        private void frmRegistration_Click(object sender, EventArgs e)
        {
            new frmRegistration().ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            age = calculateAge(birthYear(dtpBdate.Text));
            
            
            if (validation(txtEmail.Text, txtAddress.Text, txtCNumber.Text, age, txtName.Text,txtInitialDeposit.Text))
            {

                if (rbtMale.Checked)
                {
                    gender = rbtMale.Text;
                }
                else if (rbtFemale.Checked)
                {
                    gender = rbtFemale.Text;
                }
                    
                accNumber_Gen();
                Customer cust = new Customer()
                {
                    CustomerID = txtCustomerID.Text,
                    Name = txtName.Text,
                    Gender = gender,
                    Age = age,
                    Birthdate = dtpBdate.Text,
                    Address = txtAddress.Text,
                    CivilStatus = cboCivilStatus.Text,
                    ContactNumber = txtCNumber.Text,
                    Email = txtEmail.Text,
                    ImagePath = pbProfile.ImageLocation,
                    AccNum = this.accNum,
                    Balance = Convert.ToDouble(txtInitialDeposit.Text)
                };

                //instance.Add(cust);

                cust.saveQuery();

                MessageBox.Show($"Registration Successful!\n\nACCOUNT NUMBER: {accNum}\nThe username will be the EMAIL, and your password will be the ACCOUNT NUMBER");
                clearItems();
                customerID_Generator();
                
            } else
            {
                MessageBox.Show("Invalid Input/s.");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearItems();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Session.UserLevel == "Admin" || Session.UserLevel == "Customer")
            {
                frmDashboard dashboard = new frmDashboard();
                dashboard.CurrentUserEmail = txtEmail.Text; // 👈 pass email from registration form
                dashboard.Show();
                this.Hide();
            } else
            {
                new frmLogin().Show();
                this.Hide();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Profile Picture";
            ofd.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp;*.gif ";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //show image
                pbProfile.Image = new Bitmap(ofd.FileName);
                pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                //get filename only
                string fileName = System.IO.Path.GetFileName(ofd.FileName);
                //go up 2 folders path
                string projPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, @"..\..\"));
                string imgFolder = System.IO.Path.Combine(projPath, "images");

                if (!System.IO.Directory.Exists(imgFolder))
                {
                    System.IO.Directory.CreateDirectory(imgFolder);
                }

                string imgPath = System.IO.Path.Combine(imgFolder, fileName);
                System.IO.File.Copy(ofd.FileName, imgPath, true);

                // set image loc to copied file
                pbProfile.ImageLocation = imgPath;
            }
        }

        private void clearItems()
        {
            txtName.Text = txtAddress.Text = txtEmail.Text = txtCNumber.Text = txtInitialDeposit.Text = "";
            rbtFemale.Checked = rbtMale.Checked = false;
            dtpBdate.Text = DateTime.Now.ToString();
            cboCivilStatus.SelectedIndex = 5;
            pbProfile.Image = null;
            rbtNone.Checked = true;
            
        }

        public int  calculateAge(int birthyear)
        {
            return  currentYear - birthyear;
        }

        public int birthYear(string date)
        {
            return Convert.ToInt32(date.Split(',')[1]);
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtCNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtInitialDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  e.KeyChar != '.') {
                e.Handled = true;
            }
        }

        private void txtInitialDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public bool validation(string email, string address, string cNumber, int age, string name, string initialDeposit)
        {
            errorProvider1.Clear();
            bool validEmail = true, validAddress = true, validCNumber = true, validAge = true, validName = true, validImage = true, validDeposit = true, validGender = true;

            string email_pattern = @"^[^@\s]+@[a-zA-Z]+\.[a-zA-Z]+$";
            string address_pattern = @"^[A-Za-z0-9.,\-\s]+$";
            string cNumber_pattern = "^[0-9]{11}$";
            
            if (!Regex.IsMatch(email, email_pattern))
            {
                errorProvider1.SetError(txtEmail, "must include @ and .");
                validEmail = false;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(txtName, "must not be empty");
                validEmail = false;
            }
            if(rbtNone.Checked == true)
            {
                errorProvider1.SetError(rbtFemale, "must choose gender");
                validGender = false;
            }
            if ( age < 1)
            {
                errorProvider1.SetError(dtpBdate, "age is lower than 1");
                validAge = false;
            }
            if (!Regex.IsMatch(address, address_pattern))
            {
                errorProvider1.SetError(txtAddress, "invalid address");
                validAddress=false;
            }
            if (!Regex.IsMatch(cNumber, cNumber_pattern))
            {
                errorProvider1.SetError(txtCNumber, "Invalid contact number. 11 digits only ");
                validCNumber = false;
            }
            if(pbProfile.Image == null)
            {
                errorProvider1.SetError(btnUpload, "Provide image");
                validImage = false;
            }
            if (pbProfile.Image == null)
            {
                errorProvider1.SetError(btnUpload, "Provide image");
                validImage = false;
            } 
            if (string.IsNullOrWhiteSpace(initialDeposit))
            {
                errorProvider1.SetError(txtInitialDeposit, "Your initial deposit should not be less than 500.");
                validDeposit = false;
            } else if (double.TryParse(initialDeposit, out double amount) || amount < 500)
            {
                errorProvider1.SetError(txtInitialDeposit, "Input valid Deposit.\nYour initial deposit should not be less than 500.");
            }

            if (!validEmail || !validAddress || !validCNumber || !validAge || !validName || !validImage || !validDeposit || !validGender)
            {
                return false;
            }

            return true;
        }
        public void customerID_Generator()
        {
            Random rand = new Random();
            this.customer_id = "CUST" + rand.Next(0,10000).ToString("0000");
            txtCustomerID.Text = this.customer_id;
        }

        public void accNumber_Gen()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customers", conn);

                if (cmd.ExecuteScalar() != null && cmd.ExecuteScalar() != DBNull.Value)
                {
                    count = (int)cmd.ExecuteScalar() + 1;
                }
                
            }
            this.accNum = birthYear(dtpBdate.Text).ToString() + "-" + currentYear.ToString() + "-" + count.ToString();

        }

    }
}
