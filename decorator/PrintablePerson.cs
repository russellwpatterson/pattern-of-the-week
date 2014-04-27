using System;

public class PrintablePerson : IPerson
{
    private readonly IPerson _person;
    public PrintablePerson(IPerson p)
    {
        _person = p;
    }

    public string FirstName
    {
        get { return _person.FirstName; }
        set { _person.FirstName = value; }
    }

    public string LastName
    {
        get { return _person.LastName; }
        set { _person.LastName = value; }
    }

    public string GetFullName()
    {
        return _person.GetFullName();
    }

    public void Print()
    {
        Console.WriteLine("Person: {0}", this.GetFullName());
    }
}
