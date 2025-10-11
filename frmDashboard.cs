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
        private string[] imagePaths;
        private int currentIndex = 0;
     
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
            imagePaths = new string[]
            {
                 @"C:\Users\USER\source\repos\tdoongiezuya\FORONES_WONG_BANKING-SYSTEM\Resources\bank.jpg",
                 @"C:\Users\USER\source\repos\tdoongiezuya\FORONES_WONG_BANKING-SYSTEM\Resources\deposit.jpg",
                 @"C:\Users\USER\source\repos\tdoongiezuya\FORONES_WONG_BANKING-SYSTEM\Resources\withdraw.jpg"
            };
            picCarousel.Image = Image.FromFile(imagePaths[currentIndex]);
            picCarousel.SizeMode = PictureBoxSizeMode.StretchImage;

            // Configure timer
            timer1.Interval = 3000; // 3 seconds
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= imagePaths.Length)
                currentIndex = 0;

            picCarousel.Image = Image.FromFile(imagePaths[currentIndex]);
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
