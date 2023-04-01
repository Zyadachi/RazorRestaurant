using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorRestaurant.Models;

namespace RazorRestaurant.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult onPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
			if (Pizza.ExtraCheese) PizzaPrice += 1;
			if (Pizza.Ham) PizzaPrice += 1;
			if (Pizza.Mushrooms) PizzaPrice += 1;
			if (Pizza.Olives) PizzaPrice += 1;
			if (Pizza.Jalapeno) PizzaPrice += 1;
			if (Pizza.Pepperoni) PizzaPrice += 1;
			if (Pizza.Pineapple) PizzaPrice += 1;
            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});

        }
    }
}
