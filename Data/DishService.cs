using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1_test.Data
{
    public class DishService
    {
        public Task<Dish[]> GetDishesAsync(DateTime startDate)
        {
            var dishEntities = DishFileRepository.AllDishes();
            var random = new Random();
            var plannedDishes = new List<DishEntity>();
            var result = new List<Dish>();

            for (var i = 1; i <= 7; i++)
            {
                var dishEntity = dishEntities[random.Next(dishEntities.Count)];
                    
                while (plannedDishes.Contains(dishEntity) || (i > 1 && plannedDishes[i - 2].Type == dishEntity.Type))
                {
                    dishEntity = dishEntities[random.Next(dishEntities.Count)];
                }

                plannedDishes.Add(dishEntity);
                result.Add(ToDish(startDate.AddDays(i), dishEntity));
            }

            return Task.FromResult(result.ToArray());
        }

        public Dish ToDish(DateTime date, DishEntity dishEntity)
        {
            return new Dish(date, dishEntity.Dish);
        }
    }
}
