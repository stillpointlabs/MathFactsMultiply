using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathFacts
{
    public partial class MultiplySplashScreen : Form
    {
               
        public MultiplySplashScreen()
        {
            InitializeComponent();

        }

        private void goButton_Click(object sender, EventArgs e)
        {
                SessionConfigMult sessionConfig = new SessionConfigMult();
                sessionConfig.ShowDialog();                
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            //Quit
            Close();
        }

        private void MultiplySplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
           
    }
}
