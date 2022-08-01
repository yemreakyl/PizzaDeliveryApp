using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDeliveryApp.Models;

namespace PizzaDeliveryApp.Pages.Form
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza{ get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost() //Bu method kullanýcý seçimlerini yaptýktan sonra submit butonuna bastýðýnda çaðýrýlacak
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 2;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 2;
            if (Pizza.Tuna) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 5;
            if (Pizza.Ham) PizzaPrice += 3;
            if (Pizza.Beef) PizzaPrice += 3;
            return RedirectToPage("/Checkout/Checkout",new {Pizza.PizzaName,PizzaPrice });
        }
    }
}
