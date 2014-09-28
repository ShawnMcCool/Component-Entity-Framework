using System;

namespace ComponentEngine
{
	public interface Component
	{
		void Boot();
		bool HasBooted();
		void Update();
	}
}

