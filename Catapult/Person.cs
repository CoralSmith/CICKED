namespace Catapult
{
	public class Person
	{
		string firstName;
		string lastName;

		public Person(string firstName, string lastName)
		{
			this.firstName = firstName;
			this.lastName = lastName;
		}

		public string ShoutName()
		{
			return (firstName + ' ' + lastName).ToUpper();
		}
	}
}