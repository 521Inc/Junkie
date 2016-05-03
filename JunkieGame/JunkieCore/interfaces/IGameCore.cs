using JunkieCore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkieCore.interfaces {
    public interface IGameCore {
        
        Task<GameField> getFieldInfo();
    }
}
