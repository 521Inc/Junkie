using JunkieGUI.forms;
using JunkieGUI.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkieShell {
    /// <summary>
    /// Управление внутренними процессами
    /// </summary>
    public class ShellManager : IShellManager {

        public Form MainWndForm { get; set; }

        /// <summary>
        /// Начинает одиночную игру
        /// </summary>
        public void beginSingleGame() {

        }

        /// <summary>
        /// Закрывает приложение
        /// </summary>
        public void exit() {
            MainWndForm.Close();
        }

    }
}
