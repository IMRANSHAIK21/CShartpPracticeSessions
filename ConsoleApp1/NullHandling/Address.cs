using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullHandling
{
    public class Address : PartiallyImplementedAbstractClass1 /*NotAllowedToInherit*/, INoImplementation
    {
        public string? Building;
        public string Street = string.Empty;
        public string City;
        public string Region;
        public Address()
        {
            City = string.Empty;
            Region = string.Empty;
        }

        public void Alpha1()
        {
            WriteLine("I am in the Address and Alpha1 which of INoImplementation");
        }

/*        public override void Alphe3()
        {

            WriteLine("I am in the Address and Alphe3 which of PartiallyImplementedAbstractClass1");
        }*/

        public void Beta1()
        {
            WriteLine("I am in the Address and Beta1 which of partially Implemented Abstract class1");
        }

    }
}
