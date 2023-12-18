using Kisiselweb.Models.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Kisiselweb.Controllers
{
    public class AnasayfaController : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            var deger=c.Anasayfas.ToList();
            return View(deger);
        }

        public PartialViewResult İkon()
        {
            var values =c.Icons.ToList();
            return PartialView(values);
        }
    }
}
