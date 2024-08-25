using PacktLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleConsoleApp
{
    public partial class Program
    {
        private static void OutputPeopleName(IEnumerable<Person?> people, string title)
        {
            WriteLine(title);
            foreach (Person person in people)
            {
                WriteLine(" {0}", person is null ? "<null> Person" : person.Name ?? "<null> Name");
            }
        }
    }
}
