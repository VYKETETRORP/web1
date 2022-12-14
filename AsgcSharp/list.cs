using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuCircleProgress.Transitions;

namespace AsgcSharp
{
    public partial class list : UserControl
    {
        public list()
        {
            InitializeComponent();
            
        }
        private string _title;
        private Image _icon;
        private String _cost;


        [Category("Custom Props")]
        public string Title { 

            get { return _title; }
            set { _title = value; lbltitle.Text = value; }
        
        }
        [Category("Custom Props")]

        public String Cost
        {
            get { return _cost; }
            set { _cost = value; lblcost.Text = value; }
        }
        [Category("Custom Props")]

        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value; imgImage.Image = value;
            }
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
