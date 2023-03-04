using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public interface ICampainService
    {
        void AddDiscount(Campaign campaign);
        void DeleteDiscount(Campaign campaign);
        void UpdateDiscount(Campaign campaign);
    }
}