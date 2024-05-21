using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI;
using DarkUI.Forms;

namespace KwToHPConverter
{
    public partial class frConverter : DarkForm
    {
        private bool isUserInput; // Variável de controle

        public frConverter()
        {
            InitializeComponent();
            isUserInput = true;
        }

        private void edCV_TextChanged(object sender, EventArgs e)
        {
            if (isUserInput)
            {
                isUserInput = false;
                try
                {
                    double kw = Double.Parse(edCV.Text) / 1.3596216173039;
                    edKW.Text = kw.ToString();
                }
                catch (Exception E)
                {
                    edKW.Text = string.Empty;
                }
                isUserInput = true;
            }
        }

        private void edKW_TextChanged(object sender, EventArgs e)
        {
            if (isUserInput)
            {
                isUserInput = false;
                try
                {
                    double cavalosVapor = Double.Parse(edKW.Text) * 1.3596216173039;
                    edCV.Text = cavalosVapor.ToString();
                }
                catch (Exception E)
                {
                    edCV.Text = string.Empty;
                }
                isUserInput = true;
            }
        }
    }
}
