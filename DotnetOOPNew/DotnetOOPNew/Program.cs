
var p1 = new Person("Kasper", "Schmidt", new DateOnly(1998, 5, 5));
var p2 = new Person("Maja", "Schjøtt", new DateOnly(1998, 11, 24));


List<Person> people = [p1, p2];



p1.Pets.Add(new Dog("Rex"));
p1.Pets.Add(new Dog("Simba"));

p2.Pets.Add(new Cat("Beyonce"));



foreach (var person in people)
{
    Console.WriteLine($"{person}");

    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"  {pet} ");
    }
}




public class Person(string firstName, string lastName, DateOnly birthday)
{
    public string First { get; } = firstName;
    public string Last { get; } = lastName;
    public DateOnly Birthday { get; } = birthday;
    public List<Pet>? Pets { get; } = new();
    public override string ToString()
    {
        return $"{First} {Last}";
    }
}




public abstract class Pet(string petName)
{
    public string First { get; } = petName;
    public abstract string MakeNoise();
    public override string ToString()
    {
        return $"I am a {GetType().Name}, and my name is {petName} and i {MakeNoise()}";
    }
}



public class Dog(string petName) : Pet(petName)
{
    public override string MakeNoise() => "Woof!";     
}


public class Cat(string petName) : Pet(petName)
{
    public override string MakeNoise() => "Meow!";
}

