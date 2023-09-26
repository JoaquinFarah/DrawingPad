using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float PointX = 0;
        float PointY = 0;

        float LastX = 0;
        float LastY = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = panel1.CreateGraphics();
            G.DrawLine(Pens.Blue, PointX, PointY, LastX, LastY);   
            LastX = PointX;
            LastY = PointY; 

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastX = e.X;
            LastY = e.Y;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                PointX = e.X;
                PointY = e.Y;
                panel1_Paint(this, null);

        }
    }
}
