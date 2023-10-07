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
        private readonly Rectangle clickableArea = new Rectangle(500, 300, 100, 150);
        public CampingArea()
        {
            InitializeComponent();
        }

        private void CampingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickableArea.Contains(e.Location))
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
            if (clickableArea.Contains(e.Location))
            {
                MessageBox.Show("Είσοδος στο Δούρειο Ίππο");
                TrojanHorse trojanHorse = new TrojanHorse(3,4);
                trojanHorse.Show();
                this.Hide();
            }
        }
    }
}
