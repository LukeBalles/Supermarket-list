using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    
    public partial class Form1 : Form
    {
        float total = 0.00f;
        string value;
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void end_Click(object sender, EventArgs e)
        {
            if (appleBox.Value != 0)
            {
                for (int i = 1; i <= appleBox.Value; i++)
                {
                    total += 2.40f;
                }
            }
            if (orangeBox.Value != 0)
            {
                for (int i = 1; i <= orangeBox.Value; i++)
                {
                    total += 1.95f;
                }
            }
            if (pearBox.Value != 0)
            {
                for (int i = 1; i <= pearBox.Value; i++)
                {
                    total += 3.60f;
                }
            }
            if (bananaBox.Value != 0)
            {
                for (int i = 1; i <= bananaBox.Value; i++)
                {
                    total += 1.20f;
                }
            }
            if (disinfectantBox.Value != 0)
            {
                for (int i = 1; i <= disinfectantBox.Value; i++)
                {
                    total += 4.55f;
                }
            }
            if (detergentBox.Value != 0)
            {
                for (int i = 1; i <= detergentBox.Value; i++)
                {
                    total += 3.25f;
                }
            }
            if (soapBox.Value != 0)
            {
                for (int i = 1; i <= soapBox.Value; i++)
                {
                    total += 1.10f;
                }
            }
            if (rumpBox.Value != 0)
            {
                for (int i = 1; i <= rumpBox.Value; i++)
                {
                    total += 20.90f;
                }
            }
            if (mincedBox.Value != 0)
            {
                for (int i = 1; i <= mincedBox.Value; i++)
                {
                    total += 15.10f;
                }
            }
            if (loinBox.Value != 0)
            {
                for (int i = 1; i <= loinBox.Value; i++)
                {
                    total += 17.50f;
                }
            }
            if (runpBox.Value != 0)
            {
                for (int i = 1; i <= runpBox.Value; i++)
                {
                    total += 16.55f;
                }
            }
            
            value = "$" + Convert.ToString(total);

            MessageBox.Show("Total payable: " + value);
            total = 0.00f;
        }
    }
}
