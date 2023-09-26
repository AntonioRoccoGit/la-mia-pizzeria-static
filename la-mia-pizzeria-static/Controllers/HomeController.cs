using la_mia_pizzeria_static.Classes;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<PizzaItem> pizzas = new List<PizzaItem>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            GeneratePizza();
            return View(pizzas);
        }
        public IActionResult UserIndex()
        {
            GeneratePizza();
            return View(pizzas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //METHODS
        private void GeneratePizza()
        {
            pizzas.Add(new PizzaItem("Margherita", "La regina delle pizze", "https://media.istockphoto.com/id/1414575281/it/foto/una-deliziosa-e-gustosa-pizza-italiana-margherita-con-pomodori-e-mozzarella-di-bufala.jpg?s=2048x2048&w=is&k=20&c=ZMElJhh1E44g5NpXCKPnSkDPyoUAGAy_DDdO7eECBLU=", 6.50));
            pizzas.Add(new PizzaItem("Diavola", "Scottati le papille gustative!", "https://www.maestrella.com/wp-content/uploads/2021/09/PIZZA-DIAVOLAv2-1024x770-1.jpg", 7.50));
            pizzas.Add(new PizzaItem("Capricciosa", "Non fare i capricci, scegli me!", "https://t3.ftcdn.net/jpg/02/79/84/46/360_F_279844600_ze9LMhRrEvn1LgGmxiinW8oPnlEdejNT.jpg", 8.00));
            pizzas.Add(new PizzaItem("Quattro Stagioni", "Quattro sono meglio di una", "https://c8.alamy.com/compit/2m3n61k/deliziosa-pizza-italiana-croccante-quattro-stagioni-con-funghi-carciofi-prosciutto-e-olive-primo-piano-sul-tavolo-vista-dall-alto-orizzontale-da-abov-2m3n61k.jpg", 8.50));
            pizzas.Add(new PizzaItem("Bimbo Felice", "Classica wurstel e patatine", "https://i0.wp.com/www.piccolericette.net/piccolericette/wp-content/uploads/2017/11/3244_Pizza.jpg?resize=895%2C616&ssl=1", 8.50));
            pizzas.Add(new PizzaItem("Tonn e cipoll", "Pio e Amedeo approved", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCaOYZiA_l23HAR079dhzGv2M5gHjKUexkPw&usqp=CAU", 6.50));
        }
    }
}