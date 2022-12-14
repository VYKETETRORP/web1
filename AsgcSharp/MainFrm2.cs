using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsgcSharp
{
    public partial class MainFrm2 : Form
    {
        public MainFrm2(String _name, String _per)
        {
            InitializeComponent();
            if(_per == "admin")
            {

            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }

        }
    }
}
