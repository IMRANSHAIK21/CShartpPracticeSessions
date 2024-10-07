using PacktLibrary;
using System.ComponentModel.Design;

namespace PeopleConsoleApp
{
    public partial class Program
    {
        private static void Main(string[] args)
        {
            /*            Person jhon = new()
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

                        EqualityOfType();

                        DisplacementVector dv1 = new DisplacementVector(3, 5);
                        DisplacementVector dv2 = new DisplacementVector(-2, 7);
                        DisplacementVector dv3 = dv1 + dv2;
                        DisplacementVector dv4 = new DisplacementVector(3, 5);

                        WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

                        // We cannot use the == with struct so we can use the Equals method
                        // WriteLine($"{dv1 == dv2}");
                        WriteLine($"dv1 == dv5: {dv1.Equals(dv4)}");

                        // After using Record Struct
                        WriteLine($"dv1 == dv2 : {dv1==dv4}");

                        int? s = null;*/

            Employee emplyee1 = new Employee()
            {
                Name = "Jhone Jones",
                Born = new DateTimeOffset(1990, 7, 28, 0, 0, 0, TimeSpan.Zero),
            };
            // emplyee1.WriteToConsole();
            emplyee1.EmployeeCode = "JJ001";

            Person p = emplyee1;
            emplyee1.WriteToConsole();
            p.WriteToConsole();
            Console.WriteLine(emplyee1.ToString());
            Console.WriteLine(p.ToString());

            Employee employee2 = (Employee)p;


            // using is and as 

            Person jhon = new()
            {
                Name = "Jhon",
                Born = new DateTimeOffset(year: 200, month: 12, day: 12, hour: 0, minute: 0, second: 0,
   offset: TimeSpan.Zero),
            };

            Employee alice = new Employee()
            {
                Name = "Jhone Jones",
                Born = new DateTimeOffset(1990, 7, 28, 0, 0, 0, TimeSpan.Zero),
                EmployeeCode = "123"
            };
            if (jhon is Person)
            {
                Console.WriteLine("Yes Jhon is a person");
            }
            else
            {
                Console.WriteLine("No Jhon is a person");
            }
            if (alice is Employee)
            {
                Console.WriteLine("Yes Alce is an employee");
            }
            else
            {
                Console.WriteLine("No Alce is an employee");
            }

            if (alice is Person)
            {
                Console.WriteLine("Yes alice is also a person");
            }
            else
            {
                Console.WriteLine("No alice is also a person");
            }

            if(jhon is Employee)
            {
                Console.WriteLine("Yes Jhon is also a Employee");
            }
            else
            {
                Console.WriteLine("No Jhon is not a Emplyee");
            }

            WriteLine("______________________Here using Rgex__________________________");
            string email1 = "pamela@test.com";
            string email2 = "ian&test.com";
            WriteLine("{0} is a valid e-mail address: {1}",
 arg0: email1,
 arg1: StringExtensions.IsValidEmail(email1));
            WriteLine("{0} is a valid e-mail address: {1}",
             arg0: email2,
             arg1: StringExtensions.IsValidEmail(email2));

        }
    }
}

// Evnets

