namespace esm1.Person
{
    public interface IPerson : IComparable<IPerson>
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }

        /// <summary>
        /// Height, provided in centimeter units.
        /// <example>
        /// For example 170, 165, 150, ...
        /// </example>
        /// </summary>
        public int Height { get; }
    }
}
