using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zasilacz_warsztatowy
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Zasilacz_warsztatowy());
            //Zasilacz_warsztatowy.Form1.SetDesktopLocation((Screen.PrimaryScreen.Bounds.Width - Zasilacz_warsztatowy.Form1.Size.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - Zasilacz_warsztatowy.Form1.Size.Height) / 2);
        }
    }
}
