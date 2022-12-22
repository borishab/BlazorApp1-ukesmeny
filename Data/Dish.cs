using System;

namespace BlazorApp1_test.Data
{
    public class Dish
    {
        public Dish(DateTime date, string summary)
        {
            Date = date;
            Summary = summary;
        }

        public DateTime Date { get; set; }

        public string Summary { get; set; }
    }
}
