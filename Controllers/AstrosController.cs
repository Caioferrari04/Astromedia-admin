using Microsoft.AspNetCore.Mvc;
using Astromedia_admin.DTO;
using Astromedia_admin.Models;

namespace Astromedia_admin.Controllers;

public class AstrosController : Controller
{
    private static List<Astro> astros = new List<Astro>{
        new Astro(1, "Terra", "É o nosso planeta", "https://www.estudokids.com.br/wp-content/uploads/2014/03/planeta-terra.jpg"),
        new Astro(2, "Marte", "Nele tem os marcianos :o", "https://static.mundoeducacao.uol.com.br/mundoeducacao/conteudo_legenda/8465a67d00eda6b73b4485921e5fac7a.jpg"),
    };
    public IActionResult Index()
    {
        return View(astros);
    }

    public IActionResult CadastrarAstro()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CadastrarAstro(AstroDTO astroDTO)
    {
        if(ModelState.IsValid)
        {
            var astro = new Astro(astroDTO.Nome, astroDTO.Curiosidades, astroDTO.Foto);
            astros.Add(astro);
            return RedirectToAction("Index");
        }
        
        return View(astroDTO);
    }
}
