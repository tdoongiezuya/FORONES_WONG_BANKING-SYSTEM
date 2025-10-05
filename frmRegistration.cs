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

namespace WONG_BANKING
{



    public partial class frmRegistration : Form
    {
        string gender, customer_id;
        int age;
      
        public frmRegistration()
        {
            InitializeComponent();
            
        }
        

        public void customerID_Generator()
        {
            Random rand = new Random();
            this.customer_id = "CUST" + rand.Next(10).ToString()+ rand.Next(300).ToString();
            txtCustomerID.Text = this.customer_id;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            customerID_Generator();
            cboCivilStatus.SelectedIndex = 5;
        }

        private void frmRegistration_Click(object sender, EventArgs e)
        {
            new frmRegistration().ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Customer _customer = new Customer();
            List<Customer> instance = Customer.getInstance();
            age = calculateAge(Convert.ToInt32(dtpBdate.Text.Split(',')[1]));
            Console.WriteLine(age);
            if (validation(txtEmail.Text, txtAddress.Text, txtCNumber.Text, age, txtName.Text))
            {
                if (rbtMale.Checked == true)
                {
                    gender = rbtMale.Text;
                }
                else
                {
                    gender = rbtFemale.Text;
                }

                _customer.setName(txtName.Text);
                _customer.setGender(gender);
                _customer.setAge(this.age);
                _customer.setBirthdate(dtpBdate.Text);
                _customer.setAddress(txtAddress.Text);
                _customer.setCStatus(cboCivilStatus.SelectedIndex == 5 ? "" : cboCivilStatus.Text);
                _customer.setCNumber(txtCNumber.Text);
                _customer.setEmail(txtEmail.Text);
                _customer.setId(txtCustomerID.Text);

                instance.Add(_customer);
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
            new frmDashboard().Show();
            this.Hide();
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
              


            }
        }

        private void clearItems()
        {
            txtName.Text = txtAddress.Text = txtEmail.Text = txtCNumber.Text = "";
            rbtFemale.Checked = rbtMale.Checked = false;
            dtpBdate.Text = DateTime.Now.ToString();
            cboCivilStatus.SelectedIndex = 5;
        }

        public int  calculateAge(int birthyear)
        {
            return  DateTime.Now.Year - birthyear;
        }
        public bool validation(string email, string address, string cNumber, int age, string name)
        {
            errorProvider1.Clear();
            bool validEmail = true, validAddress = true, validCNumber = true, validAge = true, validName = true;

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
            }
                if (!validEmail || !validAddress || !validCNumber || !validAge || !validName)
            {
                return false;
            }

            return true;

            
        }
    }
}
