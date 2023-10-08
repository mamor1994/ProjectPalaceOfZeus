using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        private bool isAreaVisible = true;

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
                //MessageBox.Show("Η παροχή Νερού είναι απενεργοποιημένη!", "Απενεργοποίηση Παροχή Νερού", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox2.Image = Properties.Resources.empty;
            }
            else
            {
                waterSupplyOn = true;
                //MessageBox.Show("Η παροχή Νερού είναι ενεργοποιημένη!", "Ενεργοποίηση Παροχή Νερού", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ToTRHorsePictureBox_Click(object sender, EventArgs e)
        {
            if (isAreaVisible)
            {
                isAreaVisible = false;
                if (waterSupplyOn == false)
                {
                    BackgroundImage = Properties.Resources.empty;
                    btnToggleAlarm.Visible = false;
                    btnTogglePool.Visible = false;
                    trackBarTemperature.Visible = false;
                    lblTemperature.Visible = false;
                    lblMessage1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    label2.Text = "Επιστροφή σε έλεγχο" + Environment.NewLine + "της Πισίνας";
                }
                else if (waterSupplyOn == true)
                {

                    BackgroundImage = Properties.Resources.withWater;
                    btnToggleAlarm.Visible = false;
                    btnTogglePool.Visible = false;
                    trackBarTemperature.Visible = false;
                    lblTemperature.Visible = false;
                    lblMessage1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    label2.Text = "Επιστροφή σε έλεγχο" + Environment.NewLine + "της Πισίνας";
                }
            }
            else
            {
                isAreaVisible = true;
                if (waterSupplyOn == false)
                {
                    btnToggleAlarm.Visible = true;
                    btnTogglePool.Visible = true;
                    trackBarTemperature.Visible = true;
                    lblTemperature.Visible = true;
                    lblMessage1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = true;
                    label2.Text = "Επιστροφή σε Πισίνα";
                }
                else if (waterSupplyOn == true)
                {
                    btnToggleAlarm.Visible = true;
                    btnTogglePool.Visible = true;
                    trackBarTemperature.Visible = true;
                    lblTemperature.Visible = true;
                    lblMessage1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = true;
                    label2.Text = "Επιστροφή σε Πισίνα";
                }
            }
        }

        private void ToHotelpictureBox_Click(object sender, EventArgs e)
        {
            Form form = new MainHall();
            form.Show();
            this.Hide();
        }
    }
}
