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
        ShapeType selectedShape;
        ToolType selectedTool;
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
            if(this.selectedTool == ToolType.Resizer)
            {
                Shape s = getSelectedItem(e.X, e.Y);
                if (s != null)
                {

                    currentShape = getShape(s.x1, s.y1, s.type);
                    shapes.Remove(s);
                    this.selectedTool = ToolType.Liner;
                    this.selectedShape = ShapeType.Line;
                    LineButton.Checked = true;
                    foreach (var item in PaintToolsStrip.Items)
                        if (item.GetType().Equals(typeof(ToolStripButton)))
                            ((ToolStripButton)item).Checked = false;

                    this.Invalidate();
                }
            }
            else if (this.selectedTool == ToolType.ColorPicker)
            {
                // TYPE COLOR PICKER LOGIC HERE
            }
            else if (currentShape == null)
            {
                currentShape = getShape(e.X, e.Y, selectedShape);
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
                    this.selectedShape = ShapeType.Ellipse;
                    this.selectedTool = ToolType.Ellipser;
                    return;
                case "Rectangle":
                    this.selectedShape = ShapeType.Rectangle;
                    this.selectedTool = ToolType.Rectangler;
                    return;
                case "Line":
                    this.selectedShape = ShapeType.Line;
                    this.selectedTool = ToolType.Liner;
                    return;
                case "Resize":
                    this.selectedTool = ToolType.Resizer;
                    return;
                case "Relocate":
                    this.selectedTool = ToolType.Relocator;
                    return;
                case "ColorPicker":
                    this.selectedTool = ToolType.ColorPicker;
                    return;
                default:
                    this.selectedShape = ShapeType.Line;
                    return;
            }
        }
        
        private Shape getShape(int x1, int y1, ShapeType type)
        {
            if (type == ShapeType.Ellipse) return new Circle(x1, y1);
            else if (type == ShapeType.Rectangle) return new Rectan(x1, y1);
            else return new Line(x1, y1);
        }

        private Shape getSelectedItem(int x, int y)
        {
            foreach (var item in shapes)
            {
                if (PointInShape(x, y, item))
                    return item;
            }
            return null;
        }

        private bool PointInShape(int x, int y, Shape s) 
        {
            return (x > s.x1 && x < s.x2 && y > s.y1 && y < s.y2);
        }

    }
}
