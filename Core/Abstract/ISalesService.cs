using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public interface ISalesService
    {
        void Sale(Gamer gamer, Games games , Campaign campaign);
    }
}