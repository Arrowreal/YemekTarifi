using Microsoft.AspNetCore.Mvc;

namespace yemektarifi.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Anasayfa()
        {
            return View();
        }
    }
}
