using NUnit.Framework;
using System;
using ComponentEngine;

namespace ComponentsTests
{
	[TestFixture()]
	public class EntityManagerTests
	{
		EntityManager entityManager;

		[SetUp] public void Init() {
			entityManager = new EntityManager();
		}

		[Test()] public void TestCanBuild() {
			entityManager.Build("shawn");
		}
	}
}

