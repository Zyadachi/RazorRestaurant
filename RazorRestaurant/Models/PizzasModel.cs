namespace RazorRestaurant.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Ham { get; set; }
        public bool ExtraCheese { get; set; }
        public bool Mushrooms { get; set; }
        public bool Olives { get; set; }
        public bool Pepperoni { get; set; }
        public bool Jalapeno { get; set; }
        public bool Salami { get; set; }
        public bool Pineapple { get; set; }
        public float FinalPrice { get; set; }

    }
}
