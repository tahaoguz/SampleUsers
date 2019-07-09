using SampleUsers.Models;
using System.Collections.Generic;
using System.Web.Mvc;


namespace SampleUsers.Controllers
{
    public class UsersController : Controller
    {
        private static List<User> _users;

        public UsersController()
        {
            _users = new List<User>();
            _users.Add(new User
            {
                Id = 1,
                Name = "Mahmoud",
                Surname = "Slama",
                IsChecked = false
            });

            _users.Add(new User
            {
                Id = 2,
                Name = "Oguz",
                Surname = "Taha",
                IsChecked = true
            });
        }

        // GET: Users
        public ActionResult Index()
        {
            return View(_users);
        }

        [HttpPost]
        public ActionResult AddNewUser(User user)
        {

            int id = _users[_users.Count - 1].Id + 1;

            Models.User newUser = new User()
            {
                Id = id,
                Name = user.Name,
                Surname = user.Surname,
                IsChecked = user.IsChecked
            };

            _users.Add(newUser);

            return View("Index", _users);
        }
    }
}