﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace ProjectPalaceOfZeus
{
    public partial class Welcome : Form
    {

        private SpeechSynthesizer synthesizer;
        private bool needToExitApp = true;

        public Welcome()
        {
            InitializeComponent();
            timer1.Interval = 7000;
            timer1.Start();
            synthesizer = new SpeechSynthesizer();
            string textToSpeak = " , Greetings dear Guest. Enjoy your stay to our hotel";
            synthesizer.SpeakAsync(textToSpeak);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            synthesizer.Dispose();
            this.Hide();
            MainHall form = new MainHall();
            form.Show();
        }

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                synthesizer.Dispose();
                timer1.Dispose();
                Application.Exit();
            }
        }
    }
}
