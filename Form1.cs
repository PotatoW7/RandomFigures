using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RandomFigures
{
    public partial class Form1 : Form
    {
        private class MyFigure
        {
            public string Type; // "rectangle", "triangle", "circle"
            public Rectangle Rect;
            public Point[] TrianglePoints;
            public Color Color;
        }

        private List<MyFigure> figures = new();
        private Random rand = new();
        private string lastActiveTimer = ""; // За Resume/Stop логиката

        public Form1()
        {
            InitializeComponent();
            btnStop.Text = "Stop";
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            StopAllTimers();
            AddRectangle();
            timerRec.Start();
            lastActiveTimer = "rectangle";
            btnStop.Text = "Stop";
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            StopAllTimers();
            AddTriangle();
            timerTri.Start();
            lastActiveTimer = "triangle";
            btnStop.Text = "Stop";
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            StopAllTimers();
            AddCircle();
            timerCir.Start();
            lastActiveTimer = "circle";
            btnStop.Text = "Stop";
        }

        // Stop/Resume бутон
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (btnStop.Text == "Stop")
            {
                StopAllTimers();
                btnStop.Text = "Resume";
            }
            else // Resume
            {
                if (lastActiveTimer == "rectangle")
                    timerRec.Start();
                else if (lastActiveTimer == "triangle")
                    timerTri.Start();
                else if (lastActiveTimer == "circle")
                    timerCir.Start();
                btnStop.Text = "Stop";
            }
        }

        // Clear All бутон
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            figures.Clear();
            Invalidate();
        }

        private void StopAllTimers()
        {
            timerRec.Stop();
            timerTri.Stop();
            timerCir.Stop();
        }

        private void timerRec_Tick(object sender, EventArgs e)
        {
            AddRectangle();
        }

        private void timerTri_Tick(object sender, EventArgs e)
        {
            AddTriangle();
        }

        private void timerCir_Tick(object sender, EventArgs e)
        {
            AddCircle();
        }

        // Генерира случаен цвят
        private Color GetRandomColor()
        {
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void AddRectangle()
        {
            int maxW = ClientSize.Width - 120;
            int maxH = ClientSize.Height;
            int w = rand.Next(30, Math.Max(31, maxW / 2));
            int h = rand.Next(30, Math.Max(31, maxH / 2));
            int x = rand.Next(0, Math.Max(1, maxW - w));
            int y = rand.Next(0, Math.Max(1, maxH - h));

            figures.Add(new MyFigure
            {
                Type = "rectangle",
                Rect = new Rectangle(x, y, w, h),
                Color = GetRandomColor()
            });
            Invalidate();
        }

        private void AddTriangle()
        {
            int maxW = ClientSize.Width - 120;
            int maxH = ClientSize.Height;
            Point p1 = new(rand.Next(0, Math.Max(1, maxW)), rand.Next(0, Math.Max(1, maxH)));
            Point p2 = new(rand.Next(0, Math.Max(1, maxW)), rand.Next(0, Math.Max(1, maxH)));
            Point p3 = new(rand.Next(0, Math.Max(1, maxW)), rand.Next(0, Math.Max(1, maxH)));
            figures.Add(new MyFigure
            {
                Type = "triangle",
                TrianglePoints = new[] { p1, p2, p3 },
                Color = GetRandomColor()
            });
            Invalidate();
        }

        private void AddCircle()
        {
            int maxW = ClientSize.Width - 120;
            int maxH = ClientSize.Height;
            int d = rand.Next(30, Math.Max(31, Math.Min(maxW, maxH) / 2));
            int x = rand.Next(0, Math.Max(1, maxW - d));
            int y = rand.Next(0, Math.Max(1, maxH - d));
            figures.Add(new MyFigure
            {
                Type = "circle",
                Rect = new Rectangle(x, y, d, d),
                Color = GetRandomColor()
            });
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var fig in figures)
            {
                switch (fig.Type)
                {
                    case "rectangle":
                        e.Graphics.FillRectangle(new SolidBrush(fig.Color), fig.Rect);
                        break;
                    case "triangle":
                        if (fig.TrianglePoints != null)
                            e.Graphics.FillPolygon(new SolidBrush(fig.Color), fig.TrianglePoints);
                        break;
                    case "circle":
                        e.Graphics.FillEllipse(new SolidBrush(fig.Color), fig.Rect);
                        break;
                }
            }
        }
    }
}