using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Point click;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackpen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
            g = CreateGraphics();
            g.Clear(Color.Azure);
            g.FillEllipse(Brushes.Black, 100, 100, 120, 120);
            g.FillEllipse(Brushes.Black, 300, 100, 120, 120);
            g.FillEllipse(Brushes.Black, 145, 150, 230, 230);
            g.FillEllipse(Brushes.White, 180, 170, 90, 160);
            g.FillEllipse(Brushes.White, 180, 240, 160, 160);
            g.FillEllipse(Brushes.White, 180, 240, 160, 160);
            g.FillEllipse(Brushes.White, 140, 240, 230, 160);
            g.FillEllipse(Brushes.White, 250, 170, 90, 160);
            g.DrawEllipse(blackpen, 264, 210, 38, 95);
            g.DrawEllipse(blackpen, 216, 210, 38, 95);
            g.DrawArc(blackpen, 214, 300, 90, 40, 200,140);
            g.FillEllipse(Brushes.Black, 230, 275, 17, 30);
            g.FillEllipse(Brushes.Black, 271, 275, 17, 30);
            g.FillEllipse(Brushes.Black, 220, 305, 75, 40);
            g.DrawArc(blackpen, 330, 264, 40, 90, 260, 160);
            g.DrawArc(blackpen, 187, 228, 180, 180, 370, 70);
            g.DrawArc(blackpen, 146, 270, 40, 90, 130, 140);
            g.DrawArc(blackpen, 146, 228, 180, 180, 460, 70);
            g.DrawArc(blackpen, 205, 250, 105, 180, 420, 60);
            g.DrawArc(blackpen, 205, 220, 105, 180, 405, 90);
            g.DrawArc(blackpen, 185, 265, 150, 100, 370, 160);
            g.DrawArc(blackpen, 170, 328, 50, 20, 200, 120);
            g.DrawArc(blackpen, 310, 328, 50, 20, 200, 120);
            g.DrawArc(blackpen, 212, 370, 50, 20, 200, 160);
            g.DrawArc(blackpen, 250, 370, 50, 20, 200, 140);
        }

        /*private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            g.DrawEllipse(Pens.Black, click.X, click.Y, 200, 200);
        }*/
    }
}
