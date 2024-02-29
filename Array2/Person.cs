namespace Array2;

public class Person
{
    private sealed class NameEqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Name == y.Name;
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode();
        }
    }

    public static IEqualityComparer<Person> NameComparer { get; } = new NameEqualityComparer();

    public string Name { get; set; }
}