namespace FutureValue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthlyInvestment = new Label();
            txtMonthlyInvestment = new TextBox();
            txtIntRate = new TextBox();
            monthlyIntRate = new Label();
            txtNumYears = new TextBox();
            yearsNum = new Label();
            txtFutureValue = new TextBox();
            valueFuture = new Label();
            btnCalc = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // monthlyInvestment
            // 
            monthlyInvestment.AutoSize = true;
            monthlyInvestment.Location = new Point(146, 94);
            monthlyInvestment.Name = "monthlyInvestment";
            monthlyInvestment.Size = new Size(230, 32);
            monthlyInvestment.TabIndex = 0;
            monthlyInvestment.Text = "Monthly Investment";
            // 
            // txtMonthlyInvestment
            // 
            txtMonthlyInvestment.Location = new Point(434, 104);
            txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            txtMonthlyInvestment.Size = new Size(200, 39);
            txtMonthlyInvestment.TabIndex = 1;
            // 
            // txtIntRate
            // 
            txtIntRate.Location = new Point(434, 171);
            txtIntRate.Name = "txtIntRate";
            txtIntRate.Size = new Size(200, 39);
            txtIntRate.TabIndex = 3;
            // 
            // monthlyIntRate
            // 
            monthlyIntRate.AutoSize = true;
            monthlyIntRate.Location = new Point(146, 161);
            monthlyIntRate.Name = "monthlyIntRate";
            monthlyIntRate.Size = new Size(245, 32);
            monthlyIntRate.TabIndex = 2;
            monthlyIntRate.Text = "Monthly Interest Rate";
            // 
            // txtNumYears
            // 
            txtNumYears.Location = new Point(434, 239);
            txtNumYears.Name = "txtNumYears";
            txtNumYears.Size = new Size(200, 39);
            txtNumYears.TabIndex = 5;
            // 
            // yearsNum
            // 
            yearsNum.AutoSize = true;
            yearsNum.Location = new Point(146, 229);
            yearsNum.Name = "yearsNum";
            yearsNum.Size = new Size(193, 32);
            yearsNum.TabIndex = 4;
            yearsNum.Text = "Number of years";
            // 
            // txtFutureValue
            // 
            txtFutureValue.Location = new Point(434, 318);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.ReadOnly = true;
            txtFutureValue.Size = new Size(200, 39);
            txtFutureValue.TabIndex = 7;            // 
            // valueFuture
            // 
            valueFuture.AutoSize = true;
            valueFuture.Location = new Point(146, 308);
            valueFuture.Name = "valueFuture";
            valueFuture.Size = new Size(148, 32);
            valueFuture.TabIndex = 6;
            valueFuture.Text = "Future Value";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(146, 433);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(150, 46);
            btnCalc.TabIndex = 8;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(407, 433);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 621);
            Controls.Add(btnExit);
            Controls.Add(btnCalc);
            Controls.Add(txtFutureValue);
            Controls.Add(valueFuture);
            Controls.Add(txtNumYears);
            Controls.Add(yearsNum);
            Controls.Add(txtIntRate);
            Controls.Add(monthlyIntRate);
            Controls.Add(txtMonthlyInvestment);
            Controls.Add(monthlyInvestment);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label monthlyInvestment;
        private TextBox txtMonthlyInvestment;
        private TextBox txtIntRate;
        private Label monthlyIntRate;
        private TextBox txtNumYears;
        private Label yearsNum;
        private TextBox txtFutureValue;
        private Label valueFuture;
        private Button btnCalc;
        private Button btnExit;
    }
}