using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nokia3310
{
    class DateInfo
    {
        public string GetCurrentDateTime()
        {
            return (DateTime.Today).ToShortDateString() + "       " + String.Format("{0:HH:mm:ss}", DateTime.Now);
        }
    }
}
