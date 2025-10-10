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
    public partial class frmDashboard : Form
    {
        
     
        public frmDashboard()
        {
            InitializeComponent();
        }


        private void btnDisInfo_Click(object sender, EventArgs e)
        {
            
            new frmDisplayInfo().Show();
            this.Hide();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            new frmRegistration().Show();
            this.Hide();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();    
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            new frmDeposit().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            btnRegistration.BackColor = Color.DarkViolet;
        }

        private void btnRegistration_MouseUp(object sender, MouseEventArgs e)
        {
            btnRegistration.BackColor = Color.MediumPurple;
        }
    }
}
