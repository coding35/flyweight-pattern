using FlyweightPattern.Interface;

namespace FlyweightPattern
{
    // This class is a concrete flyweight implementation of the ICup interface.
    public class Coffee : ICup
    {
        private readonly string _coffeeType;
        public Coffee(string coffeeType)
        {
            _coffeeType = coffeeType;
        }
        
        public void Serve(string size)
        {
            Console.WriteLine($"Serving {size} {_coffeeType} Coffee");
        }
    }
    

}