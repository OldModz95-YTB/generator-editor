using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generateur1
{
    public partial class DevDuTool : Form
    {
        public DevDuTool()
        {
            InitializeComponent();
            timer1.Start(); // start timer 1 and color label !
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random labelcolor = new Random(); // effect^^
            int R = labelcolor.Next(0, 255); // color
            int G = labelcolor.Next(0, 255); // color
            int B = labelcolor.Next(0, 255); // color
            int A = labelcolor.Next(0, 255); // color
            label1.ForeColor = Color.FromArgb(R, G, B, A); // name label
            label2.ForeColor = Color.FromArgb(R, G, B, A); // name label
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            base.Hide();
            new Form1().Show();
        }
    }
}
