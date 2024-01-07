using System;
using System.Drawing;
using System.Windows.Forms;

namespace bne
{
    public partial class Form1 : Form
    {
        private Color selectedColor;
        private int selectedSize = 2;
        private Point previousPoint;

        public Form1()
        {
            InitializeComponent();
            DrawingPanel.Paint += DrawingPanel_Paint;
            DrawingPanel.MouseDown += DrawingPanel_MouseDown;
            DrawingPanel.MouseMove += DrawingPanel_MouseMove;
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Pen pen = new Pen(selectedColor, selectedSize))
                {
                    g.DrawLine(pen, previousPoint, e.ClipRectangle.Location);
                    previousPoint = e.ClipRectangle.Location;
                }
            }
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            previousPoint = e.Location;
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = DrawingPanel.CreateGraphics())
                {
                    using (Pen pen = new Pen(selectedColor, selectedSize))
                    {
                        g.DrawLine(pen, previousPoint, e.Location);
                        previousPoint = e.Location;
                    }
                }
            }
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = Color.Red;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = Color.Blue;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = Color.Black;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            selectedSize = 2;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            selectedSize = 5;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            selectedSize = 10;
        }
    }
}


