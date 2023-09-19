// See https://aka.ms/new-console-template for more information
using exc4;
using System.Text.Json;

Person person = new Person
{
    Name = "John",
    Age = 30
};

string jsonString = JsonSerializer.Serialize(person);

Console.WriteLine("Serialized JSON:");
Console.WriteLine(jsonString);

Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);

Console.WriteLine("\nDeserialized Object:");
Console.WriteLine($"Name: {deserializedPerson.Name}");
Console.WriteLine($"Age: {deserializedPerson.Age}");
