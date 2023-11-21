using Microsoft.AspNetCore.Mvc;
using MVC.AdminPanel_PustokWebSite.DataAccessLayer;
using MVC.AdminPanel_PustokWebSite.Models;
using MVC.AdminPanel_PustokWebSite.ViewModel;

namespace MVC.AdminPanel_PustokWebSite.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }


    
    }
}
