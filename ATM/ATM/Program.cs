using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Modelo;

namespace ATM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vista.LogIn());
        }
    }
}
