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
    public partial class CampingArea : Form
    {
        private bool needToExitApp = true;

        private bool isclickable = true;
        private readonly Rectangle clickableArea = new Rectangle(500, 300, 100, 150);
        public CampingArea()
        {
            InitializeComponent();
        }

        private void CampingArea_MouseMove(object sender, MouseEventArgs e)
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

        private void CampingArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (isclickable && clickableArea.Contains(e.Location))
            {
                DialogResult result = MessageBox.Show("Θέλετε να ανέβετε στο Δούρειο Ίππο;", "Ενημέρωση", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TrojanHorse trojanHorse = new TrojanHorse(3, 4);
                    trojanHorse.Show();
                    this.Hide();
                }
            }
        }

        private void ToHotelpictureBox_Click(object sender, EventArgs e)
        {
            MainHall form = new MainHall();
            form.Show();
            this.Hide();
        }

        private void LocationPictureBox_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            isclickable = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            isclickable = true;
        }

        private void CampingArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }
    }
}
