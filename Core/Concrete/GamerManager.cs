using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Abstract;

namespace Core
{
    public class GamerManager : IGamerService
    {
        IGamerValidationService? _gamerValidationService;

        public GamerManager(IGamerValidationService? gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Delete(Gamer gamer)
        {
            System.Console.WriteLine("User deleted : " + gamer.userName);
        }

        public void Register(Gamer gamer)
        {
            if (_gamerValidationService.Validate(gamer) == true)
            {
                System.Console.WriteLine("Validation successful! User added : " + gamer.userName);
            }
            else
            {
                System.Console.WriteLine("Validation failed!");
            }

        }

        public void Update(Gamer gamer)
        {
            System.Console.WriteLine("User updated");
        }
    }
}