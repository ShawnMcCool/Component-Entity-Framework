using System;

namespace ComponentEngine
{
    public class Component
    {
        bool hasBooted = false;

        public Component(ComponentArguments arguments) {}

        virtual public void Boot() {
            hasBooted = true;
        }

        public bool HasBooted() {
            return hasBooted;
        }

        virtual public void Update() {
            if (! hasBooted)
                throw new ComponentNotBooted();
        }
    }
}

