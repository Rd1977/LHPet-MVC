using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente(1, "Arthur A. Ferreira", "857.032.950-41", "arthur@senai.br", "Madruga"),
                new Cliente(2, "Bill Gates", "039.618.250-09", "bill@microsoft.com", "Bug"),
                new Cliente(3, "Ada Lovelace", "800.777.920-50", "ada@ada.com", "Byron")
            };

            List<Fornecedor> fornecedores = new List<Fornecedor>()
            {
                new Fornecedor(1, "C# PET S/A", "14.182.102/0001-80", "csharp@pet.com"),
                new Fornecedor(2, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@dog.com"),
                new Fornecedor(3, "BootsPet INC", "40.810.224/0001-83", "boots@pet.com")
            };

            ViewBag.Clientes = clientes;
            ViewBag.Fornecedores = fornecedores;

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
}