using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Binary
{
    public partial class Total : Form
    {
        int total = 0;
        int[] bits = new int[8];
        public Total()
        {
            InitializeComponent();
        }

        private void Calc()
        {
            total = 0;
            if (bits[0] != 0) total += 1;
            if (bits[1] != 0) total += 2;
            if (bits[2] != 0) total += 4;
            if (bits[3] != 0) total += 8;
            if (bits[4] != 0) total += 16;
            if (bits[5] != 0) total += 32;
            if (bits[6] != 0) total += 64;
            if (bits[7] != 0) total += 128;
            TotalLabel.Text = total.ToString();
        }
        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bit8_TextChanged(object sender, EventArgs e)
        {
            //bit1
            if (bit1.Text == "1")
            {
                bits[0] = 1;
            }
            else
            {
                bits[0] = 0;
            }
            //bit2
            if (bit2.Text == "1")
            {
                bits[0] = 1;
            }
            else
            {
                bits[2] = 0;
            }

            //bit4
            if (bit4.Text == "1")
                bits[3] = 1;
            else
                bits[3] = 0;
            //bit5

            Calc();
        }
    }
}

        
