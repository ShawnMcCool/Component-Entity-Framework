using NUnit.Framework;
using System;
using System.Collections.Generic;
using ComponentEngine;
using Moq;

namespace ComponentsTests
{
	[TestFixture()]
	public class EntityTests
	{
		Entity entity;
		Mock<IComponent> mockComponent;

		[SetUp] public void Init() {
			entity = new Entity("testEntity");
			mockComponent = new Mock<IComponent>();
		}

		[Test()] public void TestCanCreate() {
			Assert.IsInstanceOf<Entity>(entity);
		}

		[Test()] public void TestCanAddComponent() {
			entity.AddComponent(mockComponent.Object);

			Assert.IsInstanceOf<IComponent>(entity.GetComponent<IComponent>());
		}

		[Test()] public void TestCanBootComponents() {
			entity.AddComponent(mockComponent.Object);
			entity.Boot();

			mockComponent.Verify(component => component.Boot(), Times.Once());
		}

		[Test()] public void TestCanUpdateComponents() {
			entity.AddComponent(mockComponent.Object);
			entity.Boot();
			entity.Update();
			entity.Update();

			mockComponent.Verify(component => component.Update(), Times.Exactly(2));
		}
	}
}

