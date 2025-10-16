namespace WONG_BANKING
{
    partial class frmNewDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picProfile = new WONG_BANKING.CircularPictureBox();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.buttonTransactionHistory = new System.Windows.Forms.Button();
            this.buttonCProfile = new System.Windows.Forms.Button();
            this.buttonCbalance = new System.Windows.Forms.Button();
            this.buttonCDeposit = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.picCarousel = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.panelCustomer.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarousel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelCustomer);
            this.panel1.Controls.Add(this.panelAdmin);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 845);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Controls.Add(this.picProfile);
            this.panel2.Location = new System.Drawing.Point(29, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 200);
            this.panel2.TabIndex = 11;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(63, 160);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(40, 19);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "N/A";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProfile
            // 
            this.picProfile.Location = new System.Drawing.Point(76, 14);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(132, 126);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 6;
            this.picProfile.TabStop = false;
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.buttonTransactionHistory);
            this.panelCustomer.Controls.Add(this.buttonCProfile);
            this.panelCustomer.Controls.Add(this.buttonCbalance);
            this.panelCustomer.Controls.Add(this.buttonCDeposit);
            this.panelCustomer.Location = new System.Drawing.Point(29, 257);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(285, 423);
            this.panelCustomer.TabIndex = 10;
            // 
            // buttonTransactionHistory
            // 
            this.buttonTransactionHistory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTransactionHistory.FlatAppearance.BorderSize = 0;
            this.buttonTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionHistory.Location = new System.Drawing.Point(24, 332);
            this.buttonTransactionHistory.Margin = new System.Windows.Forms.Padding(24);
            this.buttonTransactionHistory.Name = "buttonTransactionHistory";
            this.buttonTransactionHistory.Size = new System.Drawing.Size(238, 60);
            this.buttonTransactionHistory.TabIndex = 8;
            this.buttonTransactionHistory.Text = "TRANSACTIONS HISTORY";
            this.buttonTransactionHistory.UseVisualStyleBackColor = false;
            this.buttonTransactionHistory.Click += new System.EventHandler(this.buttonTransactionHistory_Click);
            // 
            // buttonCProfile
            // 
            this.buttonCProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCProfile.FlatAppearance.BorderSize = 0;
            this.buttonCProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCProfile.Location = new System.Drawing.Point(23, 224);
            this.buttonCProfile.Margin = new System.Windows.Forms.Padding(24);
            this.buttonCProfile.Name = "buttonCProfile";
            this.buttonCProfile.Size = new System.Drawing.Size(238, 60);
            this.buttonCProfile.TabIndex = 4;
            this.buttonCProfile.Text = "VIEW PROFILE";
            this.buttonCProfile.UseVisualStyleBackColor = false;
            this.buttonCProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // buttonCbalance
            // 
            this.buttonCbalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCbalance.FlatAppearance.BorderSize = 0;
            this.buttonCbalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCbalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCbalance.Location = new System.Drawing.Point(23, 116);
            this.buttonCbalance.Margin = new System.Windows.Forms.Padding(24);
            this.buttonCbalance.Name = "buttonCbalance";
            this.buttonCbalance.Size = new System.Drawing.Size(238, 60);
            this.buttonCbalance.TabIndex = 3;
            this.buttonCbalance.Text = "CHECK BALANCE";
            this.buttonCbalance.UseVisualStyleBackColor = false;
            this.buttonCbalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // buttonCDeposit
            // 
            this.buttonCDeposit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCDeposit.FlatAppearance.BorderSize = 0;
            this.buttonCDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCDeposit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCDeposit.Location = new System.Drawing.Point(23, 8);
            this.buttonCDeposit.Margin = new System.Windows.Forms.Padding(24);
            this.buttonCDeposit.Name = "buttonCDeposit";
            this.buttonCDeposit.Size = new System.Drawing.Size(238, 60);
            this.buttonCDeposit.TabIndex = 2;
            this.buttonCDeposit.Text = "DEPOSIT";
            this.buttonCDeposit.UseVisualStyleBackColor = false;
            this.buttonCDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.button4);
            this.panelAdmin.Controls.Add(this.button3);
            this.panelAdmin.Controls.Add(this.btnDeposit);
            this.panelAdmin.Controls.Add(this.btnWithdraw);
            this.panelAdmin.Controls.Add(this.btnRegister);
            this.panelAdmin.Location = new System.Drawing.Point(29, 257);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(285, 423);
            this.panelAdmin.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(23, 360);
            this.button4.Margin = new System.Windows.Forms.Padding(15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "VIEW CUSTOMER PROFILE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(23, 270);
            this.button3.Margin = new System.Windows.Forms.Padding(15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "CHECK BALANCE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(23, 180);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(15);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(238, 60);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(23, 90);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(15);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(238, 60);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "WITHDRAW";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(23, 0);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(15);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(238, 60);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "REGISTRATION";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(52, 716);
            this.button5.Margin = new System.Windows.Forms.Padding(15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(238, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "LOG OUT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.picCarousel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(-360, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1900, 845);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // picCarousel
            // 
            this.picCarousel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picCarousel.Location = new System.Drawing.Point(954, 174);
            this.picCarousel.Name = "picCarousel";
            this.picCarousel.Size = new System.Drawing.Size(736, 496);
            this.picCarousel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarousel.TabIndex = 1;
            this.picCarousel.TabStop = false;
            this.picCarousel.Click += new System.EventHandler(this.picCarousel_Click);
            // 
            // frmNewDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmNewDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNewDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCarousel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.PictureBox picCarousel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWelcome;
        private CircularPictureBox picProfile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Button buttonTransactionHistory;
        private System.Windows.Forms.Button buttonCProfile;
        private System.Windows.Forms.Button buttonCbalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCDeposit;
    }
}