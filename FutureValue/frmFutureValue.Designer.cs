
namespace FutureValue
{
    partial class frmFutureValue
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.MonthlyInvestment = new System.Windows.Forms.Label();
            this.YearlyIntrestRate = new System.Windows.Forms.Label();
            this.NumberOfYears = new System.Windows.Forms.Label();
            this.FutureValue = new System.Windows.Forms.Label();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(81, 147);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 27);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(185, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MonthlyInvestment
            // 
            this.MonthlyInvestment.AutoSize = true;
            this.MonthlyInvestment.Location = new System.Drawing.Point(12, 18);
            this.MonthlyInvestment.Name = "MonthlyInvestment";
            this.MonthlyInvestment.Size = new System.Drawing.Size(117, 15);
            this.MonthlyInvestment.TabIndex = 2;
            this.MonthlyInvestment.Text = "Monthly Investment:";
            this.MonthlyInvestment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YearlyIntrestRate
            // 
            this.YearlyIntrestRate.AutoSize = true;
            this.YearlyIntrestRate.Location = new System.Drawing.Point(12, 48);
            this.YearlyIntrestRate.Name = "YearlyIntrestRate";
            this.YearlyIntrestRate.Size = new System.Drawing.Size(109, 15);
            this.YearlyIntrestRate.TabIndex = 3;
            this.YearlyIntrestRate.Text = "Yearly Interest Rate:";
            this.YearlyIntrestRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumberOfYears
            // 
            this.NumberOfYears.AutoSize = true;
            this.NumberOfYears.Location = new System.Drawing.Point(12, 77);
            this.NumberOfYears.Name = "NumberOfYears";
            this.NumberOfYears.Size = new System.Drawing.Size(98, 15);
            this.NumberOfYears.TabIndex = 4;
            this.NumberOfYears.Text = "Number of Years:";
            this.NumberOfYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NumberOfYears.Click += new System.EventHandler(this.label3_Click);
            // 
            // FutureValue
            // 
            this.FutureValue.AutoSize = true;
            this.FutureValue.Location = new System.Drawing.Point(12, 106);
            this.FutureValue.Name = "FutureValue";
            this.FutureValue.Size = new System.Drawing.Size(75, 15);
            this.FutureValue.TabIndex = 5;
            this.FutureValue.Text = "Future Value:";
            this.FutureValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(159, 10);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(100, 23);
            this.txtMonthlyInvestment.TabIndex = 0;
            this.txtMonthlyInvestment.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(159, 103);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(100, 23);
            this.txtFutureValue.TabIndex = 7;
            this.txtFutureValue.TabStop = false;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(159, 74);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 23);
            this.txtYears.TabIndex = 2;
            this.txtYears.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(159, 45);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 23);
            this.txtInterestRate.TabIndex = 1;
            this.txtInterestRate.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // frmFutureValue
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(281, 187);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.FutureValue);
            this.Controls.Add(this.NumberOfYears);
            this.Controls.Add(this.YearlyIntrestRate);
            this.Controls.Add(this.MonthlyInvestment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmFutureValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label MonthlyInvestment;
        private System.Windows.Forms.Label YearlyIntrestRate;
        private System.Windows.Forms.Label NumberOfYears;
        private System.Windows.Forms.Label FutureValue;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtInterestRate;
    }
}

