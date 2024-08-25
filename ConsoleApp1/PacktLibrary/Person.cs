using System.Security.Cryptography;
using System;

namespace PacktLibrary;
public class Person //: IComparable<Person?>
{
    #region Properties
    public string? Name { get; set; }
    public DateTimeOffset Born { get; set; }
    public List<Person> Children = new();
    public List<Person> Spouses = new();
    public bool Married => Spouses.Count > 0;
    #endregion
    #region Methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }
    public void WriteChildrenToConsole()
    {
        string term = Children.Count == 1 ? "child" : "children";
        WriteLine($"{Name} has {Children.Count} {term}.");
    }
    #endregion
    #region Instance Method
    public void Marry(Person partner)
    {
        Marry(this, partner);
    }
    #endregion
    #region Static Method
    public static void Marry(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);
        if (p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
        {
            throw new ArgumentException(
            string.Format("{0} is already married to {1}.",
            arg0: p1.Name, arg1: p2.Name));
        }
        p1.Spouses.Add(p2);
        p2.Spouses.Add(p1);

    }
    #endregion
    public void OutputSpouses()
    {
        if (Married)
        {
            string term = Spouses.Count == 1 ? "person" : "people";
            WriteLine($"{Name} is married to {Spouses.Count} {term}");
        foreach (Person spouse in Spouses)
            {
                WriteLine($" {spouse.Name}");
            }
        }
        else
        {
            WriteLine($"{Name} is a singleton.");
        }
    }

    public static Person Procreate(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if(!p1.Spouses.Contains(p2) && !p2.Spouses.Contains(p1))
        {
            throw new ArgumentException(
                $"{p1.Name} must be married to {p2.Name} to procreate with them");

        }
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}",
            Born = DateTimeOffset.Now,
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;

    }
    //This we will take as an example for delegae 
    public int MethodIWantToCall(string input)
    {
        return input.Length; // It doesn't matter what the method do
    }
    public Person ProcreateWith(Person partner)
    {
       return Procreate(this, partner);
    }
   
    public static bool operator + (Person a, Person b)
    {
        Marry(a, b);
        return a.Married && b.Married;
    }
    public static Person operator *(Person a, Person b)
    {
        return Procreate(a,b);
    }

    // Event handlers
    public event EventHandler? Shout;
    public int AngryLevel;

    public void Poke()
    {
        AngryLevel++;
        if (AngryLevel < 3) return;
        if (Shout is not null)
        {
            Shout(this, EventArgs.Empty);
        }
    }

    /*public int CompareTo(Person? other)
    {
        int position;
        if (other is not null)
        {
            if ((Name is not null) && (other.Name is not null))
            {
                position = -(Name.CompareTo(other.Name));
            }
            else if ((Name is not null) && (other.Name is null))
            {
                position = 1; // this Person precedes other Person. 
            }
            else if ((Name is null) && (other.Name is not null))
            {
                position = -1;
            }
            else
            {
                position = 0; // this and other are at same position. 
            }
        }
        else if (other is null)
        {
            position = -1; // this Person precedes other Person. 
        }
        else
        {
            position = 0; // this and other are at same position. 
        }
        return position;
    }*/
    // for decending order
/*    public int CompareTo(Person? other)
    {
        if (other == null) return 1;

        if (this.Name == null && other?.Name == null) return 0;
        if (this.Name == null) return -1;
        if (other?.Name == null) return 1;

        return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
    }*/
}
