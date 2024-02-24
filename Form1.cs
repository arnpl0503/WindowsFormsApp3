using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mat, sci, eng, fil, his;
            string total;

            mat = int.Parse(tbtMath.Text);
            sci = int.Parse(tbtScience.Text);
            eng = int.Parse(tbtEnglish.Text);
            fil = int.Parse(tbtFilipino.Text);
            his = int.Parse(tbtHistory.Text);

            double Total = (mat + sci + eng + fil + his) / 5;
            tbtTotal.Text = Total.ToString();
        }
    }
}
