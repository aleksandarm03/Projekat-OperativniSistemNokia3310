using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Nokia3310
{
    class OtvoriNoviForm
    {
        private Form noviForm;

        public OtvoriNoviForm(Form noviForm)
        {
            this.noviForm = noviForm;
        }

        public void Otvori()
        {
            noviForm.Show();
            noviForm.BackColor = Color.LimeGreen;
            noviForm.Size = new Size(800, 470);
            noviForm.Location = new Point(260, 273);
        }
    }
}
