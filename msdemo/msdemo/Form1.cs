using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        bool flag = false; 

        private void button1_Down(object sender, MouseEventArgs e)
        {
                                    if (e.Button == MouseButtons.Right)
            {
                       if (!flag)
                    button1.BackgroundImage = pictureBox2.Image;
                else
                    button1.BackgroundImage = null;
                flag = !flag; 
            }
            if (e.Button == MouseButtons.Left)
                button1.BackgroundImage = pictureBox1.Image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tile t = new tile(); 
       
        }
    }
}
