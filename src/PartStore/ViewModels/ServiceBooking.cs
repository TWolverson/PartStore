using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartStore.ViewModels
{
    public class ServiceBooking
    {
        public Van Van { get; set; }

        public IEnumerable<SelectListItem> AvailableGarages { get; set; }

        public string SelectedGarage { get; set; }
    }
}
