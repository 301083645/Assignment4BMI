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
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.heightLabel = new System.Windows.Forms.Label();
            this.IorMtextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.PorKtextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.inchesButton = new System.Windows.Forms.RadioButton();
            this.metresButton = new System.Windows.Forms.RadioButton();
            this.kilogramsButton = new System.Windows.Forms.RadioButton();
            this.poundsButton = new System.Windows.Forms.RadioButton();
            this.ScreenLayoutPanel1.SuspendLayout();
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
            this.ScreenLayoutPanel1.Controls.Add(this.MetricButton, 3, 1);
            this.ScreenLayoutPanel1.Controls.Add(this.heightLabel, 0, 3);
            this.ScreenLayoutPanel1.Controls.Add(this.weightLabel, 0, 5);
            this.ScreenLayoutPanel1.Controls.Add(this.PorKtextBox, 3, 5);
            this.ScreenLayoutPanel1.Controls.Add(this.calculateButton, 1, 7);
            this.ScreenLayoutPanel1.Controls.Add(this.IorMtextBox, 3, 3);
            this.ScreenLayoutPanel1.Controls.Add(this.ImperialButton, 0, 1);
            this.ScreenLayoutPanel1.Controls.Add(this.metresButton, 4, 4);
            this.ScreenLayoutPanel1.Controls.Add(this.inchesButton, 3, 4);
            this.ScreenLayoutPanel1.Controls.Add(this.kilogramsButton, 3, 6);
            this.ScreenLayoutPanel1.Controls.Add(this.poundsButton, 4, 6);
            this.ScreenLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.ScreenLayoutPanel1.Name = "ScreenLayoutPanel1";
            this.ScreenLayoutPanel1.RowCount = 10;
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ScreenLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ScreenLayoutPanel1.Size = new System.Drawing.Size(280, 417);
            this.ScreenLayoutPanel1.TabIndex = 0;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.Tan;
            this.ScreenLayoutPanel1.SetColumnSpan(this.titleTextBox, 5);
            this.titleTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.titleTextBox.Location = new System.Drawing.Point(3, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(274, 38);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.Text = "BMI Calculator";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Checked = true;
            this.ScreenLayoutPanel1.SetColumnSpan(this.ImperialButton, 2);
            this.ImperialButton.Location = new System.Drawing.Point(3, 44);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(106, 35);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.ScreenLayoutPanel1.SetColumnSpan(this.MetricButton, 2);
            this.MetricButton.Location = new System.Drawing.Point(171, 44);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(106, 35);
            this.MetricButton.TabIndex = 2;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.ScreenLayoutPanel1.SetColumnSpan(this.heightLabel, 3);
            this.heightLabel.Location = new System.Drawing.Point(3, 123);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(162, 41);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "My height";
            this.heightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IorMtextBox
            // 
            this.IorMtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenLayoutPanel1.SetColumnSpan(this.IorMtextBox, 2);
            this.IorMtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IorMtextBox.Location = new System.Drawing.Point(171, 126);
            this.IorMtextBox.Name = "IorMtextBox";
            this.IorMtextBox.Size = new System.Drawing.Size(106, 29);
            this.IorMtextBox.TabIndex = 4;
            this.IorMtextBox.Text = "inches";
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightLabel.AutoSize = true;
            this.ScreenLayoutPanel1.SetColumnSpan(this.weightLabel, 3);
            this.weightLabel.Location = new System.Drawing.Point(3, 205);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(162, 41);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "My Weight";
            // 
            // PorKtextBox
            // 
            this.PorKtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenLayoutPanel1.SetColumnSpan(this.PorKtextBox, 2);
            this.PorKtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorKtextBox.Location = new System.Drawing.Point(171, 208);
            this.PorKtextBox.Name = "PorKtextBox";
            this.PorKtextBox.Size = new System.Drawing.Size(106, 29);
            this.PorKtextBox.TabIndex = 6;
            this.PorKtextBox.Text = "kilograms";
            // 
            // calculateButton
            // 
            this.ScreenLayoutPanel1.SetColumnSpan(this.calculateButton, 3);
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(59, 290);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(162, 35);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate BMI";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // inchesButton
            // 
            this.inchesButton.AutoSize = true;
            this.inchesButton.Checked = true;
            this.inchesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesButton.Location = new System.Drawing.Point(171, 167);
            this.inchesButton.Name = "inchesButton";
            this.inchesButton.Size = new System.Drawing.Size(39, 24);
            this.inchesButton.TabIndex = 8;
            this.inchesButton.TabStop = true;
            this.inchesButton.Text = "in";
            this.inchesButton.UseVisualStyleBackColor = true;
            this.inchesButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // metresButton
            // 
            this.metresButton.AutoSize = true;
            this.metresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metresButton.Location = new System.Drawing.Point(227, 167);
            this.metresButton.Name = "metresButton";
            this.metresButton.Size = new System.Drawing.Size(40, 24);
            this.metresButton.TabIndex = 9;
            this.metresButton.Text = "m";
            this.metresButton.UseVisualStyleBackColor = true;
            // 
            // kilogramsButton
            // 
            this.kilogramsButton.AutoSize = true;
            this.kilogramsButton.Checked = true;
            this.kilogramsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilogramsButton.Location = new System.Drawing.Point(171, 249);
            this.kilogramsButton.Name = "kilogramsButton";
            this.kilogramsButton.Size = new System.Drawing.Size(44, 24);
            this.kilogramsButton.TabIndex = 10;
            this.kilogramsButton.TabStop = true;
            this.kilogramsButton.Text = "kg";
            this.kilogramsButton.UseVisualStyleBackColor = true;
            // 
            // poundsButton
            // 
            this.poundsButton.AutoSize = true;
            this.poundsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundsButton.Location = new System.Drawing.Point(227, 249);
            this.poundsButton.Name = "poundsButton";
            this.poundsButton.Size = new System.Drawing.Size(39, 24);
            this.poundsButton.TabIndex = 11;
            this.poundsButton.Text = "lb";
            this.poundsButton.UseVisualStyleBackColor = true;
            // 
            // BMI_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ScreenLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMI_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMI_Calculator_Load);
            this.ScreenLayoutPanel1.ResumeLayout(false);
            this.ScreenLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ScreenLayoutPanel1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox PorKtextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox IorMtextBox;
        private System.Windows.Forms.RadioButton inchesButton;
        private System.Windows.Forms.RadioButton metresButton;
        private System.Windows.Forms.RadioButton kilogramsButton;
        private System.Windows.Forms.RadioButton poundsButton;
    }
}

