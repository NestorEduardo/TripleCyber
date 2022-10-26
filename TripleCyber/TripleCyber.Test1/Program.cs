namespace TripleCyber.Test1
{
    internal static class Program
    {
       public static List<int> primes = new List<int>();
        public static List<int> numbers = new List<int>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}