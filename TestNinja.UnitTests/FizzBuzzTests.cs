using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void GetOutput_WhenIsDivisibleBy3_ReturnsFizz()
		{
			var result = FizzBuzz.GetOutput(3);

			Assert.That(result, Is.EqualTo("Fizz"));
		}

		[Test]
		public void GetOutput_WhenIsDivisibleBy5_ReturnsBuzz()
		{
			var num = 5;

			var result = FizzBuzz.GetOutput(num);

			Assert.AreEqual(result, "Buzz");
		}


		[Test]
		public void GetOutput_WhenIsDivisibleBy3And5_ReturnsFizzBuzz()
		{
			var num = 15;

			var result = FizzBuzz.GetOutput(num);

			Assert.AreEqual(result, "FizzBuzz");
		}

		[Test]
		public void GetOutput_WhenIsNotDivisibleBy3Or5_ReturnsNumber()
		{
			var num = 17;

			var result = FizzBuzz.GetOutput(num);

			Assert.AreEqual(result, num.ToString());
		}
	}
}
