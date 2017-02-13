using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson6
{
    static class Program
    {
        // decalred public static Form - Application Grlobal
        public static SplashForm splashForm;

        // declared public static Form - Calculator Form
        // public static CalulatorForm calculateForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialinze SplashForm and CalculatorForm
            splashForm = new SplashForm();
            //calculateForm = new CalulatorForm();
            Application.Run(splashForm);
        }
    }
}
