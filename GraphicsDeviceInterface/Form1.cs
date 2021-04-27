using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            foreach (var item in PaintToolsStrip.Items)
                if(item.GetType().Equals(typeof(ToolStripButton)))
                    ((ToolStripButton)item).Checked = false;
            

            switch (e.ClickedItem.Text)
            {
                case "Circle":
                    this.selectedTool = ShapeType.Ellipse;
                    return;
                case "Rectangle":
                    this.selectedTool = ShapeType.Rectangle;
                    return;
                case "Line":
                    this.selectedTool = ShapeType.Line;
                    return;
                case "Resize":
                    this.selectedTool = ShapeType.Line;
                    return;
                default:
                    this.selectedTool = ShapeType.Line;
                    return;
            }
        }
        private Shape getShape(int x1, int y1, ShapeType type)
        {
            if (type == ShapeType.Ellipse) return new Line(x1, y1);
            else if (type == ShapeType.Rectangle) return new Line(x1, y1);
            else return new Line(x1, y1);
        }
    }
}
