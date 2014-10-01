using System;
using System.Collections.Generic;

namespace ComponentEngine
{
	public class Entity
	{
		private String type;
		private List<IComponent> components = new List<IComponent>();

		public Entity(String type) {
			this.type = type;
		}

		public void AddComponent(IComponent component) {
			components.Add(component);
		}

		public T GetComponent<T>() {
			foreach (var component in components)
				if (component is T)
					return (T)(object) component;
			return default(T);
		}

		public void Boot() {
			components.ForEach(c => c.Boot());
		}

		public void Update() {
			components.ForEach(c => c.Update());
		}
	}
}

