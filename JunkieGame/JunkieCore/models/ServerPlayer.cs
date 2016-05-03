using JunkieCore.interfaces;
using JunkieCore.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkieCore.models {
    public class ServerPlayer : IPlayer, IGamePlayer {

        #region Свойства

        /// <summary>
        /// Игровое ядро - движок
        /// </summary>
        public IGameCore Core { get; set; }

        public string PlayerName { get; set; }

        #endregion

        #region События

        public event EventHandler<PlayerActionEventArgs> PlayerAction;

        private void invokePlayerAction(GamePlayerEvent evt, params object[] elems) {
            var handler = PlayerAction;
            if (handler != null) {
                handler(this, new PlayerActionEventArgs {
                    EventType = evt,
                    Data = elems
                });
            }
        }

        #endregion

        public void reportStateChanged(int x, int y) {
            invokePlayerAction(GamePlayerEvent.CellAction, x, y);
        }
        
        public void setName(string name) {
            PlayerName = name;
            invokePlayerAction(GamePlayerEvent.SetName, name);
        }

        public async Task<GameField> getFieldInfo() {
            if (Core != null) {
                return await Core.getFieldInfo();
            }
            return null;
        }

        public void initialize(IGameCore core) {
            Core = core;
        }
    }
}
