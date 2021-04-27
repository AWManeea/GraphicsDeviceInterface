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
        List<Shape> shapes = new List<Shape>();
        Shape currentShape = null;
        ShapeType selectedTool;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentShape != null)
            {
                currentShape.x2 = e.X;
                currentShape.y2 = e.Y;
                this.Invalidate();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentShape == null)
            {
                currentShape = getShape(e.X, e.Y, selectedTool);
            }
            else
            {
                shapes.Add(currentShape);
                currentShape = null;
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var shape in shapes)
                shape.Draw(g);
            if (currentShape != null)
                currentShape.Draw(g, true);
        }

        private void PaintToolsStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            LineButton.Checked = false;
            CircleButton.Checked = false;
            RectangleButton.Checked = false;
            switch (e.ClickedItem.Text)
            {
                case "Circle":
                    CircleButton.Checked = true;
                    this.selectedTool = ShapeType.Ellipse;
                    break;
                case "Rectangle":
                    RectangleButton.Checked = true;
                    this.selectedTool = ShapeType.Rectangle;
                    break;
                default:
                    LineButton.Checked = true;
                    this.selectedTool = ShapeType.Line;
                    break;
            }
        }
        private Shape getShape(int x1, int y1, ShapeType type)
        {
            if (type == ShapeType.Ellipse) return new Circle(x1, y1);
            else if (type == ShapeType.Rectangle) return new Line(x1, y1);
            else return new Line(x1, y1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
