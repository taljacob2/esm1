using System;
namespace esm1.Person
{
    public interface IPerson : IComparable<IPerson>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Height, provided in centimeter units.
        /// <example>
        /// For example 170, 165, 150, ...
        /// </example>
        /// </summary>
        public int Height { get; set; }
    }
}
