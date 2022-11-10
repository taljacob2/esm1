using esm1.Misc.Observer;

namespace esm1.Person
{
    public interface IPerson : IComparable<IPerson>, IObserver
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
