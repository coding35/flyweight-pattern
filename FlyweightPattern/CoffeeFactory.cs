using FlyweightPattern.Interface;

namespace FlyweightPattern;

// Flyweight factory class
public class CoffeeFactory
{
    readonly Dictionary<string, ICup> _cups = new Dictionary<string, ICup>();
    public int TotalObjectsCreated => _cups.Count;
    public ICup GetCoffeeFromFactory(String coffeeType)
    {
        ICup cupCategory;
        if (_cups.TryGetValue(coffeeType, out var cup))
        {
            Console.WriteLine("\nUsing existing cup object");
            cupCategory = cup;
        }
        else
        {
            Console.WriteLine("\nCreating new cup object coffee type: " + coffeeType);
            switch (coffeeType)
            {
                case "Black":
                    cupCategory = new Coffee(coffeeType);
                    break;
                case "Cappuccino":
                    cupCategory = new Coffee(coffeeType);
                    break;
                case "Espresso":
                    cupCategory = new Coffee(coffeeType);
                    break;
                default:
                    throw new Exception("Coffee type not recognized.");
            }
            _cups.Add(coffeeType, cupCategory);
        }
        return cupCategory;
    }
    
    public ICup GetWaterFromFactory()
    {
        return new Water();
    }
}