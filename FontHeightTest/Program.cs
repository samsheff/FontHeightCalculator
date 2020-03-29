using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FontHeightTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Graphics g = Graphics.FromImage( new Bitmap(1,1)))
            {
                var pixels = 11 * g.DpiX / 72;
                MessageBox.Show(SystemFonts.DefaultFont.Name + " is at 72pt is " + pixels + " pixels per point");
            }
        }
    }
}
