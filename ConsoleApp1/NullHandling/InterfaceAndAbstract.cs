using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NullHandling
{
    public interface INoImplementation {
        void Alpha1(); // Must be implemented by derived type; this is before c# 8
    }
    public interface ISomeImplementation
    {
        void Alphe2(); // Must be implemented by the derived Type
        void Beta0()
        {
            WriteLine("Default Implementation in the interface this in c#8 and later");
        }
    }
    public abstract class PartiallyImplementedAbstractClass1
    {
/*        public abstract void Alphe3();*/
/*        public virtual void Beta1()
        {
            Console.WriteLine("This is in the partially Implemented Abstract class with virtual");
        }*/
/*        public void Gama1()
        {
            Console.WriteLine("This is in the partially Implemented Abstract class without virtual");
        }*/

    }
    public abstract class PartiallyImplementedAbstractClass2
    {
        public abstract void Alphe4();
        public virtual void Beta1()
        {
            Console.WriteLine("This is in the partially Implemented Abstract class with virtual");
        }
        public void Gama2()
        {
            Console.WriteLine("This is in the partially Implemented Abstract class without virtual");
        }

    }
    public sealed class NotAllowedToInherit
    {
        // sealed keyword it prevents others to inhertic the class.
        public void Sing() 
        {
            Console.WriteLine("I am sealed");
        }
    }
}
