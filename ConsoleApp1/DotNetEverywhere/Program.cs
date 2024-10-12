using Newtonsoft.Json;
namespace DotNetEverywhere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I can run everywhere");
            Console.WriteLine($"os version is {Environment.OSVersion}");
            if (OperatingSystem.IsMacOS())
            {
                Console.WriteLine("I am MacOS");
            }
            else if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 22630,0))
            {
                Console.WriteLine("I am windows 11");
            }
            else if (OperatingSystem.IsWindowsVersionAtLeast(10))
            {
                Console.WriteLine("I am windows 10");
            }
            else
            {
                Console.WriteLine("I am a misterious OS");
            }
            Console.WriteLine("Press any key to stop me");
            Console.ReadKey(intercept: true);

        }
    }
}
