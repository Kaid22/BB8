using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace bb8
{
    class BB8
    {
        int x, y, a;
        public void Postavi(int x, int y, int a)
        {
            this.x = x;
            this.y = y;
            this.a = a;
        }
        public void Crtaj(Graphics g)
        {
            Random r = new Random();
            Pen pen = new Pen(Color.Black, 3);
            SolidBrush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            g.FillEllipse(brush, x - a / 4, y + a / 4, a / 2, a / 2);
            g.DrawEllipse(pen, x - a / 4, y + a / 4, a / 2, a / 2);
            g.FillEllipse(new SolidBrush(Color.Black), x - a / 16, y - 3 * (a / 16), a / 8, a / 8);
            g.DrawArc(pen, x - a / 4, y - a / 4, a / 2, a / 2, 180, 180);
            g.DrawEllipse(pen, x - a / 2, y, a, a);
            g.DrawLine(pen, x - a / 4, y, x + a / 4, y);
            g.DrawLine(pen, x, y - a / 4, x, y - 3 * a / 8);

        }
        public void Pomeri(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
    }
}
