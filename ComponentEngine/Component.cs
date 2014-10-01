using System;

namespace ComponentEngine
{
	public class Component : IComponent
	{
		bool hasBooted = false;

		public void Boot() {
			hasBooted = true;
		}

		public bool HasBooted() {
			return hasBooted;
		}

		public void Update() {
			if (! hasBooted)
				throw new ComponentNotBooted();
		}

	}
}

