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

namespace WONG_BANKING
{
    public partial class frmNewDashboard : Form
    {
        private string[] imagePaths;
        private int currentIndex = 0;
        public string CurrentUserEmail { get; set; }
        //private Customer currentCustomer; using object
        public frmNewDashboard()
        {
            InitializeComponent();
        }
        /* using object Pag mag-gamit kog object dele makuha ang image TT_TT
        public frmDashboard(Customer customer)
        {
           InitializeComponent();
           currentCustomer = customer;
           CurrentUserEmail = customer.Email;
        }
        */

        private void frmNewDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {Session.UserLevel}!";

            // 🧍 Load profile picture only if user is a Customer
            if (Session.UserLevel == "Customer" && !string.IsNullOrEmpty(Session.Email))
            {
                try
                {
                    using (SqlConnection conn = DBHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "SELECT ImagePath FROM Customers WHERE Email = @Email";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", Session.Email);
                            object result = cmd.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {
                                string imagePath = result.ToString();

                                if (File.Exists(imagePath))
                                {
                                    // Safely load image without locking file
                                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                                    {
                                        picProfile.Image = Image.FromStream(fs);
                                    }
                                }
                                else
                                {
                                    // If image file no longer exists
                                    picProfile.Image = Properties.Resources.default_user;
                                }
                            }
                            else
                            {
                                // If ImagePath in DB is null
                                picProfile.Image = Properties.Resources.default_user;
                            }
                        }
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
                // 👑 ADMIN: Set admin-specific image or default admin avatar
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
                // 🧾 UNKNOWN USER TYPE — fallback to default
                picProfile.Image = Properties.Resources.default_user;
            }

            /* USING OBJECT
                         if (Session.UserLevel == "Customer")
            {
                // 🔹 Case 1: We have a customer object (came from registration)
                if (currentCustomer != null && !string.IsNullOrEmpty(currentCustomer.ImagePath))
                {
                    try
                    {
                        if (File.Exists(currentCustomer.ImagePath))
                        {
                            picProfile.Image = Image.FromFile(currentCustomer.ImagePath);
                        }
                        else
                        {
                            picProfile.Image = Properties.Resources.default_user;
                        }
                    }
                    catch
                    {
                        picProfile.Image = Properties.Resources.default_user;
                    }
                }
                else
                {
                    // 🔹 Case 2: Load from database using email (normal login)
                    LoadImageFromDatabase(CurrentUserEmail);
                }
            }
            else
            {
                // 👑 Admin or others
                picProfile.Image = Properties.Resources.default_user;
            }
             */

            // 🖼 Apply consistent picture box settings
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;

            // 🖼️ Image carousel setup
            imagePaths = new string[]
            {
                @"C:\Users\USER\source\repos\tdoongiezuya\FORONES_WONG_BANKING-SYSTEM\Resources\WORLD NO.1 SAFEST BANK.png",
                @"C:\Users\USER\source\repos\tdoongiezuya\FORONES_WONG_BANKING-SYSTEM\Resources\deposit.jpg",
                @"C:\Users\USER\source\repos\tdoongiezuya\FORONES_WONG_BANKING-SYSTEM\Resources\withdraw.jpg"
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
            new frmRegistration().Show();
            this.Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            new frmWithdraw().Show();
            this.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            new frmDeposit().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmCheckBalance().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmViewProfile().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
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


        /* Using Object
        private void LoadImageFromDatabase(string email)
        {
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ImagePath FROM Customers WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string imagePath = result.ToString();
                        if (File.Exists(imagePath))
                            picProfile.Image = Image.FromFile(imagePath);
                        else
                            picProfile.Image = Properties.Resources.default_user;
                    }
                    else
                    {
                        picProfile.Image = Properties.Resources.default_user;
                    }
                }
            }
            catch
            {
                picProfile.Image = Properties.Resources.default_user;
            }
        }
         */
    }
}
