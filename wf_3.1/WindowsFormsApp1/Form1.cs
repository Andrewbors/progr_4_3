using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1(){ InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e){ comboBoxMaterial.SelectedIndex = 0; }

        private void label2_Click(object sender, EventArgs e){ }
        private void label3_Click(object sender, EventArgs e){ }
        private void twoC_CheckedChanged(object sender, EventArgs e){ }

        double c = 0;

        public void Countt()
        {
            
            double wdth = Convert.ToDouble(width.Text);
            double hght = Convert.ToDouble(height.Text);
            c += wdth*hght;

            if(oneC.Checked == true)
            {
                if(comboBoxMaterial.SelectedIndex == 0)
                {
                    c *= 0.25;
                }else if(comboBoxMaterial.SelectedIndex == 1)
                {
                    c *= 0.05;
                }else if(comboBoxMaterial.SelectedIndex == 2)
                {
                    c *= 0.15;
                }
            }else if(twoC.Checked == true)
            {
                if (comboBoxMaterial.SelectedIndex == 0)
                {
                    c *= 0.30;
                }
                else if (comboBoxMaterial.SelectedIndex == 1)
                {
                    c *= 0.10;
                }
                else if (comboBoxMaterial.SelectedIndex == 2)
                {
                    c *= 0.20;
                }
            }

            if (pidv.Checked == true) c += 35;
        }

        private void count_Click(object sender, EventArgs e)
        {
            cost.Text = "Вартість: " + c + " грн";
        }
    }
}
