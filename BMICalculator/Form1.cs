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

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked == true)
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




            /* var TheButton = sender as Button;
             var tag = TheButton.Tag.ToString();

             int buttonValue;
             bool resultCondition = int.TryParse(TheButton.Text, out buttonValue);
             // bool resultCondition = int.TryParse(tag, out buttonValue);

             if (resultCondition)
                 // If the use pressed a number button
                 if (resultCondition)
                 {
                     CalculatorButton.Text += TheButton.Text;
                     int maxSize = 3;
                     if (decimalExists)
                     {
                         maxSize = 5;
                     }

                     if ((outputString != "0") && (ResultTextBox.Text.Count() < maxSize))
                     {
                         outputString += tag;
                         ResultTextBox.Text = outputString;
                     }
                 }



             /// <summary>
             /// This method adds a decimal to the ResultLabel
             /// </summary>


                 if (!decimalExists)
                 {
                     outputString += ".";
                     decimalExists = true;
                 }

             */










        }

        private void HeightTextBox_Click(object sender, EventArgs e)
        {


            /*
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int buttonValue;
            bool resultCondition = int.TryParse(TheButton.Text, out buttonValue);*/
        }

        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
