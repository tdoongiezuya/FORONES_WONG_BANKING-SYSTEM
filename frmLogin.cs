using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string username = "admin", password = "admin";
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
            if((txtUsername.Text.Trim().Equals(username))&&(txtPassword.Text.Trim().Equals(password)))
            {
                new frmDashboard().Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Invalid Credentials.");
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
