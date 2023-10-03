namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                decimal yearlyInterestR = Convert.ToDecimal(txtIntRate.Text);
                int years = Convert.ToInt32(txtNumYears.Text);

                decimal months = years * 12;
                decimal monthlyInterestR = yearlyInterestR / 12 / 100;

                decimal futureValue = 0m;

                for (int i = 0; i < months; i++)
                {
                    futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestR);
                }
                txtFutureValue.Text = futureValue.ToString("c");
                txtMonthlyInvestment.Focus();
            }

            catch(FormatException ex)
            {
                MessageBox.Show("This is not allowed!" + ex.Message + " /n " + ex.GetType());
            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}