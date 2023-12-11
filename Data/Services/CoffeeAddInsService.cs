using Cafe_Falaicha.Data.Models;
using Newtonsoft.Json;

namespace Cafe_Falaicha.Data.Services;

public class CoffeeAddInsService
{
    public static void SaveCoffeeAddInsToJson(List<CoffeeAddIns> coffeeAddIns)
    {
        string filePath = Utils.Utils.AddInsFilePath();
        string jsonData = JsonConvert.SerializeObject(coffeeAddIns, Formatting.Indented);
        File.WriteAllText(filePath, jsonData);
    }
    public static void InitializeAndSaveDefaultData()
    { 
        List<CoffeeAddIns> defaultAddInsList = new List<CoffeeAddIns>
            {
                new CoffeeAddIns { Name = "Sugar", Price = 0.5 },
                new CoffeeAddIns { Name = "Cream", Price = 0.75 },
                new CoffeeAddIns { Name = "Caramel", Price = 1.50 },
                new CoffeeAddIns { Name = "Hazelnut", Price = 1.50 },
                new CoffeeAddIns { Name = "Vanilla", Price = 1.50 },
                new CoffeeAddIns { Name = "Mocha", Price = 2.00 },
                new CoffeeAddIns { Name = "Irish Cream", Price = 2.00 },
                new CoffeeAddIns { Name = "Peppermint", Price = 2.00 },
                new CoffeeAddIns { Name = "Cinnamon", Price = 1.50 },
                new CoffeeAddIns { Name = "Pumpkin Spice", Price = 2.00 },
                new CoffeeAddIns { Name = "Gingerbread", Price = 2.00 },
                new CoffeeAddIns { Name = "Toffee Nut", Price = 2.00 }
            };
        SaveCoffeeAddInsToJson(defaultAddInsList);
    }

    public static List<CoffeeAddIns> RetrieveCoffeeData()
    {
        string filePath = Utils.Utils.AddInsFilePath();
        try
        {
            string existingJsonData = File.ReadAllText(filePath);
            if (string.IsNullOrEmpty(existingJsonData))
            {
                return new List<CoffeeAddIns>();
            }
            return JsonConvert.DeserializeObject<List<CoffeeAddIns>>(existingJsonData);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading JSON file: {ex.Message}");
            return new List<CoffeeAddIns>();
        }
    }
}
