﻿using System;
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
    public partial class Pool : Form
    {
        private bool needToExitApp = true;
        private bool alarmActivated = false;
        private bool waterSupplyOn = false;
        public Pool()
        {
            InitializeComponent();
        }

        private void btnToggleAlarm_Click(object sender, EventArgs e)
        {
            if (alarmActivated)
            {
                alarmActivated = false;
                lblMessage1.Show(); 
                lblMessage1.Text = "Ο συναγερμός είναι απενεργοποιημένος!";
                timer1.Start();
                //MessageBox.Show("Ο συναγερμός είναι απενεργοποιημένος!", "Απενεργοποίηση Συναγερμού", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                alarmActivated = true;
                lblMessage1.Show();
                lblMessage1.Text = "Ο συναγερμός είναι ενεργοποιημένος!";
                timer1.Start();
                //MessageBox.Show("Ο συναγερμός είναι ενεργοποιημένος!", "Ενεργοποίηση Συναγερμού", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnToggleWaterSupply_Click(object sender, EventArgs e)
        {
            if (waterSupplyOn)
            {
                waterSupplyOn = false;
                MessageBox.Show("Η παροχή Νερού είναι απενεργοποιημένη!", "Απενεργοποίηση Παροχή Νερού", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox2.Image = Properties.Resources.empty;
            }
            else
            {
                waterSupplyOn = true;
                MessageBox.Show("Η παροχή Νερού είναι ενεργοποιημένη!", "Ενεργοποίηση Παροχή Νερού", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox2.Image = Properties.Resources.withWater;

            }
        }

        private void trackBarTemperature_Scroll(object sender, EventArgs e)
        {
            lblTemperature.Text = "Temperature: " + trackBarTemperature.Value.ToString() + "°C";
        }

        private void Pool_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }

        private void Pool_Load(object sender, EventArgs e)
        {
            lblMessage.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMessage1.Hide();
        }
    }
}
