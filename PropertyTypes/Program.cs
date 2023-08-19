
using PropertyTypes;

PersonModel person = new PersonModel("Pole");

person.FirstName = "Tad";
//person.LastName = "Pole";
person.Age = 41;
person.SSN = "321-10-7721";

Console.WriteLine(person.SSN);

Console.ReadLine();