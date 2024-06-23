using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NORTHERN_AREAOFPAKISTAN.Context;
using NORTHERN_AREAOFPAKISTAN.Models;
using System.ComponentModel.DataAnnotations;

namespace NORTHERN_AREAOFPAKISTAN.Controllers
{
    public class UserController : Controller
    {
        private readonly NorthrenArea_Context _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(NorthrenArea_Context dbContext, IHttpContextAccessor httpContext)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContext;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            _httpContextAccessor.HttpContext.Session.Remove("UserName");
            return Redirect("../Home/Index");
        }
        public IActionResult Loginpost(UserSignupreq user)
        {
            var dbuser=_dbContext.UsersData.Where(a=>a.Email==user.Email && a.Password==user.Password).FirstOrDefault();
            if (dbuser != null)
            {
                _httpContextAccessor.HttpContext.Session.SetString("UserName", dbuser.Username);
                return Redirect("../Home/Index");
            }
            
                return RedirectToAction("Login");

        }
        public IActionResult Onpostsignup(UserSignupreq user)
        {
            var dbuser = _dbContext.UsersData.Where(a => a.Email == user.Email && a.Password == user.Password).FirstOrDefault();
            if (dbuser != null)
            {
                return Redirect("SignUp");
            }
            UserSignupandLogin user1 = new UserSignupandLogin()
            {
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                ConfirmPassword = user.ConfirmPassword
            };
            _dbContext.UsersData.Add(user1);
            _dbContext.SaveChanges();
            return Redirect("../Home/Index");

        }
        public class UserSignupreq
        {
        
            public int Id { get; set; }

          
            public string? Username { get; set; }

        
            public string? Email { get; set; }

        
            public string? Password { get; set; }

         
            public string? ConfirmPassword { get; set; }

           
          
        }
    }
}
