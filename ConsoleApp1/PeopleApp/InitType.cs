
namespace PeopleApp
{
    /*    public class ImmutablePerson
        {
            public string? FirstName { get; init; }
            public string? LastName { get; init; }
        }*/

    // using required keyword
    public class ImmutablePerson
    {
        public required string? FirstName { get; init; }
        public required string? LastName { get; init; }
    }
}
