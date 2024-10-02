using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocoSetup
{
    static class Program
    {
        /// <summary>
        /// The main entry point fo
        /// </summary>
        /// r the application.
        public static Form1 Form;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form = new Form1();

            Application.Run(new Form1());
        }
    }
}
