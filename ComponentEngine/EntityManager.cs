using System;
using System.Xml;

namespace ComponentEngine
{
    public class EntityManager
    {
        public Entity Build(String name) {
            // read prefabs file
            String prefabs = System.IO.File.ReadAllText("XML/Prefabs.xml");

            // parse prefabs xml
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(prefabs);

            // parse out entity name
            XmlNode prefabDefinition = doc.SelectSingleNode(name);
            if (prefabDefinition == null) 
                throw new EntityNotFoundInDefinition();

            Entity entity = new Entity(name);

            foreach (XmlNode componentNode in prefabDefinition.ChildNodes) {
                var componentArguments = new ComponentArguments();
                XmlAttributeCollection attributes = componentNode.Attributes;
                foreach (XmlAttribute attr in attributes) {
                    componentArguments.Add(attr.Name, attr.Value);
                }
                entity.AddComponent(new Component(componentArguments));
            }

            return entity;
        }
    }
}

