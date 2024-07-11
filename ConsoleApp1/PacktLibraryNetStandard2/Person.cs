
namespace PacktLibraryNetStandard2;
public class Person : Object
{
    // Property
    public string Orign
    {
        get
        {
            return "Windos";
        }
    }
    #region Fields: Data or state for this person
    public string? Name; // ? means it can be null
    public DateTimeOffset Born;
    public WondersOfTheEncientWorld FavoriteAncientWonder;
    public WondersOfTheEncientWorld BucketList;
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    #endregion
    // Default Constructor
    public Person()
    {
        // Constructors can set default values for fields
        // including any read-only fields like Instantiated.
        Name = "Unknown";
        Instantiated = DateTime.Now;
        PrintOnConsole();
    }
    // Parametereized construcot
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }


    public void PrintOnConsole()
    {
        WriteLine("this is the library");
        string nice = "string", messag;
        string j = "Hello";
        PrintOnConsole(out messag, ref nice, in j);
        var tup = ("hello", 2, "nice");
        WriteLine($"Type of {tup.GetType()}");
    }
    public void PrintOnConsole(out string message, ref string hello, in string hell)
    {
        message = string.Empty;
        // hell = string.Empty;
    }
    public void Deconstruct(out string? name,
out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }
    public void Deconstruct(out string? name,
    out DateTimeOffset dob,
    out WondersOfTheEncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }
}
