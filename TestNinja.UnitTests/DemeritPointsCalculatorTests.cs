using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class DemeritPointsCalculatorTests
	{
		[Test]
		[TestCase(-1)]
		[TestCase(301)]
		public void CalculateDemeritPoints_WhenSpeedLessThanZeroOrGreaterThanMaxSpeed_ThrowsArgumentOutOfRangeException(int speed)
		{
			var dpc = new DemeritPointsCalculator();

			Assert.That(() => dpc.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
		}

		[Test]
		[TestCase(0, 0)]
		[TestCase(64, 0)]
		[TestCase(65, 0)]
		[TestCase(66, 0)]
		[TestCase(70, 1)]
		public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expected)
		{
			var dpc = new DemeritPointsCalculator();

			var result = dpc.CalculateDemeritPoints(speed);

			Assert.That(result, Is.EqualTo(expected));
		}


	}
}
