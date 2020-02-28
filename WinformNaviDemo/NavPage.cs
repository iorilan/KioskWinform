using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformNaviDemo
{
    public class NavPage
    {
        public Form Current { get; set; }
        public Button Pre { get; set; }
        public Button Next { get; set; }
    }
}
