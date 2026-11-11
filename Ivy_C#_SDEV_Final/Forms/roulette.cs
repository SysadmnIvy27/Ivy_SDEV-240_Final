using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivy_C__SDEV_Final.Forms
{
    public partial class roulette : Form
    {
        public Bitmap RotateImageCustom(Image image, float angleDegrees)
        {
            if (image == null) return null;

            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);

            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                g.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);

                g.RotateTransform(angleDegrees);

                g.TranslateTransform(-(float)image.Width / 2, -(float)image.Height / 2);
                g.DrawImage(image, new Point(0, 0));
            }

            return rotatedBmp;
        }
        public roulette()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pictWheel.Image = RotateImageCustom(pictWheel.Image, 45f);
        }
    }
}
