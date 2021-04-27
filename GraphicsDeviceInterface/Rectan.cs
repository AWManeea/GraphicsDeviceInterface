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

            int width = Width;
            int x = x1;

            if (width < 0)
            {
                width = Math.Abs(width);
                x = x2;
            }

            int height = Height;
            int y = y1;

            if (height < 0)
            {
                height = Math.Abs(height);
                y = y2;
            }


            if (preview)
                g.DrawRectangle(new Pen(Color.DarkGray, 3), x, y, width, height);
            else
            {
                g.DrawRectangle(this.pen, x, y, width, height);
                if (y == y2)
                {
                    this.y2 = this.y1;
                    this.y1 = y;
                }
                if (x == x2)
                {
                    this.x2 = this.x1;
                    this.x1 = x;
                }
            }

        }
    }
}
