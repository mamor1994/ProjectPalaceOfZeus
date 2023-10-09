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
    public partial class MainHall : Form
    {
        private bool needToExitApp = true;

        public MainHall()
        {
            InitializeComponent();
            label4.Text = GreetEmployee() +"Kαλωσήρθατε" + Environment.NewLine + "στο Παλάτι του Δία";
        }

        private string GreetEmployee()
        {
            DateTime currentTime = DateTime.Now;
            string greeting = "";

            if (currentTime.Hour >= 6 && currentTime.Hour < 12)
            {
                greeting = "Καλημέρα!";
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour < 24)
            {
                greeting = "Καλησπέρα!";
            }
            return greeting;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }

        private void goRoom_Click(object sender, EventArgs e)
        {
            Form form = new Room();
            form.Show();
            this.Hide();
        }

        private void goPool_Click(object sender, EventArgs e)
        {
            Form form = new Pool();
            form.Show();
            this.Hide();
        }

        private void goCamping_Click(object sender, EventArgs e)
        {
            Form form = new CampingArea();
            form.Show();
            this.Hide();
        }
    }
}
