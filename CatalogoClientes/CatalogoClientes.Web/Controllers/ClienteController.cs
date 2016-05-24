using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CatalogoClientes.Dominio.Repositorio;
using CatalogoClientes.Dominio.Entidades;

namespace CatalogoClientes.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        private IRepositorio<Cliente> _repositorioCliente;

        public ClienteController()
        {
            _repositorioCliente = new ClienteRepositorio(new ClienteContexto());
        }

        public ActionResult Catalogo()
        {
            return View(_repositorioCliente.GetTodos());
        }
    }
}