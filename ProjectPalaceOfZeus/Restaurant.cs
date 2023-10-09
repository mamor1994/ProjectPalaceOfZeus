using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectPalaceOfZeus
{
    public partial class Restaurant : Form
    {
        private List<string> selectedItems = new List<string>(); 
        private List<double> selectedItemPrices = new List<double>(); 
        private double totalCost = 0;
        double price;
        private int i;

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
            ΑΠΟΔΕΙΞΗ.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Κάρτα")
            {
                button1.Visible = false;
                button2.Visible = false;
                pictureBox2.Visible = false;
                label1.Text = "Σας ευχαριστώ!" + Environment.NewLine + "Ορίστε η απόδειξη σας";
                timer2.Start();
            }
            else
            {
                label1.Text = "Παρακαλώ σκανάρετε το μενού";
                button1.Visible = false;
                button2.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                label2.Visible = false;
                pictureBox4.Visible = true;
                button3.Visible = true;
                pictureBox1.Cursor = default;
                pictureBox1.Click -= pictureBox1_Click;
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible= false;
            button3.Visible= false;
            pictureBox2.Visible = true;
            button1.Visible = true;
            button2.Visible= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Όχι είμαι εντάξει")
            {
                label1.Text = "Το ποσό είναι: " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));  
                timer1.Start();
                button2.Visible = false;
                button1.Visible = false;
                pictureBox2.Visible= false;
            }
            else if (button2.Text == "Μετρητά")
            {
                button1.Visible = false;
                button2.Visible = false;
                pictureBox2.Visible = false;
                label1.Text = "Σας ευχαριστώ!" + Environment.NewLine + "Ορίστε η απόδειξη σας";
                timer2.Start();
            }
            else
            {
                label1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
            }
        }

        private void lblBrunch_Click(object sender, EventArgs e)
        {
            label3.Text = "Brunch";
            lblTotal.Visible = true;
            tableLayoutPanel2.Visible = false;
            brunchMenu.Visible = true;
            lblOption1.Text = "Pancakes";
            lblOption2.Text = "Toast";
            lblOption3.Text = "Croque Monsieur";
            lblOption4.Text = "Croissant";
            pc1.Image = Properties.Resources.pancakes;
            pc2.Image = Properties.Resources.toast;
            pc3.Image = Properties.Resources.eggs;
            pc4.Image = Properties.Resources.krouasan;
            lblPrice1.Text = "8.00€";
            lblPrice2.Text = "4.00€";
            lblPrice3.Text = "8.00€";
            lblPrice4.Text = "4.00€";
        }

        private void lblFood_Click(object sender, EventArgs e)
        {
            label3.Text = "Φαγητό";
            lblTotal.Visible = true;
            tableLayoutPanel2.Visible = false;
            brunchMenu.Visible = true;
            lblOption1.Text = "Καρμπονάρα";
            lblOption2.Text = "Παστίτσιο";
            lblOption3.Text = "Γεμιστά";
            lblOption4.Text = "Κοτόπουλο";
            pc1.Image = Properties.Resources.karmponara;
            pc2.Image = Properties.Resources.pastitsio;
            pc3.Image = Properties.Resources.gemista;
            pc4.Image = Properties.Resources.kotopoylo;
            lblPrice1.Text = "10.00€";
            lblPrice2.Text = "13.00€";
            lblPrice3.Text = "12.00€";
            lblPrice4.Text = "15.00€";
        }

        private void lblCoffee_Click(object sender, EventArgs e)
        {
            label3.Text = "Καφέδες/Χυμοί";
            lblTotal.Visible = true;
            tableLayoutPanel2.Visible = false;
            brunchMenu.Visible = true;
            lblOption1.Text = "Freddo espresso";
            lblOption2.Text = "Freddo cappuccino";
            lblOption3.Text = "Σοκολάτα";
            lblOption4.Text = "Χυμός πορτοκάλι";
            pc1.Image = Properties.Resources.freddo;
            pc2.Image = Properties.Resources.fc__1_;
            pc3.Image = Properties.Resources.sokolata;
            pc4.Image = Properties.Resources.xumos;
            lblPrice1.Text = "5.00€";
            lblPrice2.Text = "6.00€";
            lblPrice3.Text = "7.00€";
            lblPrice4.Text = "8.00€";
        }

        private void lblDrinks_Click(object sender, EventArgs e)
        {
            lblDrinks.Click += lblDrinks_Click;
            DateTime currentTime = DateTime.Now;
            if (currentTime.Hour >= 18 || currentTime.Hour < 5)
            {
                label3.Text = "Ποτά";
                lblTotal.Visible = true;
                tableLayoutPanel2.Visible = false;
                brunchMenu.Visible = true;
                lblOption1.Text = "Aperol";
                lblOption2.Text = "Kahlua";
                lblOption3.Text = "Mai Tai";
                lblOption4.Text = "Κρασί";
                pc1.Image = Properties.Resources.aperol;
                pc2.Image = Properties.Resources.kahlua;
                pc3.Image = Properties.Resources.maitai;
                pc4.Image = Properties.Resources.κρασι;
                lblPrice1.Text = "15.00€";
                lblPrice2.Text = "13.00€";
                lblPrice3.Text = "12.00€";
                lblPrice4.Text = "15.00€";
            }
            else if (currentTime.Hour >= 5 || currentTime.Hour < 17)
            {
                lblDrinks.Click -= lblDrinks_Click;
                pictureBox1.Cursor = Cursors.Default;
                MessageBox.Show("Λυπάμαι, αλλά δεν μπορείτε να αγοράσετε ποτά το πρωί.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button3.Visible = false;
            label1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (label3.Text == "Περιεχόμενο")
            {
                panel1.Visible = false;
                pictureBox1.Click += pictureBox1_Click;
                pictureBox1.Cursor = Cursors.Hand;
                if (totalCost != 0)
                {
                    pictureBox3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Θέλετε κάτι άλλο;";
                    pictureBox2.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    button1.Text = "Ναι";
                    button2.Text = "Όχι είμαι εντάξει";
                }
            }
            else if(label3.Text == "Brunch")
            {
                brunchMenu.Visible = false;
                tableLayoutPanel2.Visible = true;
                label3.Text = "Περιεχόμενο";
                lblTotal.Visible = false;
            }
            else if (label3.Text == "Φαγητό")
            {
                brunchMenu.Visible = false;
                tableLayoutPanel2.Visible = true;
                label3.Text = "Περιεχόμενο";
                lblTotal.Visible = false;
            }
            else if (label3.Text == "Καφέδες/Χυμοί")
            {
                brunchMenu.Visible = false;
                tableLayoutPanel2.Visible = true;
                label3.Text = "Περιεχόμενο";
                lblTotal.Visible = false;
            }
            else if (label3.Text == "Ποτά")
            {
                brunchMenu.Visible = false;
                tableLayoutPanel2.Visible = true;
                label3.Text = "Περιεχόμενο";
                lblTotal.Visible = false;
            }
        }

        private void lblPancakes_Click(object sender, EventArgs e)
        {
            if (lblOption1.Text == "Pancakes")
            {
                selectedItems.Add(lblOption1.Text);
                selectedItemPrices.Add(8.00);
                totalCost += 8.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if(lblOption1.Text == "Καρμπονάρα")
            {
                selectedItems.Add(lblOption1.Text);
                selectedItemPrices.Add(10.00);
                totalCost += 10.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption1.Text == "Freddo espresso")
            {
                selectedItems.Add(lblOption1.Text);
                selectedItemPrices.Add(5.00);
                totalCost += 5.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption1.Text == "Aperol")
            {
                selectedItems.Add(lblOption1.Text);
                selectedItemPrices.Add(15.00);
                totalCost += 15.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
        }

        private void lblToast_Click(object sender, EventArgs e)
        {
            if (lblOption2.Text == "Toast")
            {
                selectedItems.Add(lblOption2.Text);
                selectedItemPrices.Add(4.00);
                totalCost += 4.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption2.Text == "Παστίτσιο")
            {
                selectedItems.Add(lblOption2.Text);
                selectedItemPrices.Add(13.00);
                totalCost += 13.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption2.Text == "Freddo cappuccino")
            {
                selectedItems.Add(lblOption2.Text);
                selectedItemPrices.Add(6.00);
                totalCost += 6.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption2.Text == "Kahlua")
            {
                selectedItems.Add(lblOption2.Text);
                selectedItemPrices.Add(13.00);
                totalCost += 13.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
        }

        private void lblCM_Click(object sender, EventArgs e)
        {
            if (lblOption3.Text == "Croque Monsieur")
            {
                selectedItems.Add(lblOption3.Text);
                selectedItemPrices.Add(8.00);
                totalCost += 8.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption3.Text == "Γεμιστά")
            {
                selectedItems.Add(lblOption3.Text);
                selectedItemPrices.Add(12.00);
                totalCost += 12.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption3.Text == "Σοκολάτα")
            {
                selectedItems.Add(lblOption3.Text);
                selectedItemPrices.Add(7.00);
                totalCost += 7.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption3.Text == "Mai Tai")
            {
                selectedItems.Add(lblOption3.Text);
                selectedItemPrices.Add(12.00);
                totalCost += 12.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }


        }

        private void lblCroissant_Click(object sender, EventArgs e)
        {
            if (lblOption4.Text == "Croissant")
            {
                selectedItems.Add(lblOption4.Text);
                selectedItemPrices.Add(4.00);
                totalCost += 4.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption4.Text == "Κοτόπουλο")
            {
                selectedItems.Add(lblOption4.Text);
                selectedItemPrices.Add(15.00);
                totalCost += 15.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption4.Text == "Χυμός πορτοκάλι")
            {
                selectedItems.Add(lblOption4.Text);
                selectedItemPrices.Add(8.00);
                totalCost += 8.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
            else if (lblOption4.Text == "Κρασί")
            {
                selectedItems.Add(lblOption4.Text);
                selectedItemPrices.Add(15.00);
                totalCost += 15.00;
                lblTotal.Visible = true;
                lblTotal.Text = "Total Price:  " + totalCost.ToString("C", CultureInfo.CreateSpecificCulture("el-GR"));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "Θα πληρώσετε με μετρητά" + Environment.NewLine + "ή κάρτα;";
            button1.Visible = true;
            button2.Visible = true;
            pictureBox2.Visible = true;
            button1.Text = "Κάρτα";
            button2.Text = "Μετρητά";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            ΑΠΟΔΕΙΞΗ.Visible = true;
            ΑΠΟΔΕΙΞΗ.Items.Add("Απόδειξη");

            foreach (string item in selectedItems)
            {
                
                ΑΠΟΔΕΙΞΗ.Items.Add($"{item} - {selectedItemPrices[i]:C}");
                i++;
            }
            ΑΠΟΔΕΙΞΗ.Items.Add(string.Format("Σύνολο: {0:C}", totalCost));
        }

        private void ΑΠΟΔΕΙΞΗ_Click(object sender, EventArgs e)
        {
            ΑΠΟΔΕΙΞΗ.Visible = false;
            totalCost = 0;
            selectedItems.Clear();
            selectedItemPrices.Clear();
            ΑΠΟΔΕΙΞΗ.Items.Clear();
            i = 0;
            lblTotal.Text = "Total Price: ";
        }

        private void ToHotelpictureBox_Click(object sender, EventArgs e)
        {
            Form form = new MainHall();
            form.Show();
            this.Hide();
        }
    }
}
