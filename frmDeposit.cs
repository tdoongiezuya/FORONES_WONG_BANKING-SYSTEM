using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WONG_BANKING
{
    public partial class frmDeposit : Form
    {

        int q1000, q500, q200, q100, q50, q20, q10, q5, q1, total;

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }

        public frmDeposit()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt1000_TextChanged(object sender, EventArgs e)
        {

        }

        private void Computation_TextChanged (object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            q1000 = string.IsNullOrWhiteSpace(txt1000.Text) ? 0 : Convert.ToInt32(txt1000.Text) * 1000;
            q500 = string.IsNullOrWhiteSpace(txt500.Text) ? 0 : Convert.ToInt32(txt500.Text) * 500;
            q200 = string.IsNullOrWhiteSpace(txt200.Text) ? 0 : Convert.ToInt32(txt200.Text) * 200;
            q100 = string.IsNullOrWhiteSpace(txt100.Text) ? 0 : Convert.ToInt32(txt100.Text) * 100;
            q50 = string.IsNullOrWhiteSpace(txt50.Text) ? 0 : Convert.ToInt32(txt50.Text) * 50;
            q10 = string.IsNullOrWhiteSpace(txt10.Text) ? 0 : Convert.ToInt32(txt10.Text) * 10;
            q20 = string.IsNullOrWhiteSpace(txt20.Text) ? 0 : Convert.ToInt32(txt20.Text) * 20;
            q5 = string.IsNullOrWhiteSpace(txt5.Text) ? 0 : Convert.ToInt32(txt5.Text) * 5;
            q1 = string.IsNullOrWhiteSpace(txt1.Text) ? 0 : Convert.ToInt32(txt1.Text) * 1;

            if (txt == txt1000) lbl1000.Text = q1000.ToString();
            else if (txt == txt500) lbl500.Text = q500.ToString();
            else if (txt == txt200) lbl200.Text = q200.ToString();
            else if (txt == txt100) lbl100.Text = q100.ToString();
            else if (txt == txt50) lbl50.Text = q50.ToString();
            else if (txt == txt20) lbl20.Text = q20.ToString();
            else if (txt == txt10) lbl10.Text = q10.ToString();
            else if (txt == txt5) lbl5.Text = q5.ToString();
            else if (txt == txt1) lbl1.Text = q1.ToString();

            total = q1000 + q500 + q200 + q100 + q50 + q20 + q10 + q1;

            lblTotal.Text = total.ToString();
        }

        
    }
}
