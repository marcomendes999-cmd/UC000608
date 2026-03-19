using Microsoft.AspNetCore.Mvc;
using UC000608.Models;

namespace UC000608.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<User> listausers = new List<User>();

            User user1 = new User
            { 
                Id = 1,
                Name = "Maria Miranda Paula"
            };

            listausers.Add(user1);

            return View(listausers);
        }
    }
}
