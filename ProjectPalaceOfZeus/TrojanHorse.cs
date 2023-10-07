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
    public partial class TrojanHorse : Form
    {
        private bool openDoors = true;
        private bool loweredStairs = true;
        private int currentRow;
        private int currentCol;
        private Form Destination;
        private PictureBox currentHighlightedPictureBox = null;
        private Image previousImage = null;

        public TrojanHorse(int startingCol, int startingRow)
        {
            InitializeComponent();
            currentRow = startingRow;
            currentCol = startingCol;
            this.KeyPreview = false;
            HighlightCurrentCell();
        }

        private void TrojanHorse_KeyDown(object sender, KeyEventArgs e)
        {
            int prevRow = currentRow;
            int prevCol = currentCol;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (currentRow > 0)
                        currentRow -= 2;
                    break;
                case Keys.Down:
                    if (currentRow < 4)
                        currentRow += 2;
                    break;
                case Keys.Left:
                    if (currentCol > 0)
                        currentCol--;
                    break;
                case Keys.Right:
                    if (currentCol < 3)
                        currentCol++;
                    break;
                case Keys.Enter:
                    DialogResult result = MessageBox.Show("Θέλετε να μετακινηθείτε σε αυτήν την τοποθεσία;", "Επιβεβαίωση", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SetDestination(currentCol, currentRow);
                    }
                    break;
            }
            e.Handled = true;

            if (prevRow != currentRow || prevCol != currentCol)
            {
                HighlightCurrentCell();
            }
        }
        private void HighlightCurrentCell()
        {
            //MessageBox.Show($"Moving to Row: {currentRow}, Col: {currentCol}");
            if (currentHighlightedPictureBox != null && previousImage != null)
            {
                currentHighlightedPictureBox.Image = previousImage;
                previousImage = null;
            }
            Control currentControl = HotelMap.GetControlFromPosition(currentCol, currentRow);

            if (currentControl is PictureBox pictureBox)
            {
                previousImage = pictureBox.Image;
                pictureBox.Image = Properties.Resources.trojangps;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                currentHighlightedPictureBox = pictureBox;
            }
        }

        private void SetDestination(int col, int row)
        {
            if (col == 0 && row == 0)
            {
                Destination = new MarketArea();
            }
            else if (col == 1 && row == 0)
            {
                Destination = new Room();
            }
            else if (col == 2 && row == 0)
            {
               // Destination = new OlympusGarden();
            }
            else if (col == 3 && row == 0)
            {
                Destination = new CentaurFieldArea();
            }
            else if (col == 0 && row == 2)
            {
                Destination = new Pool();
            }
            else if (col == 1 && row == 2)
            {
               // Destination = new ApollosSquareArea();
            }
            else if (col == 2 && row == 2)
            {
                Destination = new CoffeeArea();
            }
            else if (col == 3 && row == 2)
            {
                Destination = new ForestArea();
            }
            else if (col == 0 && row == 4)
            {
                Destination = new ParkingArea1();
            }
            else if (col == 1 && row == 4)
            {
               // Destination = new EntranceArea();
            }
            else if (col == 2 && row == 4)
            {
                Destination = new ParkingArea2();
            }
            else if (col == 3 && row == 4)
            {
                Destination = new CampingArea();
            }
        }

        private void startEnginePictureBox_Click(object sender, EventArgs e)
        {
            if (openDoors == false && loweredStairs == false)
            {
                this.KeyPreview = true;
                HotelMap.Visible = true;
                UpPictureBox.Visible = true;
                DownPictureBox.Visible = true;
                LeftPictureBox.Visible = true;
                RightPictureBox.Visible = true;
                OkPictureBox.Visible = true;
                startEnginePictureBox.Visible = false;
                startEnginePictureBox.Enabled = false;
            }
            else if (openDoors == true && loweredStairs == true)
            {
                MessageBox.Show("Πρέπει να κλείσετε την πόρτα και να ανεβάσετε τη σκάλα για να βάλετε μπροστά", "Προσοχή!!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (openDoors == true && loweredStairs != true)
            {
                MessageBox.Show("Οι πόρτες πρέπει να είναι κλειστές για να βάλετε μπροστά","Προσοχή!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (openDoors != true && loweredStairs == true)
            {
                MessageBox.Show("Η σκάλα είναι κατεβασμένη! Θα πρέπει να την ανεβάσετε για να μπορέσετε να ξεκινήσετε", "Προσοχή!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OpenDoorsPictureBox_Click(object sender, EventArgs e)
        {
            if (openDoors == false)
            {
                MessageBox.Show("Οι πόρτες ανοίγουν..", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DoorTimer.Start();
            }
            else
            {
                return;
            }
        }

        private void StairsDownPictureBox_Click(object sender, EventArgs e)
        {
            if (loweredStairs == false)
            {
                MessageBox.Show("Η σκάλα κατεβαίνει..", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StairsTimer.Start();
            }
            else
            {
                return;
            }
        }

        private void CloseDoorsPictureBox_Click(object sender, EventArgs e)
        {
            if (openDoors)
            {
                MessageBox.Show("Οι πόρτες κλείνουν..", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DoorTimer.Start();
            }
            else
            {
                return;
            }
        }

        private void StairsUpPictureBox_Click(object sender, EventArgs e)
        {
            if (loweredStairs)
            {
                MessageBox.Show("Η σκάλα ανεβαίνει..", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StairsTimer.Start();
            }
            else
            {
                return;
            }
        }

        private void DoorTimer_Tick(object sender, EventArgs e)
        {
            DoorTimer.Stop();
            if (openDoors)
            {
                MessageBox.Show("Οι πόρτες έκλεισαν","Ενημέρωση",MessageBoxButtons.OK,MessageBoxIcon.Information);
                openDoors = false;
            }
            else
            {
                MessageBox.Show("Οι πόρτες άνοιξαν", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openDoors = true;
                 
            }
        }

        private void StairsTimer_Tick(object sender, EventArgs e)
        {
            StairsTimer.Stop();
            if (loweredStairs)
            {
                MessageBox.Show("H σκάλα ανέβηκε", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loweredStairs = false;
            }
            else
            {
                MessageBox.Show("Η σκάλα κατέβηκε", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loweredStairs = true;
            }

        }

        private void PausePictureBox_Click(object sender, EventArgs e)
        {
            DoorTimer.Stop();
            MessageBox.Show("Οι πόρτες είναι μισόκλειστες","Ενημέρωση",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
