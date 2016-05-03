using JunkieCore.interfaces;
using JunkieCore.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkieCore.models {
    public class BaseGameCore {

        protected GameField _fieldInfo;

        protected List<IGamePlayer> _players = new List<IGamePlayer>();

        protected int _width = 4;

        protected int _height = 4;

        public async Task initialize() {
            
            _fieldInfo = new GameField(_width, _height);
            for(int i=0;i<_width;i++) {
                for(int j=0;j<_height;j++) {
                    _fieldInfo.FieldInfo[i, j] = onCellCreate(i, j);
                }
            }
        }

        protected virtual GameCellItem onCellCreate(int i, int j) {
            return new GameCellItem(CellState.Ground);
        }



        public async Task<GameField> getFieldInfo() {
            if (_fieldInfo == null) {
                await initialize();
            }
            return _fieldInfo;
        }

        public event EventHandler<GameActionEventArgs> GameAction;
    }
}
