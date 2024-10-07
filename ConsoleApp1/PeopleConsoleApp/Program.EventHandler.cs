using PacktLibrary;

namespace PeopleConsoleApp
{
    partial class Program
    {
       public static void Harry_Shout(object sender, EventArgs e)
        {
            if (sender is null) return;

            if (sender is not Person p) return;
            WriteLine($"{p.Name} is this angry: {p.AngryLevel}.");
        }

        public static void EqualityOfType()
        {
            int a = 3;
            int b = 3;
            WriteLine($"a: {a}, b: {b}");
            WriteLine($"a == b: {a == b}");
        }
    }
}
