using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class MathTests
	{
		//SetUp
		private Fundamentals.Math? _math;
		[SetUp]
		public void SetUp()
		{
			_math = new Fundamentals.Math();
		}

		[Test]
		public void Add_WhenCalled_ReturnSum()
		{
			var result = _math?.Add(2, 3);

			Assert.That(result, Is.EqualTo(5));
		}

		[Test]
		[TestCase(4, 3, 4)]
		[TestCase(2, 3, 3)]
		[TestCase(2, 2, 2)]
		public void Max_WhenCalled_ReturnsGreaterArgument(int a, int b, int expected)
		{
			var result = _math?.Max(a, b);

			Assert.That(result, Is.EqualTo(expected));
		}

		[Test]
		public void GetOddNumbers_LimitGreaterThanZero_ReturnsOddNumbersUpToLimit()
		{
			var result = _math?.GetOddNumbers(5);

			//Assert.That(result, Is.Not.Empty);
			//Assert.That(result.Count(), Is.EqualTo(3));
			Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
			//Assert.That(result,Is.Ordered);
			//Assert.That(result,Is.Unique);

		}

	}
}
