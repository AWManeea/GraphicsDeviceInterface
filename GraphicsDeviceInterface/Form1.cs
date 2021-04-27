using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsDeviceInterface
{
    public partial class Form1 : Form
    {
        class Liner
        {
            public bool Clicked { get; set; }
            public int X1 { get; set; }
            public int X2 { get; set; }
            public int Y1 { get; set; }
            public int Y2 { get; set; }

            public void Reset()
            {
                X1 = -1;
                X2 = -1;
                Y1 = -1;
                Y2 = -1;
            }
        }
        Liner liner;
        List<Liner> prevLines = new List<Liner>();
        int x = 0, y = 0;
        public Form1()
        {
            InitializeComponent();
            liner = new Liner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.liner.Clicked)
            {
                this.liner.X2 = e.X;
                this.liner.Y2 = e.Y;
                this.Invalidate();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.liner.Clicked)
            {
                this.liner.X2 = e.X;
                this.liner.Y2 = e.Y;
                this.prevLines.Add(this.liner);
                this.liner = new Liner();
                this.Invalidate();
            } else
            {
                this.liner.X1 = e.X;
                this.liner.Y1 = e.Y;
                this.liner.Clicked = !this.liner.Clicked;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(Color.DarkGray, 3), liner.X1, liner.Y1, liner.X2, liner.Y2);
            foreach (var line in this.prevLines)
                g.DrawLine(new Pen(Color.Black, 5), line.X1, line.Y1, line.X2, line.Y2);

        }
    }
}
