using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public interface IPersonRepository
    {
        public List<Person> GetPeople(string lastName);
        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber);
        public void UpdatePerson(Person person);
        public void DeletePerson(Person person);
    }
}
