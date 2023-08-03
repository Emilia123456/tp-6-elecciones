using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp_6_elecciones.Models;

namespace tp_6_elecciones.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        int pipa=3;
        ViewBag.numero = pipa;
        ViewBag.ListarPartidos=BD.ListarPartidos();
        return View();
    }

    public IActionResult VerDetallePartido(int verPartido, int verCandidato){
        
        ViewBag.InfoPartido=BD.VerInfoPartido(verPartido);
        ViewBag.candidatos = BD.ListarCandidatos(verCandidato);
        return View();
    }

    IActionResult VerDetalleCandidato(int idCandidato){
        //aca ponemos el formulario para cargar un candidato, que ahora no se cual es
        return View();
    }

    IActionResult creditos(){
        return View();
    }



    [HttpPost]IActionResult GuardarCandidato(Candidato can)
    {
        //a chequear
        BD.AgregarCandidato(can);
        return View("VerDetallePartido");
    }

    IActionResult EliminarCandidato(int idCandidato /*,int idPartido*/)
    {
        //a chequear
        BD.ElmiminarCandidato(idCandidato);
        return View("VerDetallePartido");
    }

    IActionResult Elecciones(){
        //en teoria es te dirige a una pagina que te cuenta lo que se vota este año, que yo creo que es el index, a chequear
        return View();
    }

    ActionResult Creditos(){
        //cosa de Pipa
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
