using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class UsersController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            var user = new UserViewModel
            {
                Name = "Claudio D. Operti",
                Email = "claudio.operti@cablasociados.com",
                Phone = "353-5084611"
            };

            return View(user);
        }
    }
}
