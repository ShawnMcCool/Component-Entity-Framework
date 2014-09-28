using NUnit.Framework;
using System;
using ComponentEngine;

namespace ComponentsTests
{
	[TestFixture()]
	public class ComponentTests
	{
		[Test()]
		public void TestCanCreate() {
			Assert.IsInstanceOf<Component>(new Component());
		}
	}
}

