using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunit;
using NUnit.Framework;

namespace Blazor.Test
{
    class MyComponentTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ComponentTest()
        {
            // Arrange
            using var context = new Bunit.TestContext();
            string expectedMarkup = "<h3>MyComponent</h3>";

            // Act
            var currentContext = context.RenderComponent<BlazorApp1.MyComponent>();

            // Assert
            currentContext.MarkupMatches(expectedMarkup);
        }

        [Test]
        public void ComponentFailCaseTest()
        {
            // Arrange
            using var context = new Bunit.TestContext();
            string expectedMarkup = "<h3>NotMyComponent</h3>";

            // Act
            var currentContext = context.RenderComponent<BlazorApp1.MyComponent>();

            // Assert
            currentContext.MarkupMatches(expectedMarkup);
        }
    }
}
