

namespace ProiectMDS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1(); // Create an instance of Form1
            form1.Load += (sender, e) => form1.showcars(); // Call showcars() when the form is loaded
            Application.Run(form1); // Run t;
        }
    }
}