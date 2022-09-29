namespace Oefening7
{
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int input = int.Parse(NumberInput.Text);
            for (int i = 1; i <= input; i++) {
                sum = sum + i;
            }
            NumberOutput.Text = sum.ToString();
        }
    }
}