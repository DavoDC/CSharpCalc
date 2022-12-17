
// Project namespace
namespace CSharpCalc
{
    // Main program
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize app config
            ApplicationConfiguration.Initialize();

            // Initialize GUI
            Application.Run(new GUI());
        }
    }
}