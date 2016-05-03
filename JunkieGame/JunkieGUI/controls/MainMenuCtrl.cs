using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkieGUI.controls {
    public partial class MainMenuCtrl : UserControl {

        public event EventHandler Play;

        public event EventHandler Exit;

        public MainMenuCtrl() {
            InitializeComponent();
        }

        private void onBtnPlay(object sender, EventArgs e) {
            invokeEvent(Play);
        }

        private void onBtnExit(object sender, EventArgs e) {
            invokeEvent(Exit);
        }

        private void invokeEvent(EventHandler handler) {
            if (handler != null) {
                handler(this, new EventArgs());
            }
        }

    }
}
