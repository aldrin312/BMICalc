namespace BMICalc
{
	partial class BMICalcForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.imperialRadioButton = new System.Windows.Forms.RadioButton();
			this.metricRadioButton = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.myHeightLabel = new System.Windows.Forms.Label();
			this.heightTextBox = new System.Windows.Forms.TextBox();
			this.myWieghtLabel = new System.Windows.Forms.Label();
			this.wieghtTextBox = new System.Windows.Forms.TextBox();
			this.calculateBMIButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.BMIScaleTextBox = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imperialRadioButton
			// 
			this.imperialRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.imperialRadioButton.AutoSize = true;
			this.imperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imperialRadioButton.Location = new System.Drawing.Point(164, 19);
			this.imperialRadioButton.Name = "imperialRadioButton";
			this.imperialRadioButton.Size = new System.Drawing.Size(128, 35);
			this.imperialRadioButton.TabIndex = 0;
			this.imperialRadioButton.TabStop = true;
			this.imperialRadioButton.Text = "Imperial";
			this.imperialRadioButton.UseVisualStyleBackColor = true;
			// 
			// metricRadioButton
			// 
			this.metricRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.metricRadioButton.AutoSize = true;
			this.metricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.metricRadioButton.Location = new System.Drawing.Point(23, 19);
			this.metricRadioButton.Name = "metricRadioButton";
			this.metricRadioButton.Size = new System.Drawing.Size(106, 35);
			this.metricRadioButton.TabIndex = 1;
			this.metricRadioButton.TabStop = true;
			this.metricRadioButton.Text = "Metric";
			this.metricRadioButton.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.metricRadioButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.imperialRadioButton, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.heightTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.myHeightLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.wieghtTextBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.calculateBMIButton, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.BMIScaleTextBox, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.myWieghtLabel, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 440);
			this.tableLayoutPanel1.TabIndex = 2;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// myHeightLabel
			// 
			this.myHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.myHeightLabel.AutoSize = true;
			this.myHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.myHeightLabel.Location = new System.Drawing.Point(8, 94);
			this.myHeightLabel.Name = "myHeightLabel";
			this.myHeightLabel.Size = new System.Drawing.Size(136, 31);
			this.myHeightLabel.TabIndex = 3;
			this.myHeightLabel.Text = "My Height";
			this.myHeightLabel.Click += new System.EventHandler(this.MyHeightLabel_Click);
			// 
			// heightTextBox
			// 
			this.heightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.heightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.heightTextBox.Location = new System.Drawing.Point(178, 90);
			this.heightTextBox.Name = "heightTextBox";
			this.heightTextBox.Size = new System.Drawing.Size(100, 38);
			this.heightTextBox.TabIndex = 4;
			// 
			// myWieghtLabel
			// 
			this.myWieghtLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.myWieghtLabel.AutoSize = true;
			this.myWieghtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.myWieghtLabel.Location = new System.Drawing.Point(5, 167);
			this.myWieghtLabel.Name = "myWieghtLabel";
			this.myWieghtLabel.Size = new System.Drawing.Size(141, 31);
			this.myWieghtLabel.TabIndex = 5;
			this.myWieghtLabel.Text = "My Weight";
			// 
			// wieghtTextBox
			// 
			this.wieghtTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.wieghtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wieghtTextBox.Location = new System.Drawing.Point(178, 163);
			this.wieghtTextBox.Name = "wieghtTextBox";
			this.wieghtTextBox.Size = new System.Drawing.Size(100, 38);
			this.wieghtTextBox.TabIndex = 6;
			// 
			// calculateBMIButton
			// 
			this.calculateBMIButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel1.SetColumnSpan(this.calculateBMIButton, 2);
			this.calculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calculateBMIButton.Location = new System.Drawing.Point(50, 230);
			this.calculateBMIButton.Name = "calculateBMIButton";
			this.calculateBMIButton.Size = new System.Drawing.Size(204, 50);
			this.calculateBMIButton.TabIndex = 7;
			this.calculateBMIButton.Text = "Calculate BMI";
			this.calculateBMIButton.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(54, 309);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(197, 38);
			this.textBox1.TabIndex = 8;
			// 
			// BMIScaleTextBox
			// 
			this.BMIScaleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel1.SetColumnSpan(this.BMIScaleTextBox, 2);
			this.BMIScaleTextBox.Enabled = false;
			this.BMIScaleTextBox.Location = new System.Drawing.Point(56, 376);
			this.BMIScaleTextBox.Multiline = true;
			this.BMIScaleTextBox.Name = "BMIScaleTextBox";
			this.BMIScaleTextBox.ReadOnly = true;
			this.BMIScaleTextBox.Size = new System.Drawing.Size(192, 53);
			this.BMIScaleTextBox.TabIndex = 9;
			// 
			// BMICalcForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 441);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "BMICalcForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BMI Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton imperialRadioButton;
		private System.Windows.Forms.RadioButton metricRadioButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox heightTextBox;
		private System.Windows.Forms.Label myHeightLabel;
		private System.Windows.Forms.Label myWieghtLabel;
		private System.Windows.Forms.TextBox wieghtTextBox;
		private System.Windows.Forms.Button calculateBMIButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox BMIScaleTextBox;
	}
}

