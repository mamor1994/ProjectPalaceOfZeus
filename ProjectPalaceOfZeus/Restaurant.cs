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
        private List<string> selectedItems = new List<string>(); 
        private List<decimal> selectedItemPrices = new List<decimal>(); 
        private decimal totalCost = 0;
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
            button3.Visible = true;
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
            label1.Visible= false;
            button1.Visible = false;
            button2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
        }

        private void lblBrunch_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;
            brunchMenu.Visible = true;
            label3.Text = "Brunch";
            lblTotal.Visible = true;
        }

        private void lblFood_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;
           
        }

        private void lblCoffee_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;

        }

        private void lblDrinks_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;

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
            }
            else if(label3.Text == "Brunch")
            {
                brunchMenu.Visible = false;
                tableLayoutPanel2.Visible = true;
                label3.Text = "Περιεχόμενο";
                lblTotal.Visible = false;
            }
        }

        private void lblPancakes_Click(object sender, EventArgs e)
        {
            Label label8 = (Label)sender;
            string itemName = label8.Text;
           // decimal itemPrice = GetPriceFromLabel(label8);
        }

        //private decimal GetPriceFromLabel(Label label)
        //{
        //    string priceText = label.Text.Replace("$", "");
        //    return decimal.Parse(priceText);
        //}

        //private void AddItem(string item, decimal price)
        //{

        //    selectedItems.Add(item);
        //    selectedItemPrices.Add(price);
        //    totalCost += price;
        //    UpdateOrderDisplay();
        //}

        //private void UpdateOrderDisplay()
        //{
        //    orderListBox.Items.Clear();
        //    foreach (string item in selectedItems)
        //    {
        //        orderListBox.Items.Add(item);
        //    }
        //    lblTotal.Text = $"Συνολικό Κόστος: {totalCost:C}";
        //}
    }
}
