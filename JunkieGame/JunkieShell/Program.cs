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
            new Splash().show(SPLASH_SLEEP);
            var mainWnd = new MainForm();
            var shellManager = new ShellManager();
            shellManager.MainWndForm = mainWnd;
            mainWnd.init(shellManager);
            Application.Run(mainWnd);
        }
    }
}
