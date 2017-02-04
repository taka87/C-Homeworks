using System;
using System.Windows.Forms;

namespace _01.BGNtoEurConverter
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDownAmmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void FormConverter_Load(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertCurrency();
        }
        private void ConvertCurrency()
        {
            var ammountBGN = this.numericUpDownAmount.Value;
            var ammountEUR = ammountBGN * 1.95583m;
            this.labelResult.Text = ammountBGN + " BGN = " + Math.Round(ammountEUR, 2) + " EUR";
        }
    }
}
