using JunkieGUI.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkieGUI.forms {
    public partial class Splash : Form {

        public Splash() {
            InitializeComponent();
            Visible = false;
        }

        /// <summary>
        /// Синхронно показывает сплешскрин
        /// </summary>
        public void show(int sleepMs) {
            Show();
            Update();
            Thread.Sleep(sleepMs);
            Hide();
        }
    }
}
