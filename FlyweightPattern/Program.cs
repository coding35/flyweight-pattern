﻿// See https://aka.ms/new-console-template for more information

namespace FlyweightPattern;

class Program
{
    static void Main(string[] args)
    {
        CoffeeFactory coffeeFactory = new CoffeeFactory();
        Console.WriteLine("\n***Flyweight Pattern Example***\n");
        Coffee cup;

        for (int i = 0; i < 3; i++)
        {
            cup = (Coffee)coffeeFactory.GetCoffeeFromFactory("Black");
            cup.Serve(GetRandomSize());
        }
        
        for (int i = 0; i < 3; i++)
        {
            cup = (Coffee)coffeeFactory.GetCoffeeFromFactory("Cappuccino");
            cup.Serve(GetRandomSize());
        }
        
        int coffeeCount = coffeeFactory.TotalObjectsCreated;
        Console.WriteLine($"\nTotal Coffee objects created: {coffeeCount}");
    }

    private static string GetRandomSize()
    {
        var ingredients = new List<string>();
        Random r = new Random();
        int random = r.Next(100);
        if (random % 2 == 0)
        {
            return "Large";
        }
        else
        {
            return "Small";
        }

    }
}

