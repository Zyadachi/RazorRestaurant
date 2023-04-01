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
        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 2;
			if (Pizza.Cheese) PizzaPrice += 2;
			if (Pizza.Ham) PizzaPrice += 3;
			if (Pizza.Mushrooms) PizzaPrice += 2;
			if (Pizza.Olives) PizzaPrice += 2;
			if (Pizza.Jalapeno) PizzaPrice += 3;
			if (Pizza.Pepperoni) PizzaPrice += 3;
			if (Pizza.Pineapple) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});

        }
    }
}
