using NUnit.Framework;
using System;
using ComponentEngine;

namespace ComponentsTests
{
    [TestFixture()]
    public class ComponentTests
    {
        Component component;

        [SetUp] public void Init() {
            component = new Component();
        }

        [Test()] public void TestCanCreate() {
            Assert.IsInstanceOf<Component>(component);
        }

        [Test()] public void TestCanBoot() {
            Assert.IsFalse(component.HasBooted);
            component.Boot();
            Assert.IsTrue(component.HasBooted);
        }

        [Test()] public void TestCanNotUpdateWithoutBoot() {
            Assert.Throws<ComponentNotBooted>(
                () => component.Update()
            );
        }
    }
}

