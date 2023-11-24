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
            cupCategory = cup;
        }
        else
        {
            switch (coffeeType)
            {
                case "Black":
                    cupCategory = new Coffee(coffeeType);
                    _cups.Add("Black", cupCategory);
                    break;
                case "Cappuccino":
                    cupCategory = new Coffee(coffeeType);
                    _cups.Add("Cappuccino", cupCategory);
                    break;
                case "Espresso":
                    cupCategory = new Coffee(coffeeType);
                    _cups.Add("Espresso", cupCategory);
                    break;
                default:
                    throw new Exception("Coffee type not recognized.");
            }
        }
        return cupCategory;
    }
}