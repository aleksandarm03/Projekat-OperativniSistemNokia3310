using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Nokia3310
{
    class Polje:PictureBox
    {
        public Polje(int x, int y)
        {
            Random r = new Random();
            Location = new System.Drawing.Point(x, y);
            Size = new System.Drawing.Size(20, 20);
            BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 10), r.Next(0, 255));
            Enabled = false;
        } 
    }
}
