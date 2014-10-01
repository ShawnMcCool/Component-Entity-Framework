using System;

namespace ComponentEngine
{
	public interface IComponent
	{
		void Boot();
		bool HasBooted();
		void Update();
	}
}

