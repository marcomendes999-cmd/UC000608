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
                Name = "António Miranda"
            };

            User user2 = new User
            {
                Id = 2,
                Name = "Maria Silva"
            };

            User user3 = new User
            {
                Id = 3,
                Name = "João Santos"
            };

            User user4 = new User
            {
                Id = 4,
                Name = "Ana Costa"
            };

            User user5 = new User
            {
                Id = 5,
                Name = "Pedro Ferreira"
            };

            User user6 = new User
            {
                Id = 6,
                Name = "Sofia Almeida"
            };

            User user7 = new User
            {
                Id = 7,
                Name = "Carlos Rodrigues"
            };

            User user8 = new User
            {
                Id = 8,
                Name = "Beatriz Martins"
            };

            User user9 = new User
            {
                Id = 9,
                Name = "Ricardo Gomes"
            };

            User user10 = new User
            {
                Id = 10,
                Name = "Inês Carvalho"
            };

            listausers.Add(user1);
            listausers.Add(user2);
            listausers.Add(user3);
            listausers.Add(user4);
            listausers.Add(user5);
            listausers.Add(user6);
            listausers.Add(user7);
            listausers.Add(user8);
            listausers.Add(user9);
            listausers.Add(user10);

            return View(listausers);
        }
    }
}