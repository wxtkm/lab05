using System;
using System.Globalization;
using System.Windows.Forms;

namespace zadania_5_24832
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCalculate.Click += btnCalculate_Click;
            btnClear.Click += btnClear_Click;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(
                    txtCapacity.Text,
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out double capacity))
            {
                MessageBox.Show("Podaj prawidłową pojemność naczynia.");
                txtCapacity.Focus();
                return;
            }

            if (!double.TryParse(
                    txtPercent.Text,
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out double procent))
            {
                MessageBox.Show("Podaj prawidłową zawartość procentową.");
                txtPercent.Focus();
                return;
            }

            if (!int.TryParse(txtCount.Text, out int count))
            {
                MessageBox.Show("Podaj prawidłową liczbę naczyń.");
                txtCount.Focus();
                return;
            }

            if (!BottleValidator.ValidateBottle(capacity, procent, out string error))
            {
                MessageBox.Show(error);
                return;
            }

            if (!BottleValidator.ValidateCount(count, out error))
            {
                MessageBox.Show(error);
                txtCount.Focus();
                return;
            }

            Bottle bottle = new Bottle(capacity, procent);

            double totalVolume = bottle.CalculateTotalVolume(count);
            double pureVolume = bottle.CalculatePureSubstance(count);

            lblTotalVolume.Text =
                $"{totalVolume.ToString("0.##", CultureInfo.CurrentCulture)} ml";

            lblPureVolume.Text =
                $"{pureVolume.ToString("0.##", CultureInfo.CurrentCulture)} ml";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCapacity.Clear();
            txtPercent.Clear();
            txtCount.Clear();

            cmbVessel.SelectedIndex = -1;
            cmbSolution.SelectedIndex = -1;

            lblTotalVolume.Text = "0 ml";
            lblPureVolume.Text = "0 ml";

            txtCapacity.Focus();
        }
    }
}