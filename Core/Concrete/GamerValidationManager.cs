using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Abstract;

namespace Core.Concrete
{
    public class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.identityNum == 12345 && gamer.fullName == "Eda Buzlu" && gamer.birthYear == 1999)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}