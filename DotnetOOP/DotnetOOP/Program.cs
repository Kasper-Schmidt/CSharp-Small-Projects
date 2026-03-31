
var p1 = new Person("Kasper", "Schmidt", new DateOnly(1998, 5, 5));
var p2 = new Person("Maja", "Schjøtt", new DateOnly(1998, 11, 24));

public class Person
{
    public Person(string first, string last, DateOnly bd)
    {
        firstName = first;
        lastName = last;
        birthday = bd;
    }
    private string? firstName;
    private string? lastName;
    private DateOnly birthday;
}