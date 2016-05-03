using JunkieGUI.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkieShell {
    static class Program {

        /// <summary>
        /// Длительность задержки сплешскрина
        /// </summary>
        public const int SPLASH_SLEEP = 1000;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var splashWnd = new Splash();
            splashWnd.show(SPLASH_SLEEP);
            
            Application.Run(new MainForm());
        }
    }
}
