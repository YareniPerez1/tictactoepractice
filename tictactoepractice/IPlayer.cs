using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoepractice
{

    public enum PlayerSymbol
    {
        X, O

    }
    public interface IPlayer
    {
        PlayerSymbol player { get; }

    }

}
