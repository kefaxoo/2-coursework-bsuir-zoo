using System;
using System.Windows.Forms;

namespace pet_store
{
    public partial class CloseBillForm : Form
    {
        private readonly double sum;
        private readonly SalesForm salesForm;
        
        public CloseBillForm(double sum, SalesForm salesForm)
        {
            InitializeComponent();
            this.sum = sum;
            this.salesForm = salesForm;
            sumTextBox.Text = sum.ToString();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as RadioButton).Name)
            {
                case "cashRadioButton":
                    givenSumNumericUpDown.Value = 0;
                    givenSumNumericUpDown.ReadOnly = false;
                    changeTextBox.Text = $"{Convert.ToDouble(givenSumNumericUpDown.Value) - sum}";
                    break;
                case "cardRadioButton":
                    givenSumNumericUpDown.Value = Convert.ToDecimal(sum);
                    givenSumNumericUpDown.ReadOnly = true;
                    changeTextBox.Text = "0";
                    break;
            }
        }

        private void GivenSumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            changeTextBox.Text = $"{Convert.ToDouble(givenSumNumericUpDown.Value) - sum}";
            closeBillButton.Enabled = Convert.ToDouble(changeTextBox.Text) >= 0;
        }

        private void CloseBillButton_Click(object sender, EventArgs e)
        {
            var typeMoney = cashRadioButton.Checked ? "Наличные" : "Карта";
            salesForm.SetCloseBillData(Convert.ToDouble(changeTextBox.Text), Convert.ToDouble(givenSumNumericUpDown.Value), typeMoney);
            this.Close();
        }
    }
}
