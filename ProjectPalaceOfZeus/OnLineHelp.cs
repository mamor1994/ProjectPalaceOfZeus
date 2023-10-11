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
    public partial class OnLineHelp : Form
    {
        private bool needToExitApp = true;

        public OnLineHelp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.menuhelp;
            label3.Text = "Ανοίγοντας τον κατάλογο ο χρήστης μπορεί να επιλέξει ανάμεσα σε κάποιες επιλογές που του παρέχονται";

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox4.Image = Properties.Resources.xarthshelp;
            label4.Text = "Από το εσωτερικό του Δούρειου Ίππου μπορεί να μετακινηθεί στις άλλες περιοχές του ξενοδοχείου.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pool;
            label1.Text = "Εδώ ο χρήστης βρίσκεται στον χώρο της πισίνας και μπορεί είτε να μεταβεί στην κονσόλα είτε να γυρίσει πίσω στο ξενοδοχείο.";
            pictureBox2.Image = Properties.Resources.controlPool;
            label2.Text = "Μέσω της κονσόλας ο χρήστης μπορεί να γεμίσει/ αδείασει την πισίνα, να ρυθμίσει την θερμοκρασία της πισίνας και να ενεργοποιήσει τον συναργεμό.";
            pictureBox3.Image = Properties.Resources.livadihelp;
            label3.Text = "Εδώ βρίσκεται μια από τις τοποθεσίες από τις οποίες μπορεί να επισκευτεί ο χρήστης με τον Δούρειο Ίππο.";
            pictureBox4.Image = Properties.Resources.gpshelp;
            label4.Text = "Από εδώ μπορεί να δει την τοποθεσία του στον χάρτη.";
            linkLabel1.Hide();
            linkLabel2.Hide();
            linkLabel3.Hide();
            linkLabel4.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mainpage;
            label1.Text = "Εδώ είναι η κύρια φόρμα της εφαρμογής μας από όπου ο χρήστης μπορεί να περιηγηθεί στο δωμάτιο, εστιατόριο, πισίνα και στο camping επιλέγοντας ένα από τα κουμπία της φόρμας.";
            pictureBox2.Image = Properties.Resources.roomhelp;
            label2.Text = "Από αυτή την φόρμα ο χρήστης μπορεί με το πάτημα των κουμπιών στο αριστερό μενού μπορεί να κάνει διάφορες ενέργειες όπως το άνοιγμα/ κλείσιμο της τηλεόρασης, το άνοιγμα/ κλείσιμο της κουρτίνας, το άνοιγμα/ κλείσιμο των φώτων.";
            pictureBox3.Image = Properties.Resources.restauranthelp;
            label3.Text = "Αυτή είναι η φόρμα του εστιατορίου. Μέσω αυτής ο χρήστης μπορεί κλικάροντας στο σερβιτόρο να ξεκινήσει την συνομιλία για την παραγγελία που θέλει να πραγματοποιήσει.";
            pictureBox4.Image = Properties.Resources.doureioshelp;
            label4.Text = "Σε αυτή την φόρμα βρίσκεται ο Δούρειος Ίππος όπου ο χρήστης μπορεί πατώντας πάνω του με κλικ να μεταβεί στο εσωτερικό του.";
            linkLabel1.Show();
            linkLabel2.Show();
            linkLabel3.Show();
            linkLabel4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainHall form = new MainHall();
            form.Show();
        }

        private void OnLineHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }
    }
}
