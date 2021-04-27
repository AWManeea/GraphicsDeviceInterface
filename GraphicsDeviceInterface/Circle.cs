using System;
using System.Drawing;

namespace GraphicsDeviceInterface
{
    public class Circle : Shape
    {
        public Circle(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.type = ShapeType.Ellipse;
            pen = new Pen(Color.Black, 5);

        }

        public override void Draw(Graphics g, bool preview = false)
        {
            if (preview)
                g.DrawEllipse(new Pen(Color.DarkGray, 3), x1, y1, x2-x1, y2-y1);
            else
                g.DrawEllipse(this.pen, x1, y1, x2-x1, y2-y1);

        }
    }

}
