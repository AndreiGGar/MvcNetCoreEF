using Microsoft.AspNetCore.Mvc;
using MvcNetCoreEF.Models;
using MvcNetCoreEF.Repositories;

namespace MvcNetCoreEF.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        public IActionResult IncrementoSalarial()
        {
            List<string> oficios = this.repo.GetOficios();
            ViewData["OFICIOS"] = oficios;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IncrementoSalarial (int incremento, string oficio)
        {
            ModelEmpleados model = await this.repo.IncrementarSalarios(incremento, oficio);
            List<string> oficios = this.repo.GetOficios();
            ViewData["OFICIOS"] = oficios;
            return View(model);
        }
    }
}
