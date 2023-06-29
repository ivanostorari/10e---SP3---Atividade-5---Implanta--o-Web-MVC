using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        // instacias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "Willian Henry Gates III", "039.618.250-09", "bill@microsoft.com", "bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "800.777.920-50", "ADA@ADA.language.com", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hpper", "911.703.988-00", "grace.hopper@cobol.com", "Loboc");

        // lista clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;  

        // instancias do tipo fornecedor e atribui os fornecedores
        Fornecedor Fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.or");
        Fornecedor Fornecedor2 = new Fornecedor(02, "Ctrl Ant Dog", "15.836.698/0000-57", "ctrl@alt.dog.br");
        Fornecedor Fornecedor3 = new Fornecedor(03, "BootsPet INC", "40.870.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor Fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@otiktokdogs.uk");
        Fornecedor Fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bgg.us");

        // lista fornecedores   
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(Fornecedor1);
        listaFornecedores.Add(Fornecedor2);
        listaFornecedores.Add(Fornecedor3);
        listaFornecedores.Add(Fornecedor4);
        listaFornecedores.Add(Fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

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
