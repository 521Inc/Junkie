using JunkieCore.models;
using JunkieCore.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkieCore.interfaces {

    /// <summary>
    /// Связь пользователя и сущности Player:
    /// ServerPlayer - передача напрямую к ядру, расположенному здесь же;
    /// BotPlayer - передача боту;
    /// ClientPlayer - передача по Lan.
    /// </summary>
    public interface IPlayer {

        /// <summary>
        /// Сообщает о том, что игрок совершил действие с клеткой в координатах (x, y)
        /// </summary>
        void reportStateChanged(int x, int y);

        void setName(string p);

        Task<GameField> getFieldInfo();
    };

}
