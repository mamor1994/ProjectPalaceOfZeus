using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPalaceOfZeus
{
    public partial class Room : Form
    {
        int room_lights = 1, room_tv = 0, room_curtain = 0;
        private bool needToExitApp = true;

        public Room()
        {
            InitializeComponent();
        }

        private void onLightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (room_curtain == 0)
            {
                if (room_tv == 0 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_tv == 0 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_tv == 1 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 0;
                }
                else if (room_tv == 1 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 0;
                }
            }
            else if (room_curtain == 1)
            {
                if (room_tv == 0 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_off_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_tv == 0 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_off_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_tv == 1 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 1;
                }
                else if (room_tv == 1 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 1;
                }
            }
        }

        private void onTvToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (room_curtain == 0)
            {
                if (room_tv == 0 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_off_lights;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 0;
                }
                else if (room_tv == 0 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 0;
                }
                else if (room_tv == 1 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_off_lights;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 0;
                }
                else if (room_tv == 1 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 0;
                }
            }
            else if(room_curtain == 1)
            {
                if (room_tv == 0 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_on_tv;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 1;
                }
                else if (room_tv == 0 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 1;
                }
                else if (room_tv == 1 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_on_tv;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 1;
                }
                else if (room_tv == 1 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 1;
                }
            }
        }

        private void onCurtainToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (room_curtain == 0)
            {
                if (room_lights == 0 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_off_tv;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_lights == 0 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_on_tv;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 1;
                }
                else if (room_lights == 1 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_off_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_lights == 1 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 1;
                }
            }
            else if (room_curtain == 1)
            {
                if (room_lights == 0 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_off_tv;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_lights == 0 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_on_tv;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 1;
                }
                else if (room_lights == 1 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_off_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_lights == 1 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 1;
                }
            }
        }

        private void offCurtainToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (room_curtain == 0)
            {
                if (room_lights == 0 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_lights_off;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_lights == 0 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_off_lights;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 0;
                }
                else if (room_lights == 1 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_lights == 1 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 0;
                }
            }
            else if (room_curtain == 1)
            {
                if (room_lights == 0 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_lights_off;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_lights == 0 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_off_lights;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 0;
                }
                else if (room_lights == 1 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_lights == 1 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv;
                    room_lights = 1;
                    room_tv = 1;
                    room_curtain = 0;
                }
            }
        }

        private void Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }

        private void offLightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (room_curtain == 0)
            {
                if (room_tv == 0 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_lights_off;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_tv == 0 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_lights_off;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_tv == 1 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_off_lights;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 0;
                }
                else if (room_tv == 1 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_tv_off_lights;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 0;
                }
            }
            else if (room_curtain == 1)
            {
                if (room_tv == 0 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_off_tv;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_tv == 0 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_off_tv;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_tv == 1 && room_lights == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_on_tv;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 1;
                }
                else if (room_tv == 1 && room_lights == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_on_tv;
                    room_lights = 0;
                    room_tv = 1;
                    room_curtain = 1;
                }
            }
        }

        private void offTvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (room_curtain == 0)
            {
                if (room_lights == 0 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_lights_off;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_lights == 0 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_lights_off;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_lights == 1 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 0;
                }
                else if (room_lights == 1 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 0;
                }
            }
            else if (room_curtain == 1)
            {
                if (room_lights == 0 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_off_tv;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_lights == 0 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_on_curtain_off_tv;
                    room_lights = 0;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_lights == 1 && room_tv == 0)
                {
                    pictureBox1.Image = Properties.Resources.room1_off_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 1;
                }
                else if (room_lights == 1 && room_tv == 1)
                {
                    pictureBox1.Image = Properties.Resources.room1_off_tv_and_on_curtain;
                    room_lights = 1;
                    room_tv = 0;
                    room_curtain = 1;
                }
            }  
        }
    }
}
