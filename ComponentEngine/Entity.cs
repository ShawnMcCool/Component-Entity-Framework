using System;
using System.Collections.Generic;

namespace ComponentEngine
{
	public class Entity
	{
		private List<Component> components = new List<Component>();

		public void AddComponent(Component component) {
			components.Add(component);
		}
		public T GetComponent<T>() {
			foreach (var component in components) {
				if (component is T)
					return (T)(object) component;
			}
			return default(T);
		}
	}
}

