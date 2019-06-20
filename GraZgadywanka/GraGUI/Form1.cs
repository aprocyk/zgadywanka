using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogikaGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
            buttonPoddanie.Visible = true;
            buttonNowaGra.Enabled = false;
            
        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            

            int a;
            if (!int.TryParse(textBoxZakresMin.Text, out a))
            {
                textBoxZakresMin.BackColor = Color.Red;
                return;
            }
            else {
                textBoxZakresMin.BackColor = Color.LightGreen;

            }
            int b;
            if (!int.TryParse(textBoxZakresMax.Text, out b))
            {
                textBoxZakresMax.BackColor = Color.Red;
                return;
            }
            else {
                textBoxZakresMax.BackColor = Color.LightGreen;

            }
            g = new Gra(a, b);
            groupBoxLosowanie.Enabled = false;
            groupBoxPropozycja.Visible = true;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (groupBoxInformacje.Visible == false) {
                groupBoxInformacje.Visible = true;
            } else if (groupBoxInformacje.Visible == true) {
                groupBoxInformacje.Visible = false;
            }

            
            
        }
    }
}
