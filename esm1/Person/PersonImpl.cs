using esm1.Misc;
using esm1.Misc.Observer;

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

        public override string ToString()
        {
            return this.ToStringExtension();
        }

        public void Update(ISubject subject)
        {
            PersonCollection personCollection;
            if ((personCollection = (PersonCollection) subject) != null)
            {
                Console.WriteLine($"{this} was notified that:" +
                    $" {personCollection.LastTouchedObject}" +
                    $" was {personCollection.LastTouchedObjectStatus}.");
            }
            else
            {
                Console.WriteLine($"{this} was notified.");
            }
        }
    }
}
