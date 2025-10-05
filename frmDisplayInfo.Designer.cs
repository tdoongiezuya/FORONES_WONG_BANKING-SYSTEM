namespace WONG_BANKING
{
    partial class frmDisplayInfo
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
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBdate = new System.Windows.Forms.Label();
            this.lblCStatus = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCnumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.listViewCustomers = new System.Windows.Forms.ListView();
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Civil_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contact_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lblCId = new System.Windows.Forms.Label();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(278, 167);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Birthdate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Civil Status: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contact Number: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(278, 218);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(49, 25);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "N/A";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(508, 218);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(49, 25);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "N/A";
            // 
            // lblBdate
            // 
            this.lblBdate.AutoSize = true;
            this.lblBdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBdate.Location = new System.Drawing.Point(278, 269);
            this.lblBdate.Name = "lblBdate";
            this.lblBdate.Size = new System.Drawing.Size(49, 25);
            this.lblBdate.TabIndex = 11;
            this.lblBdate.Text = "N/A";
            // 
            // lblCStatus
            // 
            this.lblCStatus.AutoSize = true;
            this.lblCStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCStatus.Location = new System.Drawing.Point(278, 319);
            this.lblCStatus.Name = "lblCStatus";
            this.lblCStatus.Size = new System.Drawing.Size(49, 25);
            this.lblCStatus.TabIndex = 12;
            this.lblCStatus.Text = "N/A";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(278, 370);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 25);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "N/A";
            // 
            // lblCnumber
            // 
            this.lblCnumber.AutoSize = true;
            this.lblCnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnumber.Location = new System.Drawing.Point(278, 420);
            this.lblCnumber.Name = "lblCnumber";
            this.lblCnumber.Size = new System.Drawing.Size(49, 25);
            this.lblCnumber.TabIndex = 14;
            this.lblCnumber.Text = "N/A";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(278, 474);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 25);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "N/A";
            this.lblEmail.Click += new System.EventHandler(this.label15_Click);
            // 
            // listViewCustomers
            // 
            this.listViewCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FullName,
            this.Gender,
            this.Birthdate,
            this.Civil_Status,
            this.Address,
            this.Contact_Number,
            this.Email});
            this.listViewCustomers.FullRowSelect = true;
            this.listViewCustomers.GridLines = true;
            this.listViewCustomers.HideSelection = false;
            this.listViewCustomers.Location = new System.Drawing.Point(690, 34);
            this.listViewCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewCustomers.Name = "listViewCustomers";
            this.listViewCustomers.Size = new System.Drawing.Size(378, 593);
            this.listViewCustomers.TabIndex = 16;
            this.listViewCustomers.TileSize = new System.Drawing.Size(10, 1);
            this.listViewCustomers.UseCompatibleStateImageBehavior = false;
            this.listViewCustomers.SelectedIndexChanged += new System.EventHandler(this.listViewCustomers_SelectedIndexChanged);
            // 
            // FullName
            // 
            this.FullName.Text = "Name";
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            // 
            // Birthdate
            // 
            this.Birthdate.Text = "Birthdate";
            // 
            // Civil_Status
            // 
            this.Civil_Status.Text = "Civil Status";
            // 
            // Address
            // 
            this.Address.Text = "Address";
            // 
            // Contact_Number
            // 
            this.Contact_Number.Text = "Contact number";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(458, 587);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 40);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(70, 117);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(139, 25);
            this.lbl9.TabIndex = 18;
            this.lbl9.Text = "Customer ID:";
            // 
            // lblCId
            // 
            this.lblCId.AutoSize = true;
            this.lblCId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCId.Location = new System.Drawing.Point(278, 117);
            this.lblCId.Name = "lblCId";
            this.lblCId.Size = new System.Drawing.Size(49, 25);
            this.lblCId.TabIndex = 19;
            this.lblCId.Text = "N/A";
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.HorizontalScrollbar = true;
            this.listBoxCustomers.ItemHeight = 16;
            this.listBoxCustomers.Location = new System.Drawing.Point(1103, 34);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.ScrollAlwaysVisible = true;
            this.listBoxCustomers.Size = new System.Drawing.Size(332, 596);
            this.listBoxCustomers.TabIndex = 20;
            this.listBoxCustomers.TabStop = false;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            // 
            // frmDisplayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 755);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.lblCId);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listViewCustomers);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCnumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCStatus);
            this.Controls.Add(this.lblBdate);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDisplayInfo";
            this.Text = "frmDisplayInfo";
            this.Load += new System.EventHandler(this.frmDisplayInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBdate;
        private System.Windows.Forms.Label lblCStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCnumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ListView listViewCustomers;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Birthdate;
        private System.Windows.Forms.ColumnHeader Civil_Status;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Contact_Number;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblCId;
        private System.Windows.Forms.ListBox listBoxCustomers;
    }
}