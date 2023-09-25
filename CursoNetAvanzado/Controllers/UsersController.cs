using CursoNetAvanzado.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoNetAvanzado.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        [HttpGet]
        [Route("getuser")]
        public IActionResult Get()
        {
            var user = new UserModel()
            {
                Nombre = "Damián",
                Apellido = "Aimar",
                Documento = "37257944"
            };

            return View("Index", user);
        }

		[HttpGet]
		[Route("create")]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
        [Route("create")]
        public IActionResult Create(UserModel model)
        {
			return RedirectToAction("Index");
        }

    }
}
