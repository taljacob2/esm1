using System;
namespace esm1.Person
{
    public interface IPerson : IComparable<IPerson>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
