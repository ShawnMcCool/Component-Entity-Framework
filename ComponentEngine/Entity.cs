using System;
using System.Linq;
using System.Collections.Generic;

namespace ComponentEngine
{
    public class Entity
    {
        String type;
        List<Component> components = new List<Component>();

        public Entity(String type) {
            this.type = type;
        }

        public String Type { 
            get { return type; }
        }

        public void AddComponent(Component component) {
            components.Add(component);
        }

        public T GetComponent<T>() {
            foreach (var component in components)
                if (component is T)
                    return (T)(object)component;
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

