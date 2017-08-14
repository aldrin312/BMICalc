using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalc
{
	public partial class BMICalcForm : Form
	{
		public BMICalcForm()
		{
			InitializeComponent();
		}

		private void MyHeightLabel_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void calculateBMIButton_Click(object sender, EventArgs e)
		{
			double BMI = 0;
			double height = 0;
			height = double.Parse(heightTextBox.Text);
			double weight = 0;
			weight = double.Parse(wieghtTextBox.Text);



			if (metricRadioButton.Checked == true)
			{
				BMI = weight / (Math.Pow(height, 2));

				string output = string.Format("{0:f2} kg/m²", BMI);
				calcTextBox.Text = output;

			}
			if (imperialRadioButton.Checked == true)
			{
				BMI = weight * 703 / (Math.Pow(height, 2));

				string output = string.Format("{0:f2} lb/in²", BMI);
				calcTextBox.Text = output;
			}

			if (BMI < 18.5)
			{
				BMIScaleTextBox.Text = "Underwieght";
			}
			else if ((BMI > 18.5) && (BMI < 24.9))
			{
				BMIScaleTextBox.Text = "Normal";
			}
			else if ((BMI > 25) && (BMI < 29.9))
			{
				BMIScaleTextBox.Text = "Overwieght";
			}
			else if (BMI > 30)
			{
				BMIScaleTextBox.Text = "Obese";
			}



		}


	}
}
