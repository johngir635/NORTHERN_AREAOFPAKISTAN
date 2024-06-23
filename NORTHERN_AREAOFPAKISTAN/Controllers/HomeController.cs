using Microsoft.AspNetCore.Mvc;
using NORTHERN_AREAOFPAKISTAN.Context;
using NORTHERN_AREAOFPAKISTAN.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace NORTHERN_AREAOFPAKISTAN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthrenArea_Context _dbContext;
        public HomeController(ILogger<HomeController> logger,NorthrenArea_Context dbcontext)
        {
            _dbContext = dbcontext;
            _logger = logger;
        }
        public IActionResult saveMessage(ContactFormModelreq contactForm)
        {
            ContactFormModel formdata = new ContactFormModel()
            {
                Name=contactForm.Name,
                Email=contactForm.Email,
                Country=contactForm.Country,
                Remarks=contactForm.Remarks

            };

            _dbContext.ContactFormModelData.Add(formdata);
            _dbContext.SaveChanges();
            return Redirect("index");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public class ContactFormModelreq
        {

          
            public int Id { get; set; }

            public string? Name { get; set; }

          
            public string? Email { get; set; }

     
            public string? Country { get; set; }

  
            public string? Remarks { get; set; }

        }
    }
}
