using System;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;

namespace ComponentEngine
{
    public class EntityBuilder
    {
        String prefabPath;

        public EntityBuilder(String prefabPath) {
            this.prefabPath = prefabPath;
        }

        public Entity Build(String name) {
            Entity entity = new Entity(name);
            foreach (var component in getPrefabComponents(getPrefabDefinition(name)))
                entity.AddComponent(component);
            return entity;
        }

        XmlNode getPrefabDefinition(string name) {
            XmlNode prefabDefinition = getPrefabDoc().SelectSingleNode(name);
            if (prefabDefinition == null) 
                throw new EntityNotFoundInDefinition();
            return prefabDefinition;
        }

        List<Component> getPrefabComponents(XmlNode prefabDefinition) {
            var components = new List<Component>();
            foreach (XmlNode componentNode in prefabDefinition.ChildNodes)
                components.Add(new Component(getComponentArguments(componentNode)));
            return components;
        }

        ComponentArguments getComponentArguments(XmlNode node) {
            var arguments = new ComponentArguments();
            foreach (XmlAttribute attr in node.Attributes)
                arguments.Add(attr.Name, attr.Value);
            return arguments;
        }

        XmlDocument getPrefabDoc() {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(getPrefabXml());
            return doc;
        }

        string getPrefabXml() {
            return System.IO.File.ReadAllText(prefabPath);
        }
    }
}

