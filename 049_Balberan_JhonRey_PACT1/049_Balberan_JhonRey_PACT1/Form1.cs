namespace _049_Balberan_JhonRey_PACT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeValues();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int Total = 0, Expenses = 0, AppleSold = 0, AppleWeeklySales = 0, OrangeSold = 0, OrangeWeeklySales = 0;
            double AvgAppleSales = 0, AvgOrangeSales = 0;
  
            AppleSold += int.Parse(txtApplesSunday.Text);
            AppleSold += int.Parse(txtApplesMonday.Text);
            AppleSold += int.Parse(txtApplesTuesday.Text);
            AppleSold += int.Parse(txtApplesWednesday.Text);
            AppleSold += int.Parse(txtApplesThursday.Text);
            AppleSold += int.Parse(txtApplesFriday.Text);
            AppleSold += int.Parse(txtApplesSaturday.Text);

            AppleWeeklySales = AppleSold * 15;
            AvgAppleSales = AppleWeeklySales / 7;

            lblApplesSold.Text = "Apples sold for the week: " + Convert.ToString(AppleSold);
            lblAppleSales.Text = "Apples weekly sales: " + Convert.ToString(AppleWeeklySales);
            lblAppleSalesAvg.Text = "Average apple sales: " + Convert.ToString(AvgAppleSales);

            OrangeSold += int.Parse(txtOrangesSunday.Text);
            OrangeSold += int.Parse(txtOrangesMonday.Text);
            OrangeSold += int.Parse(txtOrangesTuesday.Text);
            OrangeSold += int.Parse(txtOrangesWednesday.Text);
            OrangeSold += int.Parse(txtOrangesThursday.Text);
            OrangeSold += int.Parse(txtOrangesFriday.Text);
            OrangeSold += int.Parse(txtOrangesSaturday.Text);

            OrangeWeeklySales = OrangeSold * 13;
            AvgOrangeSales = OrangeWeeklySales / 7;

            lblOrangesSold.Text = "Oranges sold for the week: " + Convert.ToString(OrangeSold);
            lblOrangesSales.Text = "Oranges weekly sales: " + Convert.ToString(OrangeWeeklySales);
            lblOrangesSalesAvg.Text = "Average oranges sales: " + Convert.ToString(AvgOrangeSales);

            Total = OrangeWeeklySales + AppleWeeklySales;
            Expenses = (OrangeSold * 7) + (AppleSold * 9);
            lblTotal.Text = "Total sales for the week: " + Convert.ToString(Total);
            lblNetIncome.Text = "Net Income: " + Convert.ToString(Total - Expenses);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtApplesSunday.Clear();
            txtApplesMonday.Clear();
            txtApplesTuesday.Clear();
            txtApplesWednesday.Clear();
            txtApplesThursday.Clear();
            txtApplesFriday.Clear();
            txtApplesSaturday.Clear();
            txtOrangesSunday.Clear();
            txtOrangesMonday.Clear();
            txtOrangesTuesday.Clear();
            txtOrangesWednesday.Clear();
            txtOrangesThursday.Clear();
            txtOrangesFriday.Clear();
            txtOrangesSaturday.Clear();
            lblApplesSold.Text = "Apples sold for the week: ";
            lblAppleSales.Text = "Apples weekly sales: ";
            lblAppleSalesAvg.Text = "Average apple sales: ";
            lblOrangesSold.Text = "Oranges sold for the week: ";
            lblOrangesSales.Text = "Oranges weekly sales: ";
            lblOrangesSalesAvg.Text = "Average oranges sales: ";
            lblTotal.Text = "Total sales for the week: ";
            lblNetIncome.Text = "Net Income: ";
            InitializeValues();
        }

        void InitializeValues()
        {
            txtApplesSunday.Text = "0";
            txtApplesMonday.Text = "0";
            txtApplesTuesday.Text = "0";
            txtApplesWednesday.Text = "0";
            txtApplesThursday.Text = "0";
            txtApplesFriday.Text = "0";
            txtApplesSaturday.Text = "0";
            txtOrangesSunday.Text = "0";
            txtOrangesMonday.Text = "0";
            txtOrangesTuesday.Text = "0";
            txtOrangesWednesday.Text = "0";
            txtOrangesThursday.Text = "0";
            txtOrangesFriday.Text = "0";
            txtOrangesSaturday.Text = "0";
        }
    }
}
