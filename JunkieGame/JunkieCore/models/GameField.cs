using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkieCore.models {
    public class GameField {

        public GameCellItem[,] FieldInfo { get; set; }

        public GameField(int width, int height) {
            FieldInfo = new GameCellItem[width, height];
        }

    }
}
