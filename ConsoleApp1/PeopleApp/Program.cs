//using PacktLibraryNetStandard2;// using in general way
using PacktLibraryNetStandard2;
using System.Reflection.Metadata;
using Env = System.Environment;
namespace PeopleApp;

internal partial class Program
{



    static void Main(string[] args)
    {
        /*            ConfigureConsole(); 
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
                *//*        Boook book = new Boook() // will work
                        {
                            Isbn = "Isbn",
                            Title = "Title",
                        };*//*
                var (name1, dob1) = per; // using the Deconstruct
                Console.WriteLine($"Deconstructed person: {name1}, {dob1}");*/

        Person p = new();
        /* p.FovoriteWonder = WondersOfTheEncientWorld.GreatPyramidOfGiza | WondersOfTheEncientWorld.HangingGardensOfBabylon;*/
        // p.FovoriteWonder = (WondersOfTheEncientWorld)64;// takes inter byes values on index
        /*        p.Children.Add(new()
                {
                    Name = "Charlie",
                    Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero)
                });
                p.Children.Add(new()
                {
                    Name = "Ella",
                    Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero)
                });
                Console.WriteLine($"Sam's first child is {p.Children[0].Name}.");
                Console.WriteLine($"Sam's second child is {p.Children[1].Name}.");
                // Get using the int indexer.
                Console.WriteLine($"Sam's first child is {p[0].Name}.");
                Console.WriteLine($"Sam's second child is {p[1].Name}.");
                // Get using the string indexer.
                Console.WriteLine($"Sam's child named Ella is {p["Ella"].Born} year");*/

        Passenger[] passengers = {
 new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
 new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy"},
 new BusinessClassPassenger { Name = "Janice" },
 new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave"},
 new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" } };

        // Pattern matching on switch
        foreach (Passenger passenger in passengers)
        {
            // this is the c#8 syntax style
            float flightCost = passenger switch
            {
                FirstClassPassenger g when g.AirMiles > 35_000 => 1_500F,
                FirstClassPassenger g when g.AirMiles > 15_00 => 1750F,
                FirstClassPassenger _ => 2_000f,
                BusinessClassPassenger _ => 1_000f,
                CoachClassPassenger g when g.CarryOnKG < 10.0 => 500f,
                CoachClassPassenger _ => 650f,
                _ => 800f
            };
            // this is C#9 enhancement
            float fligtCost = passenger switch
            {
                FirstClassPassenger g => g.AirMiles switch
                {
                    > 35_000 => 1_500F,
                    > 15_00 => 1750F,
                    _ => 2_000f,
                },
                BusinessClassPassenger _ => 1_000f,
                CoachClassPassenger g when g.CarryOnKG < 10.0 => 500f,
                CoachClassPassenger _ => 650f,
                _ => 800f
            };
            // using the relation pattern {}
            float fligCost = passenger switch
            {
                FirstClassPassenger { AirMiles: > 35_000 } => 1_500F,
                FirstClassPassenger { AirMiles: > 15_00 } => 1750F,
                FirstClassPassenger => 2_000f,
                BusinessClassPassenger _ => 1_000f,
                CoachClassPassenger {CarryOnKG: < 10.0 } => 500f,
                CoachClassPassenger  => 650f,
                _ => 800f
            };

            Console.WriteLine($"Flight costs {flightCost:C} for {passenger}");

            // some times we forget to give some values
            // once instantiated we cannot change the values
            // so, to avoid that, just the declared the properties as required.
            //Before using required
            // ImmutablePerson im = new()
            // {
            // FirstName = "Imran",
            // LastName = "Shaik",// here I forgot last name now we cannot change the vaue
            // };
            // uncomment this to check the error.
            // im.LastName = "Shaik";

            // While using readonly
            // comment one of the parameter to see the error
             ImmutablePerson im = new()
            {
            FirstName = "FirstName",
             LastName = "LastName",// here I forgot last name now we cannot change the vaue
             };

            Records r = new()
            {
                FirstName = "FirstName",
                LastName = "LastName",
        };
        }


    }
}

