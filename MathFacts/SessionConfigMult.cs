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
    public partial class SessionConfigMult : Form
    {
        
        public SessionConfigMult()
        {
            InitializeComponent();
        }

        private void SpecialFactors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable the Go button if at least one special factor is checked.
            if(SpecialFactors.CheckedItems.Count > 0)
                goButton.Enabled = true;
            else
                goButton.Enabled = false;
        }

        private void factorMax_ValueChanged(object sender, EventArgs e)
        {
            // Set the second factor to a variable that the multiply activity can access.
            int maxFactor2;
            maxFactor2 = (int)factorMax.Value;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear all checked Special Factors boxes and disable Go button.
            for (int i = 0; i < SpecialFactors.Items.Count; i++)
            {
                SpecialFactors.SetItemChecked(i, false);
            }
            goButton.Enabled = false;
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            // Check all special factors boxes and enable Go button.
            for (int i = 0; i < SpecialFactors.Items.Count; i++)
            {
                SpecialFactors.SetItemChecked(i, true);
            }
            goButton.Enabled = true;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Record all of the factor choices.
            MultProblem.SecondFactorLimit = (int)factorMax.Value;

            int numChecked = SpecialFactors.CheckedItems.Count;

            MultProblem.SpecFactors = new int[numChecked];

            int j = 0;
            for (int i = 0; i < SpecialFactors.Items.Count; i++ )
            {
                if (SpecialFactors.GetItemChecked(i))
                {
                    MultProblem.SpecFactors[j++] = i;
                }
            }

            goButton.Enabled = false;
            
            // Launch window for mulitply actvity.
            // Pass set of special factors plus maximum factor.
            SessionMultiply sessionMult = new SessionMultiply();
            sessionMult.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
