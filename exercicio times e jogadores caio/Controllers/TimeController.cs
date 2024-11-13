using Microsoft.AspNetCore.Mvc;

namespace exercicio_times_e_jogadores_caio.Controllers
{
    public class TimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
