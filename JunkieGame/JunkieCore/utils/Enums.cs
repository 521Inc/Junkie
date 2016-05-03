using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkieCore.utils {

    public enum GamePlayerEvent {
        /// <summary>
        /// Взаимодействие с ячейкой
        /// </summary>
        CellAction,
        SetName,

    }

    public enum GameEvent {
    }
    
    public enum CellState {
        /// <summary> Пустая клетка </summary>
        Empty,
        /// <summary> Земля </summary>
        Ground,
        /// <summary> Прямой перескок </summary>
        Jump,
        /// <summary> Косой перескок </summary>
        CrossJump,
        /// <summary> Дом </summary>
        Home,
        /// <summary> Фишка </summary>
        Chip
    }
}
