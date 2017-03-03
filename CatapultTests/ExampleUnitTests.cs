using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Catapult;

namespace CatapultTests
{
	[TestClass]
	public class ExampleUnitTests
	{
		public Util testInstance = new Util();
		[TestMethod]
		public void AddPositiveNumbers()
		{
			int thierry = 14;
			int bergkamp = 10;
			int result = testInstance.Add(thierry, bergkamp);
			Assert.AreEqual(24, result);
		}

		[TestMethod]
		public void AddNegativeNumbers()
		{
			int thierry = -12;
			int bergkamp = -10;
			int result = testInstance.Add(thierry, bergkamp);
			Assert.AreEqual(-22, result);
		}

		[TestMethod]
		public void AddCoralsStupidNumbers()
		{
			double thierry = 2.5;
			double bergkamp = 3.7;
			double result = testInstance.Add(thierry, bergkamp);
			Assert.AreEqual(6.2, result);
		}

        [TestMethod]
        public void NumDaysDiff()
        {
            DateTime targetbirthday = new DateTime(2017, 06, 11);
            int difference = testInstance.DaysFromNow(targetbirthday);
            Assert.AreEqual(107, difference);

        }

        //next task accepts person as parameter and returns uppercase first and last name
        [TestMethod]
        public void ReturnsUppercaseFullName()
        {
            Person newPerson = new Person("Mark", "Markson");
            string shoutedFullName = newPerson.ShoutName();
            Assert.AreEqual("MARK MARKSON", shoutedFullName);
        }
    }
}
