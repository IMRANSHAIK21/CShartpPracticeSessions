using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullHandling
{
    public class ClassWhichContainSomeMethod
    {
        public virtual void Single()
        {
            WriteLine("I am singing");
        }
    }
    public class WhichInheritsClassWhichContainSealedMethod1 : ClassWhichContainSomeMethod
    {
        public sealed override void Single()
        {
            WriteLine("You will not sing");
        }
    }
    public class WhichInheritsClassWhichContainSealedMethod2 : ClassWhichContainSomeMethod
    {
        public override void Single() { WriteLine("Hello Brother I am alreadey Selaed"); }
    }
}
