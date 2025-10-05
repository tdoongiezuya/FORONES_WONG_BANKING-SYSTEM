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
            List<Customer> customerList = Customer.getInstance();
            listViewCustomers.View = View.Details;
            listViewCustomers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            foreach (Customer customer in customerList)
            {
                ListViewItem item = new ListViewItem(customer.getName());
                item.SubItems.Add(customer.getGender());
                item.SubItems.Add(customer.getBirthdate());
                item.SubItems.Add(customer.getCStatus());
                item.SubItems.Add(customer.getAddress());
                item.SubItems.Add(customer.getCNumber());
                item.SubItems.Add(customer.getEmail());
                item.SubItems.Add(customer.getAge().ToString());
                item.SubItems.Add(customer.getId());

                listViewCustomers.Items.Add(item);
            }

            foreach (Customer customer in customerList)
            {
                listBoxCustomers.Items.Add(customer.getId() + "," + customer.getName() + "," + customer.getGender() + "," + customer.getAge().ToString() + "," 
                    + customer.getBirthdate() + "," + customer.getCStatus() + "," + customer.getAddress() + "," + customer.getCNumber() + "," + customer.getEmail() );
            }

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

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBoxCustomers.SelectedItem.ToString();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            lblCId.Text = selectedItem.Split(',')[0].Trim();
            lblName.Text = selectedItem.Split(',')[1].Trim();
            lblGender.Text = selectedItem.Split(',')[2].Trim();
            lblAge.Text = selectedItem.Split(',')[3].Trim();
            lblBdate.Text = selectedItem.Split(',')[4].Trim() + " " + selectedItem.Split(',')[5].Trim();
            lblCStatus.Text = selectedItem.Split(',')[6].Trim();
            lblAddress.Text = selectedItem.Split(',')[7].Trim();
            lblCnumber.Text = selectedItem.Split(',')[8].Trim();
            lblEmail.Text = selectedItem.Split(',')[9].Trim();

        }
    }
}
