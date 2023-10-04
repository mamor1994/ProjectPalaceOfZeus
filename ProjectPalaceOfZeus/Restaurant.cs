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
    public partial class Restaurant : Form
    {
        private bool needToExitApp = true;

        public Restaurant()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }
    }
}
