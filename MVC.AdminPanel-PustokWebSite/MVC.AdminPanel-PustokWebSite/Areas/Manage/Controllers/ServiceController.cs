using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC.AdminPanel_PustokWebSite.DataAccessLayer;
using MVC.AdminPanel_PustokWebSite.Models;
using MVC.AdminPanel_PustokWebSite.ViewModel;

namespace MVC.AdminPanel_PustokWebSite.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ServiceController : Controller
    {

        private readonly AppDbContext _DbContext;

        public ServiceController(AppDbContext context)
        {
            _DbContext = context;
        }
        public IActionResult Index()
        {
            List<Service> allServices = _DbContext.Services.ToList();
            return View(allServices);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Service service)
        {

            if (!ModelState.IsValid) return View();

            _DbContext.Services.Add(service);
            _DbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Service service = _DbContext.Services.FirstOrDefault(x => x.Id == id);
            return View(service);
        }

        [HttpPost]
        public IActionResult Delete(Service service)
        {
            Service existService1 = _DbContext.Services.FirstOrDefault(x => x.Id == service.Id);
            if (existService1 == null)
            {
                return NotFound();
            }
            _DbContext.Services.Remove(existService1);
            _DbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Service service = _DbContext.Services.FirstOrDefault(x => x.Id == id);
            return View(service);
        }

        [HttpPost]
        public IActionResult Update(Service service)
        {
            if (!ModelState.IsValid) return View();
            Service existService1 = _DbContext.Services.FirstOrDefault(x => x.Id == service.Id);

            existService1.Title = service.Title;
            existService1.Desc = service.Desc;
            existService1.Icon = service.Icon;

            _DbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
