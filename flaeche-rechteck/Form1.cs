using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_flaeche_rechteck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double width = 0;
            double height = 0;

            if (double.TryParse(textBoxWidth.Text, out width) == false)
            {
                MessageBox.Show("Bitte geben Sie eine Zahl ein!");
                textBoxWidth.Focus();
                textBoxWidth.SelectAll();
            }
            else if (double.TryParse(textBoxHeight.Text, out height) == false)
            {
                MessageBox.Show("Bitte geben Sie eine Zahl ein!");
                textBoxHeight.Focus();
                textBoxHeight.SelectAll();
            }
            else
            {
                Rechteck rechteck = new Rechteck();
                rechteck.Width = width;
                rechteck.Height = height;

                textBoxResult.Text = rechteck.GetArea().ToString();
            }
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            buttonCalculate.Enabled = textBoxWidth.Text.Length > 0 && textBoxHeight.Text.Length > 0;
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            buttonCalculate.Enabled = textBoxWidth.Text.Length > 0 && textBoxHeight.Text.Length > 0;
        }

    }
}
