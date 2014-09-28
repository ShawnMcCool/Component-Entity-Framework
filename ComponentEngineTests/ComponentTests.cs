using NUnit.Framework;
using System;
using ComponentEngine;

namespace ComponentsTests
{
	[TestFixture()]
	public class ComponentTests
	{
		ComponentBase component;

		[SetUp] public void Init() {
			component = new ComponentBase();
		}

		[Test()] public void TestCanCreate() {
			Assert.IsInstanceOf<ComponentBase>(component);
		}


	}
}

