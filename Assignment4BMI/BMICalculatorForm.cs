using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4BMI
{
    public partial class BMI_Calculator : Form
    {
        public BMI_Calculator()
        {
            InitializeComponent();
            
        }

       

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "0";
            WeightTextBox.Text = "0";
            ResultTextBox.Text = "Result";
            titleTextBox.Text = "BMI Calculator";

            

            kilogramsButton.Checked = true;
            poundsButton.Checked = false;
            inchesButton.Checked = true;
            metresButton.Checked = false;
            ImperialButton.Checked = true;
            MetricButton.Checked = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double height = Convert.ToDouble(HeightTextBox.Text);
            string result = "";
            double bmi = 0;

            if (kilogramsButton.Checked)
            {
                if (metresButton.Checked)
                {
                    bmi = weight / (height * height);

                }else if (inchesButton.Checked)
                {
                    height = height * 0.0254;
                    bmi = weight / (height * height);
                }
                else
                {
                    bmi = 0;
                }
            }
            else if (poundsButton.Checked)
            {
                if (metresButton.Checked)
                {
                    height = height * 39.37;
                    bmi = weight * 703 / (height * height);
                }
                else if (inchesButton.Checked)
                {
                    bmi = weight * 703 / (height * height);
                }
                else
                {
                    bmi = 0;
                }
            }
            else
            {
                ResultTextBox.Text = "Error!";
            }

            result = string.Format("{0:n2}", bmi);
            titleTextBox.Text = "Your BMI is " +result;

            if(bmi < 18.5)
            {
                ResultTextBox.Text = " You are Underweight.";
                BMIprogressBar.Value = 25;
            }else if(bmi >= 18.5 && bmi < 25)
            {
                ResultTextBox.Text = " You are Normal.";
                BMIprogressBar.Value = 50;
            }
            else if (bmi >= 25 && bmi < 30)
            {
                ResultTextBox.Text = " You are Overweight.";
                BMIprogressBar.Value = 75;
            }
            else
            {
                ResultTextBox.Text = " You are Obese.";
                BMIprogressBar.Value = 100;
            }



        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            poundsButton.Checked = true;
            kilogramsButton.Checked = false;
            inchesButton.Checked = true;
            metresButton.Checked = false;

        }

        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            poundsButton.Checked = false;
            kilogramsButton.Checked = true;
            inchesButton.Checked = false;
            metresButton.Checked = true;
        }
    }
}
