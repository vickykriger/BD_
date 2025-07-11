using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaseDeDatos.Models;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Dapper;

namespace BaseDeDatos.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Login(string email, string contraseña)
    {
        string palabra = "Index";
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
        {
            ViewBag.error = "Por favor, complete todos los campos.";
            palabra = "Index";
        }
        Integrante integranteBien = BD.validarIntegrante(email, contraseña);
        if(integranteBien == null)
        {
            ViewBag.error = "Error en el ingreso";
            palabra = "Index";
        } else
        {
            ViewBag.integrante = integranteBien;
            palabra = "Perfil";
        }
        return View (palabra);
    }
}
