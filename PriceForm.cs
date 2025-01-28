using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkAndDarkerFavorite
{
    public partial class PriceForm : Form
    {
        private System.Windows.Forms.Timer tmr;
        public PriceForm(string price)
        {
            InitializeComponent();

            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate
            {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(4).TotalMilliseconds;
            tmr.Start();

            PriceLabel.Text = price;
        }

        private void PriceForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
