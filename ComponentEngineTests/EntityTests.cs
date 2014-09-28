using NUnit.Framework;
using System;
using System.Collections.Generic;
using ComponentEngine;

namespace ComponentsTests
{
	[TestFixture()]
	public class EntityTests
	{
		[Test()]
		public void TestCanCreate() {
			Assert.IsInstanceOf<Entity>(new Entity());
		}

		[Test()]
		public void TestCanAddComponent() {
			var entity = new Entity();
			entity.AddComponent(new Component());
			entity.GetComponent<Component>();
		}
	}

//	class Entity {
//		List<Component> components = new List<Component>();
//		public void AddComponent(Component component) {
//			component.BindEntity(this);
//			components.Add(component);
//		}
//		public Component GetComponent(String name) {
//			foreach (Component component in components)
//				if (component.Name == name)
//					return component;
//			return null;
//		}
//	}

//	class Component {
//		Entity entity;
//		public void BindEntity(Entity entity) {
//			this.entity = entity;
//		}
//		public String Name {
//			get { return "Component"; }
//		}
//	}
}

