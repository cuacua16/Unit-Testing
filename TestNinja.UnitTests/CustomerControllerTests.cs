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
	public class CustomerControllerTests
	{

		[Test]
		public void GetCustomer_IdIsZero_ReturnsNotFound()
		{
			var controller = new CustomerController();

			var result = controller.GetCustomer(0);

			Assert.That(result, Is.TypeOf<NotFound>()); // NotFound Type

			//Assert.That(result, Is.InstanceOf<NotFound>()); //NotFound o derivados
		}

		[Test]
		public void GetCustomer_IdIsNotZero_ReturnsOk()
		{

		}
	}
}
