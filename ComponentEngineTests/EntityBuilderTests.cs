using NUnit.Framework;
using System;
using ComponentEngine;

namespace ComponentsTests
{
    [TestFixture()]
    public class EntityBuilderTests
    {
        EntityBuilder entityBuilder;

        [SetUp] public void Init() {
            entityBuilder = new EntityBuilder("XML/Prefabs.xml");
        }

        [Test()] public void TestCanBuild() {
            entityBuilder.Build("shawn");
        }
    }
}

