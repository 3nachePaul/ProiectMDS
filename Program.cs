

namespace ProiectMDS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1(); 
            form1.Load += (sender, e) => form1.showcars();
            //Application.Run(form1); ;
            //Application.Run(MapForm());
            Application.Run(new Login());
     

        }
    }
}