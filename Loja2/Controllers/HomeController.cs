using Loja2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        // Aqui você pode criar instâncias de clientes, vendedores, produtos e marcas
        // e passá-los para a view

        var cliente = new Cliente { Id = 1, Nome = "Cliente 1", Vendedor = new Vendedor { Id = 1, Nome = "Vendedor 1" } };
        var produto = new Produto { Id = 1, Nome = "Produto 1", Preco = 10.0m, Marca = new Marca { Id = 1, Nome = "Marca 1" } };

        ViewBag.Cliente = cliente;
        ViewBag.Produto = produto;

        return View();
    }
}
