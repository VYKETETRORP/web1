using AsgcSharp.components;
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

namespace AsgcSharp
{
    public partial class mainform : Form
    {
        public mainform()
        {

            InitializeComponent();
            
        }

        private void docker_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()


        {
            //list[] listItems = new list[20];
            //for (int i = 0; i < listItems.Length; i++)
            //{
            //    listItems[i].Title = "Get Data";
            //    listItems[i].Cost = "7.57";
            //    pnl.Controls.Clear();
            //    pnl.Controls.Add(listItems[i]);
            //}
            list[] listItems = new list[20];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i].Title = "Get Data";
                listItems[i].Cost = "7.57";
                pnl.Controls.Clear();
                pnl.Controls.Add(listItems[i]);
            }







        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void wiget4_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void wiget7_Load(object sender, EventArgs e)
        {

        }

        private void wiget1_Load(object sender, EventArgs e)
        {

        }

        private void wiget2_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void wiget2_Load_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            docker.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;


        }
        public void AddItems (String name, double cost, gategories gategory, Image icon)
        {
            bunifuPanel1.Controls.Add(new wiget()
            {
                title=name,
                cost=cost,
                category=gategory,
                icon=icon,

            });
        }

        private void mainform_Shown(object sender, EventArgs e)
        {
            AddItems("Cofee", 5.5, gategories.Coffe, "cofe.jpg");
            AddItems("Cofee", 5.5, gategories.Coffe, "cofe.jpg");

            AddItems("Cofee", 5.5, gategories.Coffe, "cofe.jpg");

            AddItems("Cofee", 5.5, gategories.Coffe, "cofe.jpg");

            AddItems("Cofee", 5.5, gategories.Tea, "cofe.jpg");

            AddItems("Cofee", 5.5, gategories.Coffe, "cofe.jpg");

            AddItems("Cofee", 5.5, gategories.Coffe, "cofe.jpg");



        }

        private void AddItems(string v1, double v2, gategories coffe, string v3)
        {
            throw new NotImplementedException();
        }

        private void SearchItem_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in pnl.Controls)

            {
                var wgt = (wiget)item;
                wgt.Visible = wgt.name.Text.ToLower().ToLower().Contains(SearchItem.Text.Trim().ToLower());
            }
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
