using Kisiselweb.Models.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Kisiselweb.Controllers
{
    public class AdminController : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            var values=c.Anasayfas.ToList();
            return View(values);
        }

        //Buraya bir controller belirtmem gerek çünkü Anasayfaya geri dönmesi için yani bu sayfaya geri dönebilsin diye. Yani Getir sonra Güncelle.ActionResult yazcaz.
        public IActionResult AnasayfaGetir(int id)  //Buraya View ekleyeceğiz.Sayfaya yönlendirmesi için
        {
            var anasayfagetir=c.Anasayfas.Find(id);
            return View("AnasayfaGetir", anasayfagetir);
        }
        
        public ActionResult AnasayfaGüncelle(Anasayfa x)
        {
            var aag = c.Anasayfas.Find(x.id);
            aag.Name = x.Name;   // yazdığım şeyleri veritabnına eşitle
            aag.Description = x.Description;
            aag.Unvan=x.Unvan;
            aag.Profiphoto = x.Profiphoto;
            aag.Comminication = x.Comminication;
            return RedirectToAction("Index");
           
        }

    }


}

