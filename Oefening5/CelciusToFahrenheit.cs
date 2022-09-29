namespace Opdracht5
{
    public partial class CelciusToFahrenheit : Form
    {
        public CelciusToFahrenheit()
        {
            InitializeComponent();
        }

        private void CtoFButton_Click(object sender, EventArgs e)
        {
            //Converts Celsius into Fahrenheit
            FahrenheitBox.Text = null;
            decimal celsius = decimal.Parse(CelsiusBox.Text);
            decimal converted = (celsius * 9) / 5 + 32;
            FahrenheitBox.Text = converted.ToString();

        }

        private void FtoCButton_Click(object sender, EventArgs e)
        {
            //Converts Fahrenheit into Celsius
            CelsiusBox.Text = null;
            decimal fahrenheit = decimal.Parse(FahrenheitBox.Text);
            decimal converted = (fahrenheit - 32) * 5/(decimal) 9; // ( ) casting
            CelsiusBox.Text = converted.ToString();
        }
    }
}