using NUnit.Framework;
using System;
using ComponentEngine;

namespace ComponentsTests
{
    [TestFixture()]
    public class ComponentArgumentsTests
    {
        ComponentArguments arguments;

        [SetUp] public void Init() {
            arguments = new ComponentArguments();
        }

        [Test()] public void TestCanCreate() {
            Assert.IsInstanceOf<ComponentArguments>(new ComponentArguments());
        }

        [Test()] public void TestCanAddArguments() {
            arguments.Add("foo", "bar");
            Assert.AreSame("bar", arguments.Get("foo"));
        }

        [Test()] public void TestThrowsWhenRequestingUnavailableArgument() {
            Assert.Throws<ComponentArgumentNotFound>(
                () => arguments.Get("foo")
            );
        }
    }
}

