using JunkieCore.interfaces;
using JunkieGUI.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkieGUI.forms {
    public partial class MainForm : Form {

        private IShellManager _shellManager;

        public MainForm() {
            InitializeComponent();
        }

        public void init(IShellManager shellManager) {
            _shellManager = shellManager;
            mainMenuCtrl.Play += onPlay;
            mainMenuCtrl.Exit += onExit;
        }

        void onExit(object sender, EventArgs e) {
            _shellManager.exit();
        }

        void onPlay(object sender, EventArgs e) {
            _shellManager.beginSingleGame();
        }

        public void fillPlayerInfo<TPlayer>(ref TPlayer player)
            where TPlayer : IPlayer {

        }
    }
}
