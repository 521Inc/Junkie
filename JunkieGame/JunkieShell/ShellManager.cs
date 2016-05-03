using JunkieCore.interfaces;
using JunkieCore.models;
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

        public MainForm MainWndForm { get; set; }

        /// <summary>
        /// Начинает одиночную игру
        /// </summary>
        public async void beginSingleGame() {
            MainWndForm.Hide();
            var player = new ServerPlayer();
            MainWndForm.fillPlayerInfo(ref player);
            var gameForm = new GameForm();
            await gameForm.initialize(player);
            gameForm.ShowDialog();
            MainWndForm.Show();
        }

        /// <summary>
        /// Закрывает приложение
        /// </summary>
        public void exit() {
            MainWndForm.Close();
        }

    }
}
