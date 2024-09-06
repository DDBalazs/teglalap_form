using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teglalap
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btszamol_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txa.Text);
            int b = Convert.ToInt32(txb.Text);
            int ker = 2*(a+b);
            int ter = a * b;
            lbmegoa.Text = "A téglalap területe: " + ker + "cm";
            lbmegob.Text = "A téglalap területe: " + ter + "cm2";
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            lbmegoa.Text = "";
            lbmegob.Text = "";
        }
    }
}
