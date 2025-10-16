namespace WONG_BANKING
{
    partial class frmCheckBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckBalance));
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultName = new System.Windows.Forms.Label();
            this.lblResultBalance = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAccNumC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAccNameC = new System.Windows.Forms.Label();
            this.lblBalanceC = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccNum = new System.Windows.Forms.Label();
            this.panelAccNum = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAcc = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.panelAdmin.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelAccNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(35, 214);
            this.lblName.Margin = new System.Windows.Forms.Padding(15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Account Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remaining Balance:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblResultName
            // 
            this.lblResultName.AutoSize = true;
            this.lblResultName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultName.Location = new System.Drawing.Point(227, 214);
            this.lblResultName.Margin = new System.Windows.Forms.Padding(15);
            this.lblResultName.Name = "lblResultName";
            this.lblResultName.Size = new System.Drawing.Size(42, 21);
            this.lblResultName.TabIndex = 5;
            this.lblResultName.Text = "N/A";
            // 
            // lblResultBalance
            // 
            this.lblResultBalance.AutoSize = true;
            this.lblResultBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultBalance.Location = new System.Drawing.Point(227, 263);
            this.lblResultBalance.Margin = new System.Windows.Forms.Padding(15);
            this.lblResultBalance.Name = "lblResultBalance";
            this.lblResultBalance.Size = new System.Drawing.Size(42, 21);
            this.lblResultBalance.TabIndex = 6;
            this.lblResultBalance.Text = "N/A";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(709, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 33);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "CLOSE";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelAdmin.Controls.Add(this.label18);
            this.panelAdmin.Controls.Add(this.label1);
            this.panelAdmin.Controls.Add(this.lblAccNum);
            this.panelAdmin.Controls.Add(this.panelAccNum);
            this.panelAdmin.Controls.Add(this.lblName);
            this.panelAdmin.Controls.Add(this.lblResultName);
            this.panelAdmin.Controls.Add(this.lblResultBalance);
            this.panelAdmin.Controls.Add(this.label2);
            this.panelAdmin.Location = new System.Drawing.Point(90, 51);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(599, 324);
            this.panelAdmin.TabIndex = 8;
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelCustomer.Controls.Add(this.label4);
            this.panelCustomer.Controls.Add(this.label5);
            this.panelCustomer.Controls.Add(this.lblAccNumC);
            this.panelCustomer.Controls.Add(this.label8);
            this.panelCustomer.Controls.Add(this.lblAccNameC);
            this.panelCustomer.Controls.Add(this.lblBalanceC);
            this.panelCustomer.Controls.Add(this.label11);
            this.panelCustomer.Location = new System.Drawing.Point(90, 51);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(599, 324);
            this.panelCustomer.TabIndex = 63;
            this.panelCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCustomer_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(125, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 47);
            this.label4.TabIndex = 62;
            this.label4.Text = "CHECK BALANCE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(67, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Account Number:";
            // 
            // lblAccNumC
            // 
            this.lblAccNumC.AutoSize = true;
            this.lblAccNumC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNumC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccNumC.Location = new System.Drawing.Point(259, 126);
            this.lblAccNumC.Margin = new System.Windows.Forms.Padding(15);
            this.lblAccNumC.Name = "lblAccNumC";
            this.lblAccNumC.Size = new System.Drawing.Size(42, 21);
            this.lblAccNumC.TabIndex = 23;
            this.lblAccNumC.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(67, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Account Name:";
            // 
            // lblAccNameC
            // 
            this.lblAccNameC.AutoSize = true;
            this.lblAccNameC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNameC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccNameC.Location = new System.Drawing.Point(259, 176);
            this.lblAccNameC.Margin = new System.Windows.Forms.Padding(15);
            this.lblAccNameC.Name = "lblAccNameC";
            this.lblAccNameC.Size = new System.Drawing.Size(42, 21);
            this.lblAccNameC.TabIndex = 5;
            this.lblAccNameC.Text = "N/A";
            // 
            // lblBalanceC
            // 
            this.lblBalanceC.AutoSize = true;
            this.lblBalanceC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBalanceC.Location = new System.Drawing.Point(259, 225);
            this.lblBalanceC.Margin = new System.Windows.Forms.Padding(15);
            this.lblBalanceC.Name = "lblBalanceC";
            this.lblBalanceC.Size = new System.Drawing.Size(42, 21);
            this.lblBalanceC.TabIndex = 6;
            this.lblBalanceC.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(67, 225);
            this.label11.Margin = new System.Windows.Forms.Padding(15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Remaining Balance:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SteelBlue;
            this.label18.Location = new System.Drawing.Point(125, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(349, 47);
            this.label18.TabIndex = 62;
            this.label18.Text = "CHECK BALANCE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Account Number:";
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccNum.Location = new System.Drawing.Point(227, 164);
            this.lblAccNum.Margin = new System.Windows.Forms.Padding(15);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(42, 21);
            this.lblAccNum.TabIndex = 23;
            this.lblAccNum.Text = "N/A";
            // 
            // panelAccNum
            // 
            this.panelAccNum.Controls.Add(this.btnSearch);
            this.panelAccNum.Controls.Add(this.lblAcc);
            this.panelAccNum.Controls.Add(this.txtAccNum);
            this.panelAccNum.Location = new System.Drawing.Point(153, 81);
            this.panelAccNum.Name = "panelAccNum";
            this.panelAccNum.Size = new System.Drawing.Size(292, 65);
            this.panelAccNum.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(213, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 27);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAcc
            // 
            this.lblAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcc.AutoSize = true;
            this.lblAcc.BackColor = System.Drawing.SystemColors.Control;
            this.lblAcc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAcc.Location = new System.Drawing.Point(11, 5);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(127, 17);
            this.lblAcc.TabIndex = 6;
            this.lblAcc.Text = "Account Number:";
            this.lblAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccNum
            // 
            this.txtAccNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNum.Location = new System.Drawing.Point(15, 28);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(183, 27);
            this.txtAccNum.TabIndex = 6;
            this.txtAccNum.TextChanged += new System.EventHandler(this.txtAccNum_TextChanged);
            this.txtAccNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccNum_KeyPress);
            // 
            // frmCheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelAdmin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheckBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHECK BALANCE";
            this.Load += new System.EventHandler(this.frmCheckBalance_Load);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelAccNum.ResumeLayout(false);
            this.panelAccNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultName;
        private System.Windows.Forms.Label lblResultBalance;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.Panel panelAccNum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAccNumC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAccNameC;
        private System.Windows.Forms.Label lblBalanceC;
        private System.Windows.Forms.Label label11;
    }
}