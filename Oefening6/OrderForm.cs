namespace Oefening6
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Is eigenlijk niet nodig om de namen bij te houden, in oefening 4 ook niet.
            string item1 = Item1.Text;
            string item2 = Item2.Text;
            string item3 = Item3.Text;
            string item4 = Item4.Text;

            decimal priceItem1 = decimal.Parse(PriceEach1.Text);
            decimal priceItem2 = decimal.Parse(PriceEach2.Text);
            decimal priceItem3 = decimal.Parse(PriceEach3.Text);
            decimal priceItem4 = decimal.Parse(PriceEach4.Text);

            decimal quantity1 = decimal.Parse(Quantity1.Text);
            decimal quantity2 = decimal.Parse(Quantity2.Text);
            decimal quantity3 = decimal.Parse(Quantity3.Text);
            decimal quantity4 = decimal.Parse(Quantity4.Text);

            decimal totalPrice1 = priceItem1 * quantity1;
            decimal totalPrice2 = priceItem2 * quantity2;
            decimal totalPrice3 = priceItem3 * quantity3;
            decimal totalPrice4 = priceItem4 * quantity4;

            TotalPrice1.Text = totalPrice1.ToString();
            TotalPrice2.Text = totalPrice2.ToString();
            TotalPrice3.Text = totalPrice3.ToString();
            TotalPrice4.Text = totalPrice4.ToString();

            decimal subTotal = totalPrice1 + totalPrice2 + totalPrice3 + totalPrice4;
            SubTotal.Text = subTotal.ToString();

            decimal salesTax = subTotal * 7 / 100;
            SalesTax.Text = String.Format("{0:0.00}", salesTax);

            decimal shippingPrice = 0;
            if (subTotal < 20)
            {
                shippingPrice = 5;
            }
            else if (subTotal < 50)
            {
                shippingPrice = (decimal)7.5;
            }
            else if (subTotal < 75)
            {
                shippingPrice = 10;
            }
            else if (subTotal >= 75)
            {
                shippingPrice = 0;
            }
            ShippingPrice.Text = String.Format("{0:0.00}", shippingPrice);
            decimal grandTotal = subTotal + salesTax + shippingPrice;
            GrandTotal.Text = String.Format("{0:0.00}", grandTotal);
        }
    }
}