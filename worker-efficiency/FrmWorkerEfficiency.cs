using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worker_efficiency
{
    public partial class FrmWorkerEfficiency : Form
    {
        public FrmWorkerEfficiency()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int hours = 0;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            hours = int.Parse(txtWorkerEfficiency.Text);

            if(hours >= 2 && hours < 3)
            {
                lblResult.Text = "You are highly efficient";
                lblResult.Visible = true;
            }
            if (hours >= 3 && hours < 4)
            {
                lblResult.Text = "Increase your speed";
                lblResult.Visible = true;
            }
            if (hours >= 4 && hours < 5)
            {
                lblResult.Text = "Your rubbish and need extra training";
                lblResult.Visible = true;
            }
            if (hours >= 5)
            {
                lblResult.Text = "YOUR SACKED - get out of the company...SECURITY!";
                lblResult.Visible = true;
            }
        }
    }
}
