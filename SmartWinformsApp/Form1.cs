using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperCalculator;

namespace SmartWinformsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            SmartCalculator calculator=new SmartCalculator();
            int a = int.Parse(this.txtA.Text);
            int b = int.Parse(this.txtB.Text);

            int result= calculator.Sum(a, b);
            this.ResultLabel.Text = result.ToString();
        }
    }
}
