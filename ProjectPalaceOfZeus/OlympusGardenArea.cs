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
    public partial class OlympusGardenArea : Form
    {
        private readonly Rectangle clickableArea = new Rectangle(300, 200, 100, 150);
        private bool isclickable = false;
        private bool isAreaVisible = true;
        public OlympusGardenArea()
        {
            InitializeComponent();
        }

        private void ToHotelpictureBox_Click(object sender, EventArgs e)
        {
            MainHall form = new MainHall();
            form.Show();
            this.Hide();
        }

        private void ToTRHorsePictureBox_Click(object sender, EventArgs e)
        {
            if (isAreaVisible)
            {
                ToHotelpictureBox.Hide();
                label2.Hide();
                BackgroundImage = Properties.Resources.trhorse2;
                isclickable = true;
                label1.Text = "Επιστροφή στην τοποθεσία";
                isAreaVisible = false;
            }
            else
            {
                BackgroundImage = Properties.Resources.gardenarea;
                label1.Text = "Επιστροφή στο Δούρειο Ίππο";
                isAreaVisible = true;
                isclickable = false;
                ToHotelpictureBox.Show();
                label2.Show();
            }
        }

        private void LocationPictureBox_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void OlympusGardenArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (isclickable && clickableArea.Contains(e.Location))
            {
                this.Cursor = Cursors.Hand; // Αλλαγή του δρομέα σε "Hand" όταν βρίσκεται πάνω από την περιοχή
            }
            else
            {
                this.Cursor = Cursors.Default; // Αλλαγή πίσω στον προεπιλεγμένο δρομέα όταν δεν είναι
            }
        }

        private void OlympusGardenArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (clickableArea.Contains(e.Location))
            {
                DialogResult result = MessageBox.Show("Θέλετε να ανέβετε στο Δούρειο Ίππο;", "Ενημέρωση", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TrojanHorse trojanHorse = new TrojanHorse(2, 0);
                    trojanHorse.Show();
                    this.Hide();
                }
            }
        }
    }
}
