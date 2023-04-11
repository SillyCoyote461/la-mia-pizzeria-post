using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using var context = new PizzaContext();
            var pizzas = context.Pizzas.ToArray();
            return View(pizzas);
        }

        public IActionResult Details(int id)
        {
            using var context = new PizzaContext();
            var pizza = context.Pizzas.SingleOrDefault(p => p.Id == id);
            return View(pizza);
        }
    }
}
