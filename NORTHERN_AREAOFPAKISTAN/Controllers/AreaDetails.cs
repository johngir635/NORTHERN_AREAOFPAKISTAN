using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace NORTHERN_AREAOFPAKISTAN.Controllers
{
    public class AreaDetails : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Borogil()
        {
            return View();
        }  
        public IActionResult Shandur()
        {
            return View();
        }
        public IActionResult ExploreMore()
        {
            return View();
        }
    }
}
