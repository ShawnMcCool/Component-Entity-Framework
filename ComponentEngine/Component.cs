using System;

namespace ComponentEngine
{
    public class Component
    {
        public Component() {}

        virtual public void SetArguments(ComponentArguments arguments) {}

        virtual public void Boot() {
            HasBooted = true;
        }

        public bool HasBooted {
            get;
            set;
        }

        virtual public void Update() {
            if (! HasBooted)
                throw new ComponentNotBooted();
        }
    }
}

