using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsDeviceInterface
{
    public abstract class Shape
    {
        public int x1, x2, y1, y2;
        public ShapeType type;
        public bool isSelected;
        public Pen pen;
        public ShapeType Type { get; }
        public int Height { get { return this.y2 - this.y1; } }
        public int Width { get { return this.x2 - this.x1; } }
        public bool IsSelected { get; }
        public Color Color { get
            {
                return pen.Color;
            }
            set
            {
                pen.Color = value;
            }
        }
        public DashStyle DashStyle
        {
            get
            {
                return pen.DashStyle;
            }
            set
            {
                pen.DashStyle = value;
            }
        }
        public float Thickness
        {
            get
            {
                return pen.Width;
            }
            set
            {
                pen.Width = value;
            }
        }
        public abstract void Draw(Graphics g, bool preview = false);
        public void Relocate()
        {
            //TODO: implement me
            throw new Exception("Implement me");
        }
        public void Resize()
        {
            //TODO: implement me
            throw new Exception("Implement me");
        }
        public Shape()
        {

        }
    }

    public enum ShapeType
    {
        Line,
        Ellipse,
        Rectangle
    }

}