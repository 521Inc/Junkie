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
    public partial class Splash : Form, ISplash {

        /// <summary>
        /// Длительность задержки сплешскрина
        /// </summary>
        public const int SPLASH_SLEEP = 3000;

        public Splash() {
            InitializeComponent();
            Visible = false;
        }

        protected override async void OnLoad(EventArgs e) {
            base.OnLoad(e);
            var gameForm = new GameForm();
            //var timeLoadBegin = DateTime.Now;
            await gameForm.initialize();
            //var timeLoadAwaitMs = (DateTime.Now - timeLoadBegin).TotalMilliseconds;
            //timeLoadAwaitMs = SPLASH_SLEEP - timeLoadAwaitMs;
            //if (timeLoadAwaitMs > 0) {
            //}
            Visible = false;
            gameForm.Show();
        }

        public async Task show() {
            Show();
            await Task.Factory.StartNew(() => Thread.Sleep(SPLASH_SLEEP));
            Application.DoEvents();
            Hide();
        }
    }
}
