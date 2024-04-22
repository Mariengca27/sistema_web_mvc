using Microsoft.AspNetCore.Mvc;
using VendasSistemaMvc.Models;

namespace VendasSistemaMvc.Controllers
{
    public class DepartmentsController : Controller
    {

        public IActionResult Index()
        {
           
            List<Department> list = new List<Department>();
           list.Add(new Department { Id = 1, Name = "Eletronics", Description="Departamento voltado para a manutenção de equipamentos eletrônicos" });
            list.Add(new Department { Id = 2, Name = "Moda", Description="Departamento voltado para a venda de roupas" });
            list.Add(new Department { Id = 3, Name = "Alimentos", Description="Departamento voltado para a venda de alimentos" });

            return View(list);
        }


      
    }
}
