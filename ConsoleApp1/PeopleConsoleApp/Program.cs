
using PacktLibrary;
Person jhon = new()
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
if(lamech + zillah)
{
    WriteLine($"{lamech.Name} and {zillah.Name} successfully get married");
}

Person baby1 = lamech * adah;
WriteLine(baby1.Name);

