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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BB8 bb = new BB8();
        bool pomeranje = false;
        int x, y, a;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            bb.Crtaj(e.Graphics);

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pomeranje = false;
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            pomeranje = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pomeranje)
            {
                bb.Pomeri(3,0);
                Refresh();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            a = 200;
            x = ClientRectangle.Width / 2;
            y = ClientRectangle.Height / 2;
            Graphics g = CreateGraphics();
            timer1.Start();
            bb.Postavi(x, y, a);
            bb.Crtaj(g);
        }

    }
}
