using System.Collections.Generic;
using Microsoft.AspNet.Mvc.Rendering;
using PartStore.ViewModels;

namespace PartStore.Services
{
    public interface IGarageService
    {
        void BookService(ServiceBooking serviceBooking);
        IEnumerable<Garage> GetGarages();
    }
}