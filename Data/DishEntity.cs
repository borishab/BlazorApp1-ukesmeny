namespace BlazorApp1_test.Data
{
    public class DishEntity
    {
        public DishEntity(string type, string dish)
        {
            Type = type;
            Dish = dish;
        }

        public string Type { get; set; }

        public string Dish { get; set; }
    }
}
