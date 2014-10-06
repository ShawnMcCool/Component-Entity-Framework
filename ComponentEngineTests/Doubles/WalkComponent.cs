using System;
using ComponentEngine;

namespace ComponentsTests
{
    public class WalkComponent : Component
    {
        private float speed = 20f;

        override public void SetArguments(ComponentArguments arguments) {
            speed = float.Parse(arguments.Get("speed"));
        }

        override public void Update() {
            if (! HasBooted)
                throw new ComponentNotBooted();
        }
    }
}

