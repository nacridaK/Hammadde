using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammadde_Taşıma
{
    public partial class Form1 : Form
    {
        int hedefX1 = 140, hedefX2 = 140;
        int hedefY = 417;
        bool y_hareket;
        Point konum;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            konum = pictureBox_araç.Location;
        }
        private void timer_x_Tick(object sender, EventArgs e)
        {
            konum = pictureBox_araç.Location;
            if (konum.X != hedefX1)
            {
                konum.X += Math.Sign(hedefX1 - konum.X) * 4;
                pictureBox_araç.Location = konum;
            }
            else if (y_hareket)
            {
                timer_x.Stop();
                timer_y.Start();
            }
        }
        private void timer_y_Tick(object sender, EventArgs e)
        {
            konum = pictureBox_araç.Location;
            if ((konum.X == 36 || konum.X == 884) && y_hareket)
            {
                konum.Y += Math.Sign(hedefY - konum.Y) * 4;
                pictureBox_araç.Location = konum;
            }
            if (hedefY == konum.Y)
            {
                y_hareket = false;
                hedefX1 = hedefX2;
                timer_y.Stop();
                timer_x.Start();
            }
        }
        private void button_ev_Click(object sender, EventArgs e)
        {
            hedefY = 417;
            if (hedefY == pictureBox_araç.Location.Y)
                hedefX1 = button_ev.Location.X;
            else
            {
                y_hareket = true;
                if (konum.X - 36 < 884 - konum.X)
                    hedefX1 = 36;
                else
                    hedefX1 = 884;
                hedefX2 = button_ev.Location.X;
            }
        }
        private void button_ist1_Click(object sender, EventArgs e)
        {
            hedefY = 417;
            if (hedefY == pictureBox_araç.Location.Y)
                hedefX1 = button_ist1.Location.X;
            else
            {
                y_hareket = true;
                if (konum.X - 36 < 884 - konum.X)
                    hedefX1 = 36;
                else
                    hedefX1 = 884;
                hedefX2 = button_ist1.Location.X;
            }
        }
        private void button_ist2_Click(object sender, EventArgs e)
        {
            hedefY = 101;
            if (hedefY == pictureBox_araç.Location.Y)
                hedefX1 = button_ist2.Location.X;
            else
            {
                y_hareket = true;
                if (konum.X - 36 < 884 - konum.X)
                    hedefX1 = 36;
                else
                    hedefX1 = 884;
                hedefX2 = button_ist2.Location.X;
            }
        }
        private void button_ist3_Click(object sender, EventArgs e)
        {
            hedefY = 101;
            if (hedefY == pictureBox_araç.Location.Y)
                hedefX1 = button_ist3.Location.X;
            else
            {
                y_hareket = true;
                if (konum.X - 36 < 884 - konum.X)
                    hedefX1 = 36;
                else
                    hedefX1 = 884;
                hedefX2 = button_ist3.Location.X;
            }
        }
    }
}