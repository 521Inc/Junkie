using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunkieCore.interfaces;
using JunkieCore.models;
using JunkieCore.utils;

namespace JunkieGame.controllers {
    public class MainFormController {

        public event EventHandler GameFieldCreated;

        public IPlayer Self { get; set; }

        public GameField GameField { get; set; }

        public MainFormController(IPlayer player) {
            Self = player;
            player.setName("Олеша");
        }
        
        public async Task initialize() {
            GameField = await Self.getFieldInfo();
            invokeEvent(GameFieldCreated);
        }
        
        private void invokeEvent(EventHandler evt) {
            if (evt != null) {
                evt(this, new EventArgs());
            }
        }

        private void onGameAction(object sender, GameActionEventArgs e) {
            
        }

        private void onGameField(object data) {

        }

        public void playerAction(int x, int y) {
            Self.reportStateChanged(x, y);
        }

    }
}
