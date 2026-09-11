namespace _049_Balberan_JhonRey_PACT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double Total = 0;
            double discount = .0;

            string Receipt = "\t       --- Order Summary ---\n\n\n#Main Meal\n";

            if (cmbMainmeal.SelectedIndex == 0)
            {
                Total += 120;
                Receipt += "Burger Meal:\t\t\tP120\n";
            }
            else if (cmbMainmeal.SelectedIndex == 1)
            {
                Total += 150;
                Receipt += "Chicken Meal:\t\t\tP150\n";
            }
            else if (cmbMainmeal.SelectedIndex == 2)
            {
                Total += 130;
                Receipt += "Spaghetti Meal:\t\t\tP130\n";
            }
            else if (cmbMainmeal.SelectedIndex == 3)
            {
                Total += 250;
                Receipt += "Pizza Meal:\t\t\tP250\n";
            }
            else
            {
                MessageBox.Show("You must select one (1) main meal from the available menu.");
                return;
            }

            // Drinks
            Receipt += "\n#Drinks\n";
            if (radDrinkMedium.Checked)
            {
                Total += 20;
                Receipt += "Drink Medium:\t\t\tP20\n";
            }
            else if (radDrinkLarge.Checked)
            {
                Total += 40;
                Receipt += "Drink Large:\t\t\tP40\n";
            }
            else
            {
                Receipt += "Drink Small:\t\t\tP0\n";
            }

            // Addons
            Receipt += "\n#Addons\n";
            if (chkFries.Checked)
            {
                Total += 50;
                Receipt += "Fries:\t\t\t\tP50\n";
            }
            if (chkExtraCheese.Checked)
            {
                Total += 25;
                Receipt += "Extra Cheese:\t\t\tP25\n";
            }
            if (chkDessert.Checked)
            {
                Total += 70;
                Receipt += "Dessert:\t\t\t\tP70\n";
            }

            // Discounts
            Receipt += "\n#Discounts Applied\n";
            if (Total >= 400)
            {
                discount += .10;
                Receipt += "400+ Order Discount:\t\t10%\n";
            }
            if (chkSeniorDiscount.Checked)
            {
                discount += .20;
                Receipt += "Senior Discount:\t\t\t20%\n";
            }

            double totalDiscountAmount = Total * discount;
            Receipt += $"\nTotal discounts:\t\t\tP{totalDiscountAmount:F2}\n";

            Total -= Total * discount;
            Receipt += $"Total:\t\t\t\tP{Total:F2}\n";

            MessageBox.Show(Receipt);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbMainmeal.SelectedIndex = -1;
            radDrinkLarge.Checked = false;
            radDrinkMedium.Checked = false;
            radDrinkSmall.Checked = false;
            chkFries.Checked = false;
            chkExtraCheese.Checked = false;
            chkDessert.Checked = false;
            chkSeniorDiscount.Checked = false;
        }
    }
}
