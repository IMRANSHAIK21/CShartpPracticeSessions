#nullable enable
namespace NullHandling
{
    
   public partial class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            string nfg = null;
            // thisCannotBeNull = null; // CS0037 compiler error!
            WriteLine(thisCannotBeNull);
            int? thisCouldBeNull = null;
            WriteLine(thisCouldBeNull);
            WriteLine(thisCouldBeNull.GetValueOrDefault());
            thisCouldBeNull = 7;
            WriteLine(thisCouldBeNull);
            WriteLine(thisCouldBeNull.GetValueOrDefault());
            Nullable<int> thisCouleAlsoBeNull = null;
            WriteLine(thisCouleAlsoBeNull+"Null value is here");

            // Inhertance and abstraction
            Address address = new();

            address.Alpha1();
            // address.Alphe3();

            PartiallyImplementedAbstractClass1 par = new Address();
            /*par.Beta1();*/
            // par.Alphe3();


            // Will not be able to create the instance for the Interfaces and Abstract classes
            /* PartiallyImplementedAbstractClass1 par = new();
             INoImplementation noImplementation = new();*/

            WhichInheritsClassWhichContainSealedMethod1 seale = new();
            seale.Single();
            WhichInheritsClassWhichContainSealedMethod2 seal2 = new();
            seal2.Single();

        }
    }
}
