using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsgcSharp.components
{
    public enum gategories { Coffe, Tea, Light, Milk, Chocolate, Juice }

    public partial class wiget : UserControl
    {
        private gategories _gategories;
        private double _cost;
        public event EventHandler OnSelect = null;
        public wiget()
        {
            InitializeComponent();
        }
        public double cost { get => _cost; set => _cost = value; }


        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this,e);
        }
        
        public gategories category { get => _gategories; set => _gategories = value; }
        public string title { get => name.Text; set => name.Text = value; }
        public Image icon { get=>imgImage.Image; set => imgImage.Image = value; }
    }
}
