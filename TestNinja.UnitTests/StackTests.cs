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
	public class StackTests
	{
		[Test]
		public void Push_ObjectIsNull_ThrowsArgumentNullException()
		{
			var stack = new Fundamentals.Stack<object>();
			object? obj = null;

			Assert.That(() => stack.Push(obj!), Throws.ArgumentNullException);
		}

		[Test]
		public void Push_ObjectIsNotNull_ObjectAdded()
		{
			var stack = new Fundamentals.Stack<string>();
			string obj = "hola";

			stack.Push(obj);

			Assert.That(stack.Count, Is.EqualTo(1));

		}

		[Test]
		public void Count_EmptyStack_ReturnZero()
		{
			var stack = new Fundamentals.Stack<int>();

			Assert.That(stack.Count, Is.EqualTo(0));
		}


		[Test]
		public void Pop_WhenIsEmpty_ThrowsInvalidOperationException()
		{
			var stack = new Fundamentals.Stack<string>();

			Assert.That(() => stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());

		}

		[Test]
		public void Pop_WhenIsNotEmpty_RemovesObjectFromStack()
		{
			var stack = new Fundamentals.Stack<string>();
			string obj = "hola";

			stack.Push(obj);
			stack.Pop();

			Assert.That(stack.Count, Is.EqualTo(0));

		}
		[Test]
		public void Pop_WhenIsNotEmpty_ReturnsObjectOnTheTop()
		{
			var stack = new Fundamentals.Stack<string>();
			string obj1 = "hola";
			string obj2 = "chau";

			stack.Push(obj1);
			stack.Push(obj2);
			var result = stack.Pop();

			Assert.That(result, Is.EqualTo(obj2));

		}


		[Test]
		public void Peek_WhenIsEmpty_ThrowsInvalidOperationException()
		{
			var stack = new Fundamentals.Stack<string>();

			Assert.That(() => stack.Peek(), Throws.Exception.TypeOf<InvalidOperationException>());
		}

		[Test]
		public void Peek_WhenIsNotEmpty_ReturnObjectOnTheTop()
		{
			var stack = new Fundamentals.Stack<string>();

			string obj1 = "hola";
			string obj2 = "chau";

			stack.Push(obj1);
			stack.Push(obj2);

			Assert.That(stack.Peek(), Is.EqualTo(obj2));
		}

		[Test]
		public void Peek_WhenIsNotEmpty_DoesNotRemoveObject()
		{
			var stack = new Fundamentals.Stack<string>();

			string obj1 = "hola";
			string obj2 = "chau";

			stack.Push(obj1);
			stack.Push(obj2);
			var result = stack.Peek();

			Assert.That(stack.Peek(), Is.EqualTo(result));
		}

	}
}
