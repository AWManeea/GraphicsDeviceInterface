using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsDeviceInterface
{
    public abstract class Shape
    {
        private int x1, x2, y1, y2;
        private readonly ShapeType type;
        private bool isSelected;
        private Pen pen;
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
        public abstract void Draw(int x2, int y2);
        public abstract void Preview(int x2, int y2);
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
        
        public Shape(int x1, int y1, ShapeType type)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.type = type;
            pen = new Pen(Color.Black, 5);
        }
    }

    public enum ShapeType
    {
        Line,
        Ellipse,
        Rectangle
    }
}