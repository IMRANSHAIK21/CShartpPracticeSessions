using System.Globalization; // for the culture infor
using System;
namespace PeopleApp
{
    partial class Program : System.Object
    {
        private static void ConfigureConsole(
            string culture = "en-US",
            bool useComputerCulture = false,
            bool showCulture = true)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (!useComputerCulture)
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
            }
            if (showCulture)
            {
                Console.WriteLine($"Current Culture = : {CultureInfo.CurrentCulture}");
            }
        }
    }
}
