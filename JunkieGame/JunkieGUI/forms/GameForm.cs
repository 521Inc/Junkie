using JunkieCore.interfaces;
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
    public partial class GameForm : Form {
        public GameForm() {
            InitializeComponent();
        }

        public async Task initialize(IPlayer player) {
            await gameFieldCtrl.initialize(player);
        }
    }
}
