using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Resource1._33784279_1822572257802113_7511777292511608832_n;
            label1.Text = "YES YES YES !";
            label2.Text = "Monster In The Bank";
            label3.Text = "PHENOMINAL";
            button1.Text = "It's My Yard";
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
