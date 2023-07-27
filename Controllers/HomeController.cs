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
        Cliente cliente1 = new Cliente(01, "Dorival Caymmi", "857.032.950-41", "dorival.caymmi@gmail.com", "Jolly");
        Cliente cliente2 = new Cliente(02, "Vinícius de Moraes", "039.618.250-09", "vinni@gmail.com", "Sonic");
        Cliente cliente3 = new Cliente(03, "João Gilberto", "800.777.920-50", "joaogiba@gmail.com", "Picachu");
        Cliente cliente4 = new Cliente(04, "Tom Jobim", "933.622.400-03", "tonho@gmail", "Raychu");
        Cliente cliente5 = new Cliente(05, "Marcos Valle", "911.702.988-00", "marquinhovall@gmail.com", "Precioso");

        List<Cliente> listaClientes = new List<Cliente>();

        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "PET DA SILVA Ltda","14.182.102/0001-80", "petdasilva@dasilva.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Bichinhos Fofos", "15.836.698/0001-57", "bifo@bifo.com.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Só-Riso-Canino", "40.810.224/0001-83", "soris@sorin.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tati-Mitate-Tango", "87.945.350/0001-09", "tatimitatetango@tati.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Batatinha", "18.760.614/0001-37", "batatinha@batatinha.com.br");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();

        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
        
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
