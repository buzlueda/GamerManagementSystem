using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public interface IGamerValidationService
    {
        bool Validate(Gamer gamer);
    }
}