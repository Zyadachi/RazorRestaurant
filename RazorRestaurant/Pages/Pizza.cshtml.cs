using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorRestaurant.Models;

namespace RazorRestaurant.Pages
{
    public class PizzaModel : PageModel
    {
		public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
		{
			new PizzasModel(){ImageTitle="Margerita",
				PizzaName="Margerita",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				FinalPrice=4},

			new PizzasModel(){ImageTitle="Hawaiian",
				PizzaName="Hawajska",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Pineapple=true,
				Ham=true,
				FinalPrice=5},

			new PizzasModel(){ImageTitle="MeatFeast",
				PizzaName="MeatFeast",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Ham=true,
				Pepperoni=true,
				Jalapeno=true,
				FinalPrice=8},

			new PizzasModel(){ImageTitle="Mushroom",
				PizzaName="Mushroom",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Mushrooms=true,
				Ham=true,
				FinalPrice=5},

			new PizzasModel(){ImageTitle="Pepperoni",
				PizzaName="Pepperoni",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Pepperoni=true,
				FinalPrice=5},

			new PizzasModel(){ImageTitle="Vegetarian",
				PizzaName="Vegetarian",
				BasePrice=2,
				TomatoSauce=true,
				Cheese=true,
				Olives=true,
				Mushrooms=true,
				FinalPrice=10},
		};
        public void OnGet()
        {
        }
    }
}
