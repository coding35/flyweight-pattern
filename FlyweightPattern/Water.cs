using FlyweightPattern.Interface;

namespace FlyweightPattern;

// unshared concrete flyweight
public class Water : ICup
{
    // All state is intrinsic
    public string Name { get => "Water"; }
    private string _size;

    public Water()
    {
        _size = "Large";
    }
        
    // Extrinsically shared state
    public void Serve(string size)
    {
        _size = size;
        Console.WriteLine($"Serving {size} Water");
    }
}