using System;
using System.Xml;

namespace ComponentEngine
{
	public class EntityManager
	{
		public EntityManager() {}

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

			}


			return entity;
		}
	}
}

