using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartStore.Services
{
    public class StubVansService : IVansService
    {
        public IEnumerable<Van> GetVans()
        {
            yield return new Van { Make = "Volkswagen", Model = "Caddy", Registration = "AB56 AAA", LastServiced = DateTime.Now.AddMonths(-3), LastWashed = DateTime.Now.AddDays(-8) };
            yield return new Van { Make = "Mercedes", Model = "Sprinter", Registration = "AB56 BBB", LastServiced = DateTime.Now.AddMonths(-3), LastWashed = DateTime.Now.AddDays(-8) };
        }
    }
}
