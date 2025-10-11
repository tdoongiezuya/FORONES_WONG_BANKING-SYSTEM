using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WONG_BANKING
{
    public class CircularPictureBox : PictureBox
    {

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                this.Region = new Region(gp);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Optional: draw border
            using (Pen pen = new Pen(Color.White, 3))
            {
                pe.Graphics.DrawEllipse(pen, 1, 1, this.Width - 3, this.Height - 3);
            }
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
