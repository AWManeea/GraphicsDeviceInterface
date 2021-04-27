using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphicsDeviceInterface
{
    public class Rectan: Shape
    {
        public Rectan(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.type = ShapeType.Rectangle;
            pen = new Pen(Color.Black, 5);
        }
        public override void Draw(Graphics g, bool preview = false)
        {
           if (preview)
                g.DrawRectangle(new Pen(Color.DarkGray, 3), x1, y1, Width, Height);
           else
                g.DrawRectangle(this.pen, x1, y1, Width, Height);

        }
    }
}
