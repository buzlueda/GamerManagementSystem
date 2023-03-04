using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public class SalesManager : ISalesService
    {
        public void Sale(Gamer gamer, Games game ,Campaign campaign)
        {
            System.Console.WriteLine("New Sale : " + gamer.userName + " just bought " + game.gameName + " for $" + game.gamePrice  );
        }
    }
}