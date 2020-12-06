using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bb8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool pomeranje = false;
        BB8 bb1,bb2,bb3,bb4,bb5,bb6,bb7,bb8,bb9,bb10;

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            pomeranje = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pomeranje)
            {
                bb1.Pomeri(3, 0);
                bb2.Pomeri(3, 0);
                bb3.Pomeri(3, 0);
                bb4.Pomeri(3, 0);
                bb5.Pomeri(3, 0);
                bb6.Pomeri(3, 0);
                bb7.Pomeri(3, 0);
                bb8.Pomeri(3, 0);
                bb9.Pomeri(3, 0);
                bb10.Pomeri(3, 0);
                Refresh();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Randomiser();
            timer1.Start();
        }
        int a=100;
        Random r = new Random();
        private void Randomiser()
        {
            int x = r.Next(ClientRectangle.Width);
            int y = r.Next(ClientRectangle.Height);
            bb1 = new BB8();
            bb1.Postavi(x, y,a);

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            bb2 = new BB8();
            bb2.Postavi(x, y, a);

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            bb3 = new BB8();
            bb3.Postavi(x, y, a);

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            bb4 = new BB8();
            bb4.Postavi(x, y, a);

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            bb5 = new BB8();
            bb5.Postavi(x, y, a);

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            bb6 = new BB8();
            bb6.Postavi(x, y, a);

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            bb7 = new BB8();
            bb7.Postavi(x, y, a);

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            bb8 = new BB8();
            bb8.Postavi(x, y, a);

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            bb9 = new BB8();
            bb9.Postavi(x, y, a);

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            bb10 = new BB8();
            bb10.Postavi(x, y, a);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            pomeranje = true;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            bb1.Crtaj(e.Graphics);
            bb2.Crtaj(e.Graphics);
            bb3.Crtaj(e.Graphics);
            bb4.Crtaj(e.Graphics);
            bb5.Crtaj(e.Graphics);
            bb6.Crtaj(e.Graphics);
            bb7.Crtaj(e.Graphics);
            bb8.Crtaj(e.Graphics);
            bb9.Crtaj(e.Graphics);
            bb10.Crtaj(e.Graphics);

        }
    }
}
