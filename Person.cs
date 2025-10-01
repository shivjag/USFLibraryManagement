// Person.cs
public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string ID { get; set; }

    // Constructor to initialize the properties
    public Person(string name, string email, string id)
    {
        Name = name;
        Email = email;
        ID = id;
    }
}