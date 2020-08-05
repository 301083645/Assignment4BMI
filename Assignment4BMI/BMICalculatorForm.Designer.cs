namespace Assignment4BMI
{
    partial class BMI_Calculator
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
            this.ScreenLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.IorMGroupBox = new System.Windows.Forms.GroupBox();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.heightGroupBox = new System.Windows.Forms.GroupBox();
            this.inchesButton = new System.Windows.Forms.RadioButton();
            this.metresButton = new System.Windows.Forms.RadioButton();
            this.WeightGroupBox = new System.Windows.Forms.GroupBox();
            this.kilogramsButton = new System.Windows.Forms.RadioButton();
            this.poundsButton = new System.Windows.Forms.RadioButton();
            this.BMIprogressBar = new System.Windows.Forms.ProgressBar();
            this.ScreenLayoutPanel1.SuspendLayout();
            this.IorMGroupBox.SuspendLayout();
            this.heightGroupBox.SuspendLayout();
            this.WeightGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreenLayoutPanel1
            // 
            this.ScreenLayoutPanel1.ColumnCount = 5;
            this.ScreenLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScreenLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScreenLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScreenLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScreenLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScreenLayoutPanel1.Controls.Add(this.titleTextBox, 0, 0);
            this.ScreenLayoutPanel1.Controls.Add(this.heightLabel, 0, 3);
            this.ScreenLayoutPanel1.Controls.Add(this.weightLabel, 0, 5);
            this.ScreenLayoutPanel1.Controls.Add(this.WeightTextBox, 3, 5);
            this.ScreenLayoutPanel1.Controls.Add(this.calculateButton, 0, 7);
            this.ScreenLayoutPanel1.Controls.Add(this.HeightTextBox, 3, 3);
            this.ScreenLayoutPanel1.Controls.Add(this.ResultTextBox, 0, 8);
            this.ScreenLayoutPanel1.Controls.Add(this.ResetButton, 3, 7);
            this.ScreenLayoutPanel1.Controls.Add(this.IorMGroupBox, 0, 2);
            this.ScreenLayoutPanel1.Controls.Add(this.heightGroupBox, 3, 4);
            this.ScreenLayoutPanel1.Controls.Add(this.WeightGroupBox, 3, 6);
            this.ScreenLayoutPanel1.Controls.Add(this.BMIprogressBar, 0, 1);
            this.ScreenLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.ScreenLayoutPanel1.Name = "ScreenLayoutPanel1";
            this.ScreenLayoutPanel1.RowCount = 9;
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.ScreenLayoutPanel1.Size = new System.Drawing.Size(280, 417);
            this.ScreenLayoutPanel1.TabIndex = 0;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScreenLayoutPanel1.SetColumnSpan(this.titleTextBox, 5);
            this.titleTextBox.Enabled = false;
            this.titleTextBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.titleTextBox.Location = new System.Drawing.Point(3, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(274, 31);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.Text = "BMI Calculator";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.ScreenLayoutPanel1.SetColumnSpan(this.heightLabel, 3);
            this.heightLabel.Location = new System.Drawing.Point(3, 126);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(162, 42);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "My height :";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightLabel.AutoSize = true;
            this.ScreenLayoutPanel1.SetColumnSpan(this.weightLabel, 3);
            this.weightLabel.Location = new System.Drawing.Point(3, 210);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(162, 42);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "My Weight :";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenLayoutPanel1.SetColumnSpan(this.WeightTextBox, 2);
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(171, 213);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(106, 29);
            this.WeightTextBox.TabIndex = 6;
            this.WeightTextBox.Text = "0";
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTextBox_KeyPress);
            // 
            // calculateButton
            // 
            this.ScreenLayoutPanel1.SetColumnSpan(this.calculateButton, 3);
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(3, 297);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(162, 35);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate BMI";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenLayoutPanel1.SetColumnSpan(this.HeightTextBox, 2);
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(171, 129);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(106, 29);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.Text = "0";
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTextBox_KeyPress);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScreenLayoutPanel1.SetColumnSpan(this.ResultTextBox, 5);
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.ResultTextBox.Location = new System.Drawing.Point(3, 339);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(274, 75);
            this.ResultTextBox.TabIndex = 12;
            this.ResultTextBox.Text = "Result ";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResetButton
            // 
            this.ScreenLayoutPanel1.SetColumnSpan(this.ResetButton, 2);
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(171, 297);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(106, 35);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // IorMGroupBox
            // 
            this.IorMGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IorMGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ScreenLayoutPanel1.SetColumnSpan(this.IorMGroupBox, 5);
            this.IorMGroupBox.Controls.Add(this.ImperialButton);
            this.IorMGroupBox.Controls.Add(this.MetricButton);
            this.IorMGroupBox.Location = new System.Drawing.Point(3, 87);
            this.IorMGroupBox.Name = "IorMGroupBox";
            this.IorMGroupBox.Size = new System.Drawing.Size(274, 36);
            this.IorMGroupBox.TabIndex = 14;
            this.IorMGroupBox.TabStop = false;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Checked = true;
            this.ImperialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialButton.Location = new System.Drawing.Point(6, 0);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(94, 28);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Tag = "IorM";
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricButton.Location = new System.Drawing.Point(168, 0);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(79, 28);
            this.MetricButton.TabIndex = 2;
            this.MetricButton.Tag = "IorM";
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // heightGroupBox
            // 
            this.heightGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenLayoutPanel1.SetColumnSpan(this.heightGroupBox, 2);
            this.heightGroupBox.Controls.Add(this.inchesButton);
            this.heightGroupBox.Controls.Add(this.metresButton);
            this.heightGroupBox.Location = new System.Drawing.Point(171, 171);
            this.heightGroupBox.Name = "heightGroupBox";
            this.heightGroupBox.Size = new System.Drawing.Size(106, 36);
            this.heightGroupBox.TabIndex = 15;
            this.heightGroupBox.TabStop = false;
            // 
            // inchesButton
            // 
            this.inchesButton.AutoSize = true;
            this.inchesButton.Checked = true;
            this.inchesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesButton.Location = new System.Drawing.Point(0, 0);
            this.inchesButton.Name = "inchesButton";
            this.inchesButton.Size = new System.Drawing.Size(39, 24);
            this.inchesButton.TabIndex = 8;
            this.inchesButton.TabStop = true;
            this.inchesButton.Text = "in";
            this.inchesButton.UseVisualStyleBackColor = true;
            // 
            // metresButton
            // 
            this.metresButton.AutoSize = true;
            this.metresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metresButton.Location = new System.Drawing.Point(55, 0);
            this.metresButton.Name = "metresButton";
            this.metresButton.Size = new System.Drawing.Size(40, 24);
            this.metresButton.TabIndex = 9;
            this.metresButton.Text = "m";
            this.metresButton.UseVisualStyleBackColor = true;
            // 
            // WeightGroupBox
            // 
            this.WeightGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenLayoutPanel1.SetColumnSpan(this.WeightGroupBox, 2);
            this.WeightGroupBox.Controls.Add(this.kilogramsButton);
            this.WeightGroupBox.Controls.Add(this.poundsButton);
            this.WeightGroupBox.Location = new System.Drawing.Point(171, 255);
            this.WeightGroupBox.Name = "WeightGroupBox";
            this.WeightGroupBox.Size = new System.Drawing.Size(106, 36);
            this.WeightGroupBox.TabIndex = 16;
            this.WeightGroupBox.TabStop = false;
            // 
            // kilogramsButton
            // 
            this.kilogramsButton.AutoSize = true;
            this.kilogramsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilogramsButton.Location = new System.Drawing.Point(55, 0);
            this.kilogramsButton.Name = "kilogramsButton";
            this.kilogramsButton.Size = new System.Drawing.Size(44, 24);
            this.kilogramsButton.TabIndex = 10;
            this.kilogramsButton.Text = "kg";
            this.kilogramsButton.UseVisualStyleBackColor = true;
            // 
            // poundsButton
            // 
            this.poundsButton.AutoSize = true;
            this.poundsButton.Checked = true;
            this.poundsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundsButton.Location = new System.Drawing.Point(0, 0);
            this.poundsButton.Name = "poundsButton";
            this.poundsButton.Size = new System.Drawing.Size(39, 24);
            this.poundsButton.TabIndex = 11;
            this.poundsButton.TabStop = true;
            this.poundsButton.Text = "lb";
            this.poundsButton.UseVisualStyleBackColor = true;
            // 
            // BMIprogressBar
            // 
            this.BMIprogressBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.ScreenLayoutPanel1.SetColumnSpan(this.BMIprogressBar, 5);
            this.BMIprogressBar.Enabled = false;
            this.BMIprogressBar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BMIprogressBar.Location = new System.Drawing.Point(3, 45);
            this.BMIprogressBar.Name = "BMIprogressBar";
            this.BMIprogressBar.Size = new System.Drawing.Size(274, 23);
            this.BMIprogressBar.TabIndex = 17;
            this.BMIprogressBar.Visible = false;
            // 
            // BMI_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ScreenLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMI_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ScreenLayoutPanel1.ResumeLayout(false);
            this.ScreenLayoutPanel1.PerformLayout();
            this.IorMGroupBox.ResumeLayout(false);
            this.IorMGroupBox.PerformLayout();
            this.heightGroupBox.ResumeLayout(false);
            this.heightGroupBox.PerformLayout();
            this.WeightGroupBox.ResumeLayout(false);
            this.WeightGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ScreenLayoutPanel1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.RadioButton inchesButton;
        private System.Windows.Forms.RadioButton metresButton;
        private System.Windows.Forms.RadioButton kilogramsButton;
        private System.Windows.Forms.RadioButton poundsButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox IorMGroupBox;
        private System.Windows.Forms.GroupBox heightGroupBox;
        private System.Windows.Forms.GroupBox WeightGroupBox;
        private System.Windows.Forms.ProgressBar BMIprogressBar;
    }
}

