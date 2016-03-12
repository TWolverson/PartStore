using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PartStore.ViewModels;

namespace PartStore.Services
{
    public class StubGaragesService : IGarageService
    {
        public void BookService(ServiceBooking serviceBooking)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Garage> GetGarages()
        {
            yield return new Garage { Name = "Bodge-It Ltd.", Id = "1" };
            yield return new Garage { Name = "Flash Motors, Etc.", Id = "2" };
        }
    }
}
