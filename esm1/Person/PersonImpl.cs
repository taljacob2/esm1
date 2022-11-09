namespace esm1.Person
{
    public class PersonImpl : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Height { get; set; }

        public int CompareTo(IPerson? other)
        {
            if (other == null) { return -1; }
            if (ReferenceEquals(this, other)) { return 0; }
            if (this.Id == other.Id) { return 0; }

            int returnValue = this.DateOfBirth.CompareTo(other.DateOfBirth);
            if (returnValue == 0)
            {
                returnValue = this.Id.CompareTo(other.Id);
            }

            return returnValue;
        }
    }
}
