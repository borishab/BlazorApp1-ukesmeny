using System;
using System.Linq;
using System.Threading.Tasks;
using static BlazorApp1_test.Pages.Counter;

namespace BlazorApp1_test.Data
{

    /*
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }

    */


    public class DishService
    {
       
        public Task<WeatherForecast[]> GetDishAsync(DateTime startDate)
        {
            DishClass meals = new DishClass();
            var all_meals = meals.AllDishes();

            Console.Write(all_meals);

            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 7).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = all_meals[rng.Next(all_meals.Count)].GetDishName()
            }).ToArray()) ;
        }
    }
}
