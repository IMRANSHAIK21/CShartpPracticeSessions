using PacktLibrary;

namespace PeopleConsoleApp
{
    public partial class Program
    {
        private static void Main(string[] args)
        {
            Person jhon = new()
            {
                Name = "Jhon",
                Born = new DateTimeOffset(year: 200, month: 12, day: 12, hour: 0, minute: 0, second: 0,
     offset: TimeSpan.Zero),
            };
            Person merry = new()
            {
                Name = "Merry",
                Born = new DateTimeOffset(year: 200, month: 12, day: 12, hour: 0, minute: 0, second: 0,
             offset: TimeSpan.Zero),
            };
            Person.Marry(jhon, merry);

            WriteLine("Is Married: {0}", jhon.Married);

            //jhon.Marry(merry);

            Person lamech = new() { Name = "Lamech" };
            Person adah = new() { Name = "Adah" };
            Person zillah = new() { Name = "Zillah" };
            lamech.Marry(adah);
            // Call the static method to marry Lamech and Zillah.
            // Person.Marry(lamech, zillah);
            if (lamech + zillah)
            {
                WriteLine($"{lamech.Name} and {zillah.Name} successfully get married");
            }

            Person baby1 = lamech * adah;
            WriteLine(baby1.Name);

            Person harry = new Person();
            harry.Shout += Harry_Shout;
            harry.Name = "Harry";
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            // without IComparable
            Person?[] people =
            {
                null,
                new() { Name = "A"},
                new() { Name = "B"},
                new() { Name= "C"},
                new() { Name= "D"},
                new() { Name= "E"},
            };

            OutputPeopleName(people, "Initial List of People");
            // While using Comparable
            // Array.Sort(people);
            // While using Comparer
            Array.Sort(people, new PersonComparer());
            OutputPeopleName(people, "After sorting using person's IComaparable implementation:");

           


        }


    }
}

// Evnets

