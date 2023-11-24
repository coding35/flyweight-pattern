using FlyweightPattern.Interface;

namespace FlyweightPattern
{
    // This class is a concrete flyweight implementation of the ICup interface.
    public class Coffee : ICup
    {
        public String _coffeeType;
        public List<string> _ingredients = new List<string>();
        public Coffee(String coffeeType)
        {
            _coffeeType = coffeeType;
        }
        
        public void AddIngredient(String[] ingredients)
        {    _ingredients = new List<string>();
            foreach (var ingredient in ingredients)
            {
                _ingredients.Add(ingredient);
                Console.WriteLine(ingredient + " Added to " + _coffeeType + " Coffee");
            }
        }
        
        public void Serve()
        {
            Console.WriteLine("Serving " + _coffeeType + " Coffee with ingredients " + String.Join(", ", _ingredients));
        }
    }
}