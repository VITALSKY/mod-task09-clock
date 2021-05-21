using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _9_laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DateTime dt = DateTime.Now;
            Pen cir_pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Indigo);
            Graphics g = e.Graphics;
            GraphicsState gs;
            RectangleF rectf12 = new RectangleF(475,75 ,250, 250);
            g.DrawString("12", new Font("Tahoma", 25), Brushes.Black, rectf12);
            ;
            RectangleF rectf1 = new RectangleF(700, 110, 250, 250);
            g.DrawString("1", new Font("Tahoma", 25), Brushes.Black, rectf1);
            RectangleF rectf11 = new RectangleF(250, 110, 250, 250);
            g.DrawString("11", new Font("Tahoma", 25), Brushes.Black, rectf11);
            RectangleF rectf10 = new RectangleF(90, 240, 250, 250);
            g.DrawString("10", new Font("Tahoma", 25), Brushes.Black, rectf10);
            RectangleF rectf2 = new RectangleF(870, 240, 250, 250);
            g.DrawString("2", new Font("Tahoma", 25), Brushes.Black, rectf2);
            RectangleF rectf3 = new RectangleF(925, 425, 250, 250);
            g.DrawString("3", new Font("Tahoma", 25), Brushes.Black, rectf3);
            RectangleF rectf9 = new RectangleF(60, 425, 250, 250);
            g.DrawString("9", new Font("Tahoma", 25), Brushes.Black, rectf9);
            RectangleF rectf8 = new RectangleF(115, 600, 250, 250);
            g.DrawString("8", new Font("Tahoma", 25), Brushes.Black, rectf8);
            RectangleF rectf4 = new RectangleF(850, 600, 250, 250);
            g.DrawString("4", new Font("Tahoma", 25), Brushes.Black, rectf4);
            RectangleF rectf5 = new RectangleF(700, 725, 250, 250);
            g.DrawString("5", new Font("Tahoma", 25), Brushes.Black, rectf5);
            RectangleF rectf7 = new RectangleF(275, 725, 250, 250);
            g.DrawString("7", new Font("Tahoma", 25), Brushes.Black, rectf7);
            RectangleF rectf = new RectangleF(485, 775, 250, 250);
            g.DrawString("6", new Font("Tahoma", 25), Brushes.Black, rectf);
            g.TranslateTransform(Width / 2, Height / 2);
            g.ScaleTransform(Width / 200, Height / 200);
            g.DrawEllipse(cir_pen, -80, -80, 160, 160);
            
            Brush br = new SolidBrush(Color.Aqua);
            var path = new GraphicsPath();
            path.AddEllipse(new RectangleF(-80, -80, 160, 160));
            g.FillPath(br, path);
            gs = g.Save();
            g.Restore(gs);
            for (int i = 0; i < 60; i++)
            {
                g.RotateTransform(6 * i);
                Pen p = new Pen(Color.Blue, 1);
                Pen q = new Pen(Color.Black, 1);
                if (i % 5 != 0)
                {
                    Point p1 = new Point(-75, 0);// первая точка
                    Point p2 = new Point(-80, 0);// вторая точка
                    g.DrawLine(p, p1, p2);// рисуем линию
                }
                else
                {
                    Point q1 = new Point(-70, 0);// первая точка
                    Point q2 = new Point(-80, 0);// вторая точка
                    g.DrawLine(q, q1, q2);// рисуем линию
                    
                }
                g.Restore(gs);
                gs = g.Save();
            }
            g.RotateTransform(6 * (dt.Minute + (float)dt.Second / 60));
            g.DrawLine(new Pen(new SolidBrush(Color.Violet), 4), 0, 0, 0, -55);
            g.Restore(gs);
            gs = g.Save();
            g.RotateTransform(30 * (dt.Hour + (float)dt.Minute / 60)+(float)dt.Second / (60*60));
            g.DrawLine(new Pen(new SolidBrush(Color.Black), 4), 0, 0, 0, -40);
            g.Restore(gs);
            g.RotateTransform(6 * (float)dt.Second);
            g.DrawLine(new Pen(new SolidBrush(Color.Green), 2), 0, 0, 0, -67);

            gs = g.Save();
            g.Restore(gs);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            label1.Text = DateTime.Now.ToString("T");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Width = 1000;
            Height = 1000;
        }
    }
}
