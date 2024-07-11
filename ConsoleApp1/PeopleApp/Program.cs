//using PacktLibraryNetStandard2;// using in general way
using  PacktLibraryNetStandard2;
using System.Reflection.Metadata;
using Env = System.Environment;
namespace PeopleApp;

    internal partial class Program 
    {

    public static List<Person> Children = new();
        static void Main(string[] args)
        {
            ConfigureConsole(); 
            Person per = new ();
            per.PrintOnConsole();
            Console.WriteLine(per);
        per.Name = "Imran";
        per.Born = new DateTimeOffset();
        per.BucketList = WondersOfTheEncientWorld.HangingGardensOfBabylon
 | WondersOfTheEncientWorld.MausoleumAtHalicarnassus;
        per.FavoriteAncientWonder = WondersOfTheEncientWorld.GreatPyramidOfGiza | WondersOfTheEncientWorld.MausoleumAtHalicarnassus; ;
        Console.WriteLine($"{per.Name} buket List is {per.BucketList}");
        Console.WriteLine(Env.CommandLine);
        Console.WriteLine(Env.MachineName);
        Console.WriteLine(per.Name);
        Console.WriteLine((per.FavoriteAncientWonder));

        Console.WriteLine("---------------------------------");
        Person alfered = new Person ();
        alfered.Name = "Alfred";
        Children.Add( alfered );

        Children.Add(new Person { Name = "Imran" });
        Children.Add(new () { Name = "abc" });
        Console.WriteLine("count {0}", Children.Count);
        for (int i = 0; i < Children.Count; i++)
        {
            Console.WriteLine($"> {Children[i].Name}");
        }

        BankAccount.InterestRate = 100;

        BankAccount a1 = new BankAccount ();
        // here from object we cannot access the Interest rate from the objce, becasue it is static

        // Boook book = new Boook(); // will give error
        /*        Boook book = new Boook() // will work
                {
                    Isbn = "Isbn",
                    Title = "Title",
                };*/
        var (name1, dob1) = per; 
        Console.WriteLine($"Deconstructed person: {name1}, {dob1}");

        }
}

