namespace la_mia_pizzeria_static.Classes
{
    public class PizzaItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Thumbnail { get; private set; }
        public double Price { get; private set; }

        public PizzaItem(string name, string description, string thumbnail, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Thumbnail = thumbnail;
            this.Price = price;
        }


        public string GetStringPrice()
        {
            return this.Price.ToString("0.00");
        }
    }
}
