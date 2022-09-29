namespace Oefening1
{
    internal static class Begroeting
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string Username = Environment.UserName;
            string Time = DateTime.Now.ToShortTimeString();
            string Date = DateTime.Now.ToShortDateString();

            MessageBox.Show("Hallo " + Username + "." + " Het is " + Time + "u. op " + Date + ".");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
        }
    }
}