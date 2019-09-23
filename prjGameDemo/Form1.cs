using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjGameDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;
            if(e.KeyValue == 39)
            {
                pic.Image = picRight.Image;
                pic.Left += speed;

            }
            if (e.KeyValue == 37)
            {
                pic.Image = picLeft.Image;
                pic.Left -= speed;

            }
            if (e.KeyValue == 40)
            {
                pic.Image = picDown.Image;
                pic.Top += speed;
            }
            if (e.KeyValue == 38)
            {
                pic.Image = picUp.Image;
                pic.Top -= speed;
            }

        }
    }
}
