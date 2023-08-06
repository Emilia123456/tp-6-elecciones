using System.ComponentModel;
using System.IO.Compression;
using System.Reflection.PortableExecutable;
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
        ViewBag.ListarPartidos = BD.ListarPartidos();
        return View();
    }

    public IActionResult VerDetallePartido(int idPartido){
        
        ViewBag.InfoPartido = BD.VerInfoPartido(idPartido);
        ViewBag.candidatos = BD.ListarCandidatos(idPartido);
        return View();
    }

    public IActionResult VerDetalleCandidato(int idCandidato){
        
        ViewBag.InfoCandidato = BD.VerInfoCandidato(idCandidato);
        return View();
    }

    public IActionResult AgregarCandidato(){
        ViewBag.ListarPartidos = BD.ListarPartidos();
        return View();
    }

    [HttpPost]
    public IActionResult GuardarCandidato(int idPartido, string Apellido, string Nombre, DateTime FechaNacimiento, string Foto, string Postulacion)
    {
        BD.AgregarCandidato(new Candidato(idPartido, Apellido, Nombre, FechaNacimiento, Foto, Postulacion));
        return RedirectToAction("Index", "Home");
    }


    public IActionResult EliminarCandidato(int idCandidato /*,int idPartido*/)
    {
        //a chequear
        BD.ElmiminarCandidato(idCandidato);
        return View("VerDetallePartido");
    }

    public IActionResult Elecciones(){
        //en teoria es te dirige a una pagina que te cuenta lo que se vota este año, que yo creo que es el index, a chequear
        return View();
    }

    public ActionResult Creditos(){
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
