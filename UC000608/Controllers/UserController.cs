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
                Nome = "António Miranda"
            };

            User user2 = new User
            {
                Id = 2,
                Nome = "Maria Silva"
            };

            User user3 = new User
            {
                Id = 3,
                Nome = "João Santos"
            };

            User user4 = new User
            {
                Id = 4,
                Nome = "Ana Costa"
            };

            User user5 = new User
            {
                Id = 5,
                Nome = "Pedro Ferreira"
            };

            User user6 = new User
            {
                Id = 6,
                Nome = "Sofia Almeida"
            };

            User user7 = new User
            {
                Id = 7,
                Nome = "Carlos Rodrigues"
            };

            User user8 = new User
            {
                Id = 8,
                Nome = "Beatriz Martins"
            };

            User user9 = new User
            {
                Id = 9,
                Nome = "Ricardo Gomes"
            };

            User user10 = new User
            {
                Id = 10,
                Nome = "Inês Carvalho"
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