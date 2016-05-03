using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkieGUI.interfaces {
    /// <summary>
    /// Отвечает за взаимодействие оболочки и интерфейса
    /// </summary>
    public interface IShellManager {
        
        /// <summary>
        /// Закрывает приложение
        /// </summary>
        void exit();
        
        /// <summary>
        /// Начинает одиночную игру
        /// </summary>
        void beginSingleGame();
    }
}
