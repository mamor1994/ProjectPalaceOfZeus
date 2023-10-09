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
            //int prevRow = currentRow;
            //int prevCol = currentCol;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (currentRow > 0)
                        currentRow -= 2;
                    UpPictureBox.BackColor = Color.Green;
                    DownPictureBox.BackColor = Color.Black;
                    LeftPictureBox.BackColor = Color.Black;
                    RightPictureBox.BackColor = Color.Black;
                    OkPictureBox.BackColor = Color.Black;
                    break;
                case Keys.Down:
                    if (currentRow < 4)
                        currentRow += 2;
                    UpPictureBox.BackColor = Color.Black;
                    DownPictureBox.BackColor = Color.Green;
                    LeftPictureBox.BackColor = Color.Black;
                    RightPictureBox.BackColor = Color.Black;
                    OkPictureBox.BackColor = Color.Black;
                    break;
                case Keys.Left:
                    if (currentCol > 0)
                        currentCol--;
                    UpPictureBox.BackColor = Color.Black;
                    DownPictureBox.BackColor = Color.Black;
                    LeftPictureBox.BackColor = Color.Green;
                    RightPictureBox.BackColor = Color.Black;
                    OkPictureBox.BackColor = Color.Black;
                    break;
                case Keys.Right:
                    if (currentCol < 3)
                        currentCol++;
                    UpPictureBox.BackColor = Color.Black;
                    DownPictureBox.BackColor = Color.Black;
                    LeftPictureBox.BackColor = Color.Black;
                    RightPictureBox.BackColor = Color.Green;
                    OkPictureBox.BackColor = Color.Black;
                    break;
                case Keys.Enter:
                    UpPictureBox.BackColor = Color.Black;
                    DownPictureBox.BackColor = Color.Black;
                    LeftPictureBox.BackColor = Color.Black;
                    RightPictureBox.BackColor = Color.Black;
                    OkPictureBox.BackColor = Color.Green;
                    DialogResult result = MessageBox.Show("Θέλετε να μετακινηθείτε σε αυτήν την τοποθεσία;", "Επιβεβαίωση", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Έναρξη αυτόματης πλοήγησης", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TravelTimer.Start();                        
                    }
                    break;
            }
            e.Handled = true;

            //if (prevRow != currentRow || prevCol != currentCol)
            //{
                HighlightCurrentCell();
            //}
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
                Destination = new MainHall();
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
                OpenDoorsPictureBox.Image = Properties.Resources.opendoors;
                CloseDoorsPictureBox.Image = Properties.Resources.closedoors__;
                PausePictureBox.Image = Properties.Resources.pausebutton;
            }
            else
            {
                MessageBox.Show("Οι πόρτες άνοιξαν", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openDoors = true;
                OpenDoorsPictureBox.Image = Properties.Resources.opendoors__;
                CloseDoorsPictureBox.Image = Properties.Resources.closedoors;
                PausePictureBox.Image = Properties.Resources.pausebutton;
            }
        }

        private void StairsTimer_Tick(object sender, EventArgs e)
        {
            StairsTimer.Stop();
            if (loweredStairs)
            {
                MessageBox.Show("H σκάλα ανέβηκε", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loweredStairs = false;
                StairsDownPictureBox.Image = Properties.Resources.lowerstairs;
                StairsUpPictureBox.Image = Properties.Resources.raisestairs__;
                PausePictureBox.Image = Properties.Resources.pausebutton;
            }
            else
            {
                MessageBox.Show("Η σκάλα κατέβηκε", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loweredStairs = true;
                StairsDownPictureBox.Image = Properties.Resources.lowerstairs__;
                StairsUpPictureBox.Image = Properties.Resources.raisestairs;
                PausePictureBox.Image = Properties.Resources.pausebutton;
            }

        }

        private void PausePictureBox_Click(object sender, EventArgs e)
        {
            if (DoorTimer.Enabled)
            {
                DoorTimer.Stop();
                MessageBox.Show("Οι πόρτες είναι μισόκλειστες", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PausePictureBox.Image = Properties.Resources.pausebutton_;
                StairsDownPictureBox.Image = Properties.Resources.lowerstairs;
                StairsUpPictureBox.Image = Properties.Resources.raisestairs;
                OpenDoorsPictureBox.Image = Properties.Resources.opendoors;
                CloseDoorsPictureBox.Image = Properties.Resources.closedoors;
            }
        }

        private void TravelTimer_Tick(object sender, EventArgs e)
        {
            TravelTimer.Stop();
            MessageBox.Show("Φτάσατε στον προορισμό σας", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetDestination(currentCol, currentRow);
        }

        private void ReturnPictureBox_Click(object sender, EventArgs e)
        {
            if (openDoors == false && loweredStairs == false)
            {
                MessageBox.Show("Πρέπει να ανοίξετε την πόρτα και να κατεβάσετε τη σκάλα για να βγείτε με ασφάλεια.", "Προσοχή!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (openDoors == true && loweredStairs == true)
            {   if (Destination == null)
                {
                    SetDestination(currentCol, currentRow);                   
                    Destination.Show();
                    this.Close();
                }
                else
                    Destination.Show();
                    this.Close(); 
            }
            else if (openDoors == true && loweredStairs != true)
            {
                MessageBox.Show("Κατεβάστε τη σκάλα για να κατεβείτε με ασφάλεια.", "Προσοχή!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (openDoors != true && loweredStairs == true)
            {
                MessageBox.Show("Η πόρτα είναι κλειστή, ανοίξτε τη για να βγείτε έξω.", "Προσοχή!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
