using Microsoft.AspNetCore.Mvc;
using Ass2mvc.Context;
using Ass2mvc.Models;
namespace Ass2mvc.Controllers
{
    public class UserController : Controller
    {
        Appcontext  context=new Appcontext();
        public IActionResult Index()
        {

            var user = context.Users.ToList();

            return View(user);
        }
        public IActionResult Register()
        {
         return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var check = context.Users.FirstOrDefault(x => x.Name == user.Name && x.Password == user.Password);

         
                return RedirectToAction("Index");
            
        }


        [HttpPost]
        public IActionResult ActivateUser(int id)
        {
            var user = context.Users.FirstOrDefault(x => x.Id == id);

            if (user != null && !user.IsActive)
            {
                user.IsActive = true;
                context.Users.Remove(user); 
                context.SaveChanges();
            }
            var inactiveUsers = context.Users.Where(x => x.IsActive == false).ToList();
            return RedirectToAction("Index");
        }


    }
}
