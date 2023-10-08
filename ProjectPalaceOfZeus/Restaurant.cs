using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectPalaceOfZeus
{
    public partial class Restaurant : Form
    {
        public Restaurant()
        {
            InitializeComponent();
        }

        private string GreetEmployee()
        {
            DateTime currentTime = DateTime.Now;
            string greeting = "";

            if (currentTime.Hour >= 6 && currentTime.Hour < 12)
            {
                greeting = "Καλημέρα!";
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
            {
                greeting = "Καλησπέρα!";
            }
            else
            {
                greeting = "Καληνύχτα!";
            }
            return greeting;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = GreetEmployee() + "Τι θα πάρετε;";
            button1.Visible = true;
            button2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;
            button1.Text = "Θα ήθελα να δω το μενού";
            button2.Text = "Τίποτα, ευχαριστώ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Παρακαλώ σκανάρετε το μενού";
            button1.Visible = false;
            button2.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            label2.Visible = false;
            pictureBox4.Visible = true;   
        }
    }
}
