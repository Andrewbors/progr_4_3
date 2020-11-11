using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            country.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e){ }

        private double c = 0;
        private double Countt()
        {
            if(summer.Checked == true)
            {
                if(country.SelectedIndex == 0)
                {
                    c += 150;
                }else if (country.SelectedIndex == 1)
                {
                    c += 160;
                }else if (country.SelectedIndex == 2)
                {
                    c += 120;
                }
            }
            else if(winter.Checked == true)
            {
                if (country.SelectedIndex == 0)
                {
                    c += 150;
                }
                else if (country.SelectedIndex == 1)
                {
                    c += 200;
                }
                else if (country.SelectedIndex == 2)
                {
                    c += 180;
                }
            }

            if (gid.Checked == true) c += 35;

            return c;
        }

        private void count_Click()
        {
            cost.Text = "Вартість: " + Countt() + " грн";
        }
    }
}
