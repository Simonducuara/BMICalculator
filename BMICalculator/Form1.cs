using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        float Hieghtvalue;
        float Weightvalue;
        float Bmivalue;
        public bool decimalExists { get; set; }
        public string outputString { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            if (WeightTextBox.Text == "")
            {
                string message = "Empty fields";
                MessageBox.Show(message);

            }
            else if (HeightTextBox.Text == "")
            {
                string message = "Empty fields";
                MessageBox.Show(message);

            }
            else if (ImperialRadioButton.Checked == true)
            {
                ResultTextBox.BackColor = Color.White;

                Hieghtvalue = float.Parse(HeightTextBox.Text);
                Weightvalue = float.Parse(WeightTextBox.Text);
                Bmivalue = (Weightvalue * 703) / (Hieghtvalue * Hieghtvalue);

                //ResultTextBox.Text = string.Format("{0:f}", Bmivalue);
                ResultTextBox.Text = Bmivalue.ToString();
            }
            else
            {
                ResultTextBox.BackColor = Color.White;

                Hieghtvalue = float.Parse(HeightTextBox.Text);
                Weightvalue = float.Parse(WeightTextBox.Text);
                Bmivalue = Weightvalue / (Hieghtvalue * Hieghtvalue);

                //ResultTextBox.Text = string.Format("{0:f}", Bmivalue);
                ResultTextBox.Text = Bmivalue.ToString();
            }


            if (Bmivalue <= 18.5)
            {
                ResultTextBox.BackColor = Color.Yellow;
            }
            else if (Bmivalue >= 18.5 && Bmivalue <= 24.9)
            {
                ResultTextBox.BackColor = Color.Green;
            }
            else if (Bmivalue >= 25 && Bmivalue <= 29.9)
            {
                ResultTextBox.BackColor = Color.Orange;
            }
            else if (Bmivalue >= 30)
            {
                ResultTextBox.BackColor = Color.Red;
            }

        }

        private void HeightTextBox_Click(object sender, EventArgs e)
        {


           
        }
        
        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
