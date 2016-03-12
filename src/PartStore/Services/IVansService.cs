using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartStore.Services
{
    public interface IVansService
    {
        IEnumerable<Van> GetVans();
    }
}
