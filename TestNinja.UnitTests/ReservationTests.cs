using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
	//NUnit
	[TestFixture]
	public class ReservationTests
	{
		[Test]
		//public void MethodTested_Scenario_ExpectedBehaviour(){}
		public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
		{
			//Arrange
			var reservation = new Reservation();

			//Act
			var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

			//Assert
			Assert.That(result, Is.True);
		}

		[Test]
		public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
		{
			var user = new User();
			var reservation = new Reservation { MadeBy = user };

			var result = reservation.CanBeCancelledBy(user);

			Assert.That(result);
		}

		[Test]
		public void CanBeCancelledBy_IsSomeoneElse_ReturnsFalse()
		{
			var reservation = new Reservation { MadeBy = new User() };

			var result = reservation.CanBeCancelledBy(new User());

			Assert.IsFalse(result);
		}

		//[TestClass]
		//public class ReservationTests
		//{
		//	[TestMethod]
		//	//public void MethodTested_Scenario_ExpectedBehaviour(){}
		//	public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
		//	{
		//		//Arrange
		//		var reservation = new Reservation();

		//		//Act
		//		var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

		//		//Assert
		//		Assert.IsTrue(result);
		//	}

		//	[TestMethod]
		//	public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
		//	{
		//		var user = new User();
		//		var reservation = new Reservation { MadeBy = user };

		//		var result = reservation.CanBeCancelledBy(user);

		//		Assert.IsTrue(result);
		//	}

		//	[TestMethod]
		//	public void CanBeCancelledBy_IsSomeoneElse_ReturnsFalse()
		//	{
		//		var reservation = new Reservation { MadeBy = new User() };

		//		var result = reservation.CanBeCancelledBy(new User());

		//		Assert.IsFalse(result);
		//	}
	}
}