using JunkieCore.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkieCore.models {
    
    public class GameCellItem {

        public CellState State { get; set; }

        public GameCellItem() {
            State = CellState.Empty;
        }

        public GameCellItem(CellState state) {
            State = state;
        }

    }
}
