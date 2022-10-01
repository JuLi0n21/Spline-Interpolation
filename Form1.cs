using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image = canvas.CreateGraphics();
        }

        Pen whitepen = new Pen(Color.White);

        Pen graypenpen = new Pen(Color.DarkGray);

        Pen bluepen = new Pen(Color.Blue);

        Graphics Image = null;

        Point[] points = new Point[10];

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
           
        }

        public void draw_Lines(Point[] points) 
        {
            Image.DrawLines(whitepen, points);

        }

        public void draw_Kubischer_Spline()
        {
            for (int i = 0; i < canvas.Height; i++) 
            {
                Image.DrawLine(whitepen, canvas.Width, i, 0, i);
            }
        }

        public void draw_Cosine_Spline(Point[] points)
        {

        }

        public void draw_naechster_nachtbar(Point[] points)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void run_linear_Click(object sender, EventArgs e)
        {
            draw_Kubischer_Spline();
        }

        private void run_cosine_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < canvas.Width; i++)
            {
                Image.DrawLine(bluepen, i, canvas.Height, i, 0);
            }
        }

        private void run_cubic_Click(object sender, EventArgs e)
        {
            while (true)
            {
                for (int i = 0; i < canvas.Width; i++)
                {
                    Image.DrawLine(bluepen, i, canvas.Height, i, 0);
                }
                draw_Kubischer_Spline();
            }
        }

        private void run_neibourg_Click(object sender, EventArgs e)
        {

        }

        private void add_point_Click(object sender, EventArgs e)
        {
            if (txt_x.Text != "" && txt_y.Text != "")
            {
                Point xy = new Point(int.Parse(txt_x.Text), int.Parse(txt_y.Text));
                Image.DrawLine(whitepen, xy, xy);
            }
        }

        private void draw_grid(Point Xmax, Point Xmin, Point Ymin, Point Ymax)
        {

        }

        private void canvas_RegionChanged(object sender, EventArgs e)
        {

        }

        private void canvas_Resize(object sender, EventArgs e)
        {
            Image = canvas.CreateGraphics();
        }
    }
}
