using Cafe_Falaicha.Data.Models;
using Newtonsoft.Json;

namespace Cafe_Falaicha.Data.Services;

public class CoffeeService
{
    public static void InitializeAndSaveDefaultData()
    {
        List<Coffee> defaultCoffeeList = new List<Coffee>
            {
                new Coffee { Name = "Sugar", BasePrice = 0.5 },
                new Coffee { Name = "Cream", BasePrice = 0.75 },
                new Coffee { Name = "Caramel", BasePrice = 1.50 },
                new Coffee { Name = "Hazelnut", BasePrice = 1.50 },
                new Coffee { Name = "Vanilla", BasePrice = 1.50 },
                new Coffee { Name = "Mocha", BasePrice = 2.00 },
                new Coffee { Name = "Irish Cream", BasePrice = 2.00 },
                new Coffee { Name = "Peppermint", BasePrice = 2.00 },
                new Coffee { Name = "Cinnamon", BasePrice = 1.50 },
                new Coffee { Name = "Pumpkin Spice", BasePrice = 2.00 },
                new Coffee { Name = "Gingerbread", BasePrice = 2.00 },
                new Coffee { Name = "Toffee Nut", BasePrice = 2.00 }
            };
        SaveCoffeeToJson(defaultCoffeeList);
    }

    public static void SaveCoffeeToJson(List<Coffee> coffee)
    {
        string filePath = Utils.Utils.CoffeesFilePath();
        string jsonData = JsonConvert.SerializeObject(coffee, Formatting.Indented);
        File.WriteAllText(filePath, jsonData);
    }
}
