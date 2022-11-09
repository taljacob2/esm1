using esm1.Person;

Console.WriteLine("Hello, World!");

IPerson person = new PersonImpl() {
    Id = 1,
    FirstName = "John",
    LastName = "Doe",
    DateOfBirth = new DateTime(1990, 12, 26)
};
IPerson person2 = new PersonImpl() {
    Id = 1,
    FirstName = "Tal",
    LastName = "Jacob",
    DateOfBirth = new DateTime(1997, 12, 29)
};

Console.WriteLine(person.CompareTo(person2));