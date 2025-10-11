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
            this.lblAccNum = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultName = new System.Windows.Forms.Label();
            this.lblResultBalance = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.BackColor = System.Drawing.Color.White;
            this.lblAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.Location = new System.Drawing.Point(138, 100);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(196, 20);
            this.lblAccNum.TabIndex = 0;
            this.lblAccNum.Text = "Enter Account Number:";
            this.lblAccNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAccNum
            // 
            this.txtAccNum.Location = new System.Drawing.Point(356, 100);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(282, 20);
            this.txtAccNum.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(356, 154);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 24);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(24, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Account Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remaining Balance:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblResultName
            // 
            this.lblResultName.AutoSize = true;
            this.lblResultName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResultName.Location = new System.Drawing.Point(94, 46);
            this.lblResultName.Name = "lblResultName";
            this.lblResultName.Size = new System.Drawing.Size(35, 20);
            this.lblResultName.TabIndex = 5;
            this.lblResultName.Text = "N/A";
            // 
            // lblResultBalance
            // 
            this.lblResultBalance.AutoSize = true;
            this.lblResultBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultBalance.Location = new System.Drawing.Point(94, 135);
            this.lblResultBalance.Name = "lblResultBalance";
            this.lblResultBalance.Size = new System.Drawing.Size(35, 20);
            this.lblResultBalance.TabIndex = 6;
            this.lblResultBalance.Text = "N/A";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 33);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblResultName);
            this.panel1.Controls.Add(this.lblResultBalance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(193, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 194);
            this.panel1.TabIndex = 8;
            // 
            // frmCheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.lblAccNum);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCheckBalance";
            this.Text = "CHECK BALANCE";
            this.Load += new System.EventHandler(this.frmCheckBalance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultName;
        private System.Windows.Forms.Label lblResultBalance;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}