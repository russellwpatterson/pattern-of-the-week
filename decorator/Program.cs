using System;

class Program
{
    static void Main(string[] args)
    {
        NoDecoratorClass();
        WithDecoratorClass();

        Console.ReadKey();
    }

    private static void NoDecoratorClass()
    {
        var p = new Person();

        p.FirstName = "John";
        p.LastName = "Public";

        // Let's print out the person's full name
        var fullName = p.GetFullName();
        Console.WriteLine("Person: {0}", fullName);
    }

    private static void WithDecoratorClass()
    {
        // Decorate the class
        var pp = new PrintablePerson(new Person());

        pp.FirstName = "John";
        pp.LastName = "Public";

        pp.Print();
    }
}

