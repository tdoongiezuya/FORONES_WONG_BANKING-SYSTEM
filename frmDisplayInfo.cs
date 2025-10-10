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
    public partial class frmDisplayInfo : Form
    {

        public frmDisplayInfo()
        {
            InitializeComponent();
            
        }

        private void frmDisplayInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.bankDBDataSet.Customers);
            // TODO: This line of code loads data into the 'bankDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.bankDBDataSet.Customers);
            List<Customer> customerList = Customer.getInstance();
            listViewCustomers.View = View.Details;
            listViewCustomers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            //foreach (Customer customer in customerList)
            //{
            //    ListViewItem item = new ListViewItem(customer.getName());
            //    item.SubItems.Add(customer.getGender());
            //    item.SubItems.Add(customer.getBirthdate());
            //    item.SubItems.Add(customer.getCStatus());
            //    item.SubItems.Add(customer.getAddress());
            //    item.SubItems.Add(customer.getCNumber());
            //    item.SubItems.Add(customer.getEmail());
            //    item.SubItems.Add(customer.getAge().ToString());
            //    item.SubItems.Add(customer.getId());

            //    listViewCustomers.Items.Add(item);
            //}

            //foreach (Customer customer in customerList)
            //{
            //    listBoxCustomers.Items.Add(customer.getId() + "," + customer.getName() + "," + customer.getGender() + "," + customer.getAge().ToString() + "," 
            //        + customer.getBirthdate() + "," + customer.getCStatus() + "," + customer.getAddress() + "," + customer.getCNumber() + "," + customer.getEmail() );
            //}

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCustomers.SelectedItems[0];

                lblCId.Text = selectedItem.SubItems[8].Text;
                lblName.Text = selectedItem.Text;
                lblGender.Text = selectedItem.SubItems[1].Text;
                lblAge.Text = selectedItem.SubItems[7].Text;
                lblBdate.Text = selectedItem.SubItems[2].Text;
                lblCStatus.Text = selectedItem.SubItems[3].Text;
                lblAddress.Text = selectedItem.SubItems[4].Text;
                lblCnumber.Text = selectedItem.SubItems[5].Text;
                lblEmail.Text = selectedItem.SubItems[6].Text;

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmDashboard().Show();
            this.Hide();
        }

        
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
