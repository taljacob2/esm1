using esm1.Person;

namespace esm1.Test
{
    public class TestExecutor
    {

        /// <summary>
        /// Expected result: -1
        /// </summary>
        public static int Test1()
        {
            IPerson person = new PersonImpl()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 12, 26),
                Height = 179
            };

            IPerson person2 = new PersonImpl()
            {
                Id = 2,
                FirstName = "Tal",
                LastName = "Jacob",               
                DateOfBirth = new DateTime(1997, 12, 29),
                Height = 177
            };

            return person.CompareTo(person2);
        }

        /// <summary>
        /// Expected result: 0
        /// </summary>
        public static int Test2()
        {
            IPerson person = new PersonImpl()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 12, 26),
                Height = 179
            };

            IPerson person2 = new PersonImpl()
            {
                Id = 1,
                FirstName = "Tal",
                LastName = "Jacob",                
                DateOfBirth = new DateTime(1997, 12, 29),
                Height = 177
            };  

            return person.CompareTo(person2);
        }

        /// <summary>
        /// Expected result: 0
        /// </summary>
        public static int Test3()
        {
            IPerson person = new PersonImpl()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 12, 26),
                Height = 179
            };

            IPerson person2 = new PersonImpl()
            {
                Id = 1,
                FirstName = "Tal",
                LastName = "Jacob",
                DateOfBirth = new DateTime(1990, 12, 26),
                Height = 177
            };

            return person.CompareTo(person2);
        }

        /// <summary>
        /// Expected result: -1
        /// </summary>
        public static int Test4()
        {
            IPerson person = new PersonImpl()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 12, 26),
                Height = 179
            };

            IPerson person2 = new PersonImpl()
            {
                Id = 2,
                FirstName = "Tal",
                LastName = "Jacob",
                DateOfBirth = new DateTime(1990, 12, 26),
                Height = 177
            };

            return person.CompareTo(person2);
        }

        public static PersonCollection Test5()
        {
            IPerson person = new PersonImpl()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 12, 26),
                Height = 179
            };

            IPerson person2 = new PersonImpl()
            {
                Id = 2,
                FirstName = "Tal",
                LastName = "Jacob",
                DateOfBirth = new DateTime(1990, 12, 26),
                Height = 177
            };

            // Same as Test4 so far.

            PersonCollection personCollection = new()
            {
                person,
                person2
            };

            return personCollection;
        }

        public static PersonCollection Test6()
        {
            IPerson person = new PersonImpl()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 12, 26),
                Height = 179
            };

            IPerson person2 = new PersonImpl()
            {
                Id = 2,
                FirstName = "Tal",
                LastName = "Jacob",
                DateOfBirth = new DateTime(1990, 12, 26),
                Height = 177
            };

            IPerson person3 = new PersonImpl()
            {
                Id = 2,
                FirstName = "Richard",
                LastName = "Roe",
                DateOfBirth = new DateTime(1990, 11, 26),
                Height = 167
            };

            // Same as Test4 so far.

            PersonCollection personCollection = new()
            {
                person,
                person2,
                person3
            };

            return personCollection;
        }
    }
}
