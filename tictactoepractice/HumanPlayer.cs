using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoepractice
{
    public class HumanPlayer: IPlayer
    {
        public PlayerSymbol player { get; } 

        public HumanPlayer(PlayerSymbol symbol)
        {
            this.player = symbol;
        }

        public void MakeMove()
        {

        }


    }
}
