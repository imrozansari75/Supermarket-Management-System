using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supermarket_Management_System
{
    public partial class Splash : Form
    {
        int startpoint = 0;

        public Splash()
        {
            InitializeComponent();
            timer.Start(); // Start the timer when the splash screen loads
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading... Please wait!"); // Optional click event for the progress bar
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // You can add any functionality here if needed
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            // You can add any functionality here if needed
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar.Value = startpoint;

            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer.Stop();
                Form1 mainForm = new Form1();
                this.Hide();
                mainForm.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
