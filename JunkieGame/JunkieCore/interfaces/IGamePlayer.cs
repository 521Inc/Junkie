using JunkieCore.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkieCore.interfaces {

    /// <summary>
    /// Связь ядра и сущности Player
    /// </summary>
    public interface IGamePlayer {

        void initialize(IGameCore core);
    }
}
