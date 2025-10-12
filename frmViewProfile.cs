using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WONG_BANKING
{
    public partial class frmViewProfile : Form
    {
        public frmViewProfile()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void frmViewProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.bankDBDataSet.Customers);

            if (Session.UserLevel == "Customer")
            {
                this.Size = new Size(849, 409);
                customersDataGridView.Visible = false;

                Customer cust = Session.CurrentCustomer;
                lblCId.Text = cust.CustomerID;
                lblAccNum.Text = cust.AccNum;
                lblName.Text = cust.Name;
                lblGender.Text = cust.Gender;
                lblAge.Text = (cust.Age).ToString();
                lblBdate.Text = cust.Birthdate;
                lblCStatus.Text = cust.CivilStatus;
                lblAddress.Text = cust.Address;
                lblCnumber.Text = cust.ContactNumber;
                lblEmail.Text = cust.Email;
                pbProfile.Image = Image.FromFile(cust.ImagePath);

            } else if (Session.UserLevel == "Admin")
            {
                this.Size = new Size(849, 672);
            }
        }

        private void customersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customersDataGridView.Rows[e.RowIndex];

                lblCId.Text = row.Cells[0].Value.ToString();
                lblAccNum.Text = row.Cells[1].Value.ToString();
                lblName.Text = row.Cells[2].Value.ToString();
                lblGender.Text = row.Cells[3].Value.ToString();
                lblAge.Text = row.Cells[4].Value.ToString();
                lblBdate.Text = row.Cells[5].Value.ToString();
                lblCStatus.Text = row.Cells[6].Value.ToString();
                lblAddress.Text = row.Cells[7].Value.ToString();
                lblCnumber.Text = row.Cells[8].Value.ToString();
                lblEmail.Text = row.Cells[9].Value.ToString();
                pbProfile.Image = Image.FromFile(row.Cells[10].Value.ToString());
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pbProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmDashboard().Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
