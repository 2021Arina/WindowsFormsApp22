using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int Radius = 50;
            Graphics g = pictureBox1.CreateGraphics(); // создание рисунка
            g.Clear(Color.LightCyan);
            SolidBrush Cloud = new SolidBrush(Color.LightSkyBlue);
            SolidBrush Cl = new SolidBrush(Color.White);
            SolidBrush Sun = new SolidBrush(Color.Yellow); 
            SolidBrush Corp = new SolidBrush(Color.DarkMagenta);
            SolidBrush Trum = new SolidBrush(Color.DarkOrchid);
            SolidBrush Truba = new SolidBrush(Color.DeepPink);
            SolidBrush Smoke = new SolidBrush(Color.DarkGray);
            SolidBrush Seа = new SolidBrush(Color.DeepSkyBlue);
            Pen Window = new Pen(Color.Yellow, 2); 
            g.DrawLine(Pens.Yellow, 700, 50, 650, 30); 
            g.DrawLine(Pens.Yellow, 680, 80, 650, 80);
            g.DrawLine(Pens.Yellow, 690, 100, 650, 130);
            g.DrawLine(Pens.Yellow, 720, 120, 690, 150);
            g.DrawLine(Pens.Yellow, 750, 130, 730, 190);
            g.DrawLine(Pens.Black, 680, 180, 680, 300);
            g.FillEllipse(Smoke, 500, 80, 45, 100);
            g.FillEllipse(Smoke, 530, 70, 25, 20);
            g.FillEllipse(Cloud, 100, 50, 200, 70);
            g.FillEllipse(Cl, 190, 60, 60, 25);
            g.FillEllipse(Cloud, 400, 50, 100, 50);
            g.FillEllipse(Cl, 440, 55, 40, 20);
            g.FillEllipse(Cloud, 530, 20, 110, 50);
            g.FillEllipse(Sun, 700, 50, 70, 70);
            g.FillRectangle(Truba, 300, 125, 75, 75); 
            g.FillRectangle(Truba, 480, 125, 75, 75);
            
            g.FillPolygon(Corp, new Point[]  
              {
                   new Point(100,300),new Point(700,300),
                   new Point(700,300),new Point(600,400),
                   new Point(600,400),new Point(200,400),
                   new Point(200,400),new Point(100,300)
              }
            );
            g.FillRectangle(Trum, 250, 200, 350, 100);
            for (int i = 0; i < 25; i++)
                g.DrawLine(new Pen(Brushes.Black, 1),
                250, 4 * i + 202, 598, 4 * i + 202);
            for (int i = 0; i < 45; i++)
                g.DrawLine(new Pen(Brushes.Cyan, 3),
                0, 4 * i + 400, 900, 4 * i + 400);
            while (x <= pictureBox1.Width - Radius)
            {
                g.FillPie(Seа, 10 + x, 375, 50, 60, 0, -180);
                x += 40;
            }
            for (int y = 300; y <= 550; y += 60)
            {
                g.DrawEllipse(Window, y, 240, 15, 15);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics(); // очистка рисунка
            g.Clear(Color.White);
        }
    }
}
