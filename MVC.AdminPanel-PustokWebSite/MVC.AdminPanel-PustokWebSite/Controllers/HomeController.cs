using Microsoft.AspNetCore.Mvc;
using MVC.AdminPanel_PustokWebSite.DataAccessLayer;
using MVC.AdminPanel_PustokWebSite.Models;
using MVC.AdminPanel_PustokWebSite.ViewModel;

namespace MVC.AdminPanel_PustokWebSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _DbContext;

        public HomeController(AppDbContext context)
        {
            _DbContext = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _DbContext.Services.ToList();
            return View(services);
        }
    }
}
