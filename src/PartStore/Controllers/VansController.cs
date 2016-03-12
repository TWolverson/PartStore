using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PartStore.Services;
using PartStore.ViewModels;
using Microsoft.AspNet.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PartStore.Controllers
{
    public class VansController : Controller
    {
        private IVansService vansService;

        private IGarageService garageService;

        public VansController(IVansService vansService, IGarageService garageService)
        {
            this.vansService = vansService;
            this.garageService = garageService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new VansViewModel { Vans = vansService.GetVans() });
        }

        [HttpPost]
        public IActionResult BookService(ServiceBooking serviceBooking)
        {
            garageService.BookService(serviceBooking);
            return RedirectToAction("Details", new { registration = serviceBooking.Van.Registration });
        }

        public IActionResult Details(string registration)
        {
            var viewModel = vansService.GetVans().SingleOrDefault(v => v.Registration == registration);
            return View(viewModel);
        }

        public IActionResult BookServiceForm(string registration)
        {
            var van = vansService.GetVans().SingleOrDefault(v => v.Registration == registration);
            var viewModel = new ServiceBooking()
            {
                Van = van,
                AvailableGarages = garageService.GetGarages().Select(g => new SelectListItem { Text = g.Name, Value = g.Id })
            };
            return View(viewModel);
        }
    }
}
