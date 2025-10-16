using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WONG_BANKING.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WONG_BANKING
{
    public partial class frmNewDashboard : Form
    {
        private string[] imagePaths;
        private int currentIndex = 0;
        
        
        public frmNewDashboard()
        {
            InitializeComponent();
        }
        
        private void frmNewDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {Session.UserLevel}!";

            // 🧍 Load profile picture only if user is a Customer
            if (Session.UserLevel == "Customer" && Session.CurrentCustomer != null)
            {
                panelAdmin.Visible = false ;
                panelCustomer.Visible = true ;
                try
                {
                    Customer cust = Session.CurrentCustomer;
                    string imagePath = cust.ImagePath;

                    if (File.Exists(imagePath))
                    {
                        picProfile.Image = Image.FromFile(imagePath);

                    }
                    else
                    {
                        // If image file no longer exists
                        picProfile.Image = Properties.Resources.default_user;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading profile image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    picProfile.Image = Properties.Resources.default_user;
                }
            }
            else if (Session.UserLevel == "Admin")
            {
                panelCustomer.Visible = false;
                panelAdmin.Visible = true;
                // ADMIN: Set admin-specific image or default admin avatar
                try
                {
                    // You can replace this with your own admin image if available
                    picProfile.Image = Properties.Resources.default_user;
                }
                catch
                {
                    picProfile.Image = Properties.Resources.default_user;
                }
            }
            else
            {
                picProfile.Image = Properties.Resources.default_user;
            }

            
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;

            // 🖼️ Image carousel setup
            imagePaths = new string[]
            {
                @"C:\Users\ADMIN\source\repos\Wong_Copro3\WONG_BANKING\Resources\WORLD NO.1 SAFEST BANK.png",
                @"C:\Users\ADMIN\source\repos\Wong_Copro3\WONG_BANKING\Resources\deposit.jpg",
                @"C:\Users\ADMIN\source\repos\Wong_Copro3\WONG_BANKING\Resources\withdraw.jpg"
            };

            if (File.Exists(imagePaths[currentIndex]))
            {
                picCarousel.Image = Image.FromFile(imagePaths[currentIndex]);
                picCarousel.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            // 🕒 Configure and start timer
            timer1.Interval = 3000; // 3 seconds
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            closeOtherForms();
            new frmRegistration().Show();
            
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            closeOtherForms();
            new frmWithdraw().Show();
            
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            closeOtherForms();
            new frmDeposit().Show();
            
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            closeOtherForms();
            new frmCheckBalance().Show();
            
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            closeOtherForms();
            new frmViewProfile().Show();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            closeOtherForms();
            Session.clearSession();
            new frmLogin().Show();
            this.Close();
        }

        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            closeOtherForms();
            new TransactionHistory().Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= imagePaths.Length)
                currentIndex = 0;

            if (File.Exists(imagePaths[currentIndex]))
            {
                picCarousel.Image = Image.FromFile(imagePaths[currentIndex]);
            }
        }

        private void closeOtherForms()
        {
            foreach (Form openForm in Application.OpenForms.Cast<Form>().ToList())
            {
                if (openForm != this && !(openForm is frmLogin))
                {
                    openForm.Close();
                }
            }
        }
        private void picCarousel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
