using esm1.Person;
using esm1.Test;

Console.WriteLine(TestExecutor.Test1());
Console.WriteLine(TestExecutor.Test2());
Console.WriteLine(TestExecutor.Test3());
Console.WriteLine(TestExecutor.Test4());
//TestExecutor.Test5().Print();
Console.WriteLine(TestExecutor.Test5());


IPerson person = new PersonImpl()
{
    Id = 1,
    FirstName = "John",
    LastName = "Doe",
    DateOfBirth = new DateTime(1990, 12, 26),
    Height = 179
};

Console.WriteLine(person);