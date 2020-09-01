using PersonRepository.Interface;
using System;
using System.Collections.Generic;

namespace PersonRepository.Fake
{
	public class FakeRepository : IPersonRepository
	{
		public IEnumerable<Person> GetPeople()
		{
			var people = new List<Person>()
			{
				new Person() {Id = 1, GivenName = "Eskay", FamilyName = "Teejay", 
					Rating = 8, StartDate = new DateTime(2000, 10,1)},
				new Person() {Id = 2, GivenName = "Chuks", FamilyName = "Nduk", 
					Rating = 8, StartDate = new DateTime(2005, 10,1)},
			};
			return people;
		}

		public void AddPerson(Person newPerson)
		{
			throw new NotImplementedException();
		}

		public void DeletePerson(int id)
		{
			throw new NotImplementedException();
		}

		public Person GetPerson(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdatePerson(int id, Person updatedPerson)
		{
			throw new NotImplementedException();
		}
	}
}
