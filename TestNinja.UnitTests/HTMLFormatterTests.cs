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
	public class HTMLFormatterTests
	{
		[Test]
		public void FormatAsBold_WhenCalled_EncloseTheStringWithStrongTag()
		{
			var formatter = new HtmlFormatter();

			var result = formatter.FormatAsBold("asd");

			Assert.That(result, Is.EqualTo("<strong>asd</strong>").IgnoreCase);
		}
	}
}
