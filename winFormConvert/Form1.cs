using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace winFormConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbtChf.Select();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtChf.Text = "0";
            txtEur.Text = "0";
        }

        private const double eurChfRate = 1.09;
        private void btnConvert_Click(object sender, EventArgs e)
        {
                if (rbtChf.Checked )
                {
                    double eur;
                    if (double.TryParse(txtEur.Text, out eur))
                    {
                        double chf = eur * eurChfRate;
                        txtChf.Text = chf.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Blah!!");
                    }

                } else
                {

                    double chf;
                    if (double.TryParse(txtChf.Text, out chf))
                    {
                        double eur = chf / eurChfRate;
                        txtEur.Text = eur.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Blah!!");
                    }                   
                }
      
        }

        private void rbtChf_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtChf.Checked)
            {
                txtChf.Enabled = false;
                txtEur.Enabled = true;
            }
        }

        private void rbtEur_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEur.Checked)
            {
                txtEur.Enabled = false;
                txtChf.Enabled = true;
            }
        }

        private void txtChf_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.Print(e.ToString());
            
        }
    }
}
