namespace Oefening2
{
    public partial class IsItBigger : Form
    {
        Font LargeFont = new Font("Arial", 12);
        public IsItBigger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int first1 = 12345;
            int first2 = 54321;
            int total1 = first1 * first2;
            Calculation1.Text = first1 + " * " + first2 + " = " + total1;

            int second1 = 22222;
            int second2 = 33333;
            int total2 = second1 * second2;

            Calculation2.Text = second1 + " * " + second2 + " = " + total2;

            bool Check = (total1 > total2);
            Result.Text = Result.Text + " " + Check;

            

        }
    }
}