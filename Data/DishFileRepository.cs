using System.Collections.Generic;
using System.IO;

namespace BlazorApp1_test.Data
{
    public class DishFileRepository
    {
        public static List<DishEntity> AllDishes()
        {
            List<DishEntity> dishEntities = new List<DishEntity>();
            var lines = File.ReadAllLines("AllMeals.txt");

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var categories = line.Split(";");
                var type = categories[0];
                var dish = categories[1];
                DishEntity dishEntity = new DishEntity(type, dish);
                dishEntities.Add(dishEntity);
            }

            return dishEntities;
        }
    }
}
