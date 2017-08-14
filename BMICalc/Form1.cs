using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name  : Aldrin Fernandez
 * ID   : 300936281
 * Date : August 14,2017
 * Description : This is a BMI calculator
 * Version : use the inputs to calculate the BMI and scale
 */
namespace BMICalc
{
	public partial class BMICalcForm : Form
	{
		public BMICalcForm()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}


		/// <summary>
		/// This is the event that calculate the BMI depending on the selected unit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		/// <summary>
		/// This change the units on the myWiegjtLabel and myHeightLabel according to the selected unit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void imperialRadioButton_Click(object sender, EventArgs e)
		{
			myWieghtLabel.Text = "My Wieght (lb)";
			myHeightLabel.Text = "My Height (in)";
		}

		private void metricRadioButton_Click(object sender, EventArgs e)
		{
			myWieghtLabel.Text = "My Wieght (kg)";
			myHeightLabel.Text = "My Height (m)";
		}
	}
}
