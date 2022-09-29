using System.Security.Cryptography.X509Certificates;

namespace Oefening4
{
    public partial class SalesTaxCalculator : Form
    {
        public SalesTaxCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string item1 = Item1.Text;
            string item2 = Item2.Text;
            string item3 = Item3.Text;
            string item4 = Item4.Text;

            decimal item1Quantity = QuantityItem1.Value;
            decimal item2Quantity = QuantityItem2.Value;
            decimal item3Quantity = QuantityItem3.Value;
            decimal item4Quantity = QuantityItem4.Value;

            
            decimal priceItem1 = decimal.Parse(PriceEachItem1.Text);
            decimal priceItem2 = decimal.Parse(PriceEachItem2.Text);
            decimal priceItem3 = decimal.Parse(PriceEachItem3.Text);
            decimal priceItem4 = decimal.Parse(PriceEachItem4.Text);

            //----------------------------------------------------------//

            decimal extPriceItem1 = priceItem1 * item1Quantity;
            decimal extPriceItem2 = priceItem2 * item2Quantity;
            decimal extPriceItem3 = priceItem3 * item3Quantity;
            decimal extPriceItem4 = priceItem4 * item4Quantity;

            decimal subtotal = extPriceItem1 + extPriceItem2 + extPriceItem3 + extPriceItem4;

            ExtPriceItem1.Text = "€ " + extPriceItem1.ToString();
            ExtPriceItem2.Text = "€ " + extPriceItem2.ToString();
            ExtPriceItem3.Text = "€ " + extPriceItem3.ToString();
            ExtPriceItem4.Text = "€ " + extPriceItem4.ToString();
            SubTotalOutput.Text = "€ " + subtotal.ToString();
            decimal taxrate = decimal.Parse(TaxRate.Text);
            decimal salestax = subtotal * taxrate;
            decimal shipping = decimal.Parse(Shipping.Text);
            decimal grandtotal = subtotal + salestax + shipping;
            SalesTaxOutput.Text = salestax.ToString();
            GrandTotalOutput.Text = "€ " + grandtotal.ToString();
            Shipping.Text = "€ " + shipping;

            //ToString();




        }
          
        private void Form1_Load(object sender, EventArgs e)
        {
            //ShippingBox.Text = "€ 5.00";


        }


    }
}