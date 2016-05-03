using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkieCore.utils {

    public class GameActionEventArgs : EventArgs {

        public GameEvent EventType { get; set; }

        public object Data { get; set; }
    }

    public class PlayerActionEventArgs : EventArgs {

        public GamePlayerEvent EventType { get; set; }

        public object Data { get; set; }

    }

}
