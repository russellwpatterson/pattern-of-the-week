using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pattern of the Week #1: Singleton");

        // Fails at compile-time
        //var config = new ConfigurationSingleton();
        var config = Singleton.Instance;

        // Set the property to something.
        config.SomeProperty = "Hello, world!";

        var config2 = Singleton.Instance;

        // Set the property to something else.
        config2.SomeProperty = "Goodbye, world!";

        Console.WriteLine("");
        Console.WriteLine("Value of \"First\" Configuration SomeProperty:");
        Console.WriteLine(config.SomeProperty);

        Console.WriteLine("");
        Console.WriteLine("Value of \"Second\" Configuration SomeProperty:");
        Console.WriteLine(config2.SomeProperty);

        Console.ReadKey();
    }
}