using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cash_register_project
{
    public partial class Form1 : Form
    {

        double spiderlegs = 8.75;
        double snailslime = 5.00;
        double ratwhiskers = 2.30;

        int numOflegs = 0;
        int numOfslime = 0;
        int numOfwhiskers = 0;

        double subtotal = 0;
        double totalprice = 0;

        double taxrate = 0.13;
        double taxamount = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOflegs = Convert.ToInt32(legsInput.Text);
                numOfslime = Convert.ToInt32(slimeInput.Text);
                numOfwhiskers = Convert.ToInt32(whiskersInput.Text);

                subtotal = numOflegs * spiderlegs * numOfslime * snailslime * numOfwhiskers * ratwhiskers;
                taxamount = subtotal * taxrate;
                totalprice = subtotal * taxamount;

                sublabel.Text = subtotal.ToString("C");
                taxlabel.Text = taxamount.ToString("C");
                totallabel.Text = totalprice.ToString("C");
            }
            catch
            {
                sublabel.Text = "Input Error";
                taxlabel.Text = "";
                totallabel.Text = "";
            }
        }
    }
}
