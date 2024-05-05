using FinalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalMVC.Controllers
{
    public class Login_RegisterController : Controller
    {
        private readonly ModelContext context;
        private ModelContext _context;

        public Login_RegisterController(ModelContext context)
        {
            _context = context;
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> LogIn(UserLogin userLogin)
        {
            var User = await _context.UserLogins.Where(x => x.UserName == userLogin.UserName && x.Password == userLogin.Password).SingleOrDefaultAsync();


            if (User != null)
            {

                switch (User.RoleId) {


                    case 1:
                       
                        return RedirectToAction("Index","Admin");
                       
                    case 2:
                        return RedirectToAction("About", "Home");

                    case 3:
                        
                        return RedirectToAction("Index", "Home");


                }




            }




            return View();
        }










        [HttpPost]

        public IActionResult Register(Customer customer, string userName, string Password)
        {


            if (ModelState.IsValid)
            {

                _context.Add(customer);
                _context.SaveChanges();

                UserLogin userLogin = new UserLogin();
                userLogin.UserName = userName;
                userLogin.Password = Password;
                userLogin.CustomerId = customer.Id;
                userLogin.RoleId = 3;
                _context.Add(userLogin);
                _context.SaveChanges();

            }

            
                
            
           


            return View();
        }

        


    }
}
