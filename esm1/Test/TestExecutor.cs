using esm1.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esm1.Test
{
    public class TestExecutor
    {
        public static int Test1()
        {
            IPerson person = new PersonImpl()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 12, 26)
            };

            IPerson person2 = new PersonImpl()
            {
                Id = 2,
                FirstName = "Tal",
                LastName = "Jacob",
                DateOfBirth = new DateTime(1997, 12, 29)
            };

            return person.CompareTo(person2);
        }

        public static int Test2()
        {
            IPerson person = new PersonImpl()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 12, 26)
            };

            IPerson person2 = new PersonImpl()
            {
                Id = 1,
                FirstName = "Tal",
                LastName = "Jacob",
                DateOfBirth = new DateTime(1997, 12, 29)
            };

            return person.CompareTo(person2);
        }

        public static int Test3()
        {
            IPerson person = new PersonImpl()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 12, 26)
            };

            IPerson person2 = new PersonImpl()
            {
                Id = 1,
                FirstName = "Tal",
                LastName = "Jacob",
                DateOfBirth = new DateTime(1990, 12, 26)
            };

            return person.CompareTo(person2);
        }

        public static int Test4()
        {
            IPerson person = new PersonImpl()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 12, 26)
            };

            IPerson person2 = new PersonImpl()
            {
                Id = 2,
                FirstName = "Tal",
                LastName = "Jacob",
                DateOfBirth = new DateTime(1990, 12, 26)
            };

            return person.CompareTo(person2);
        }
    }
}
