using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Inheritance;

namespace Tests
{
    public class InheritanceTests
    {
        [Fact]
        public void Should_Create_Flamingo_Correctly()
        {
            // Arrange
            var maybeFlamingo = new Flamingo();

            // Act
            StringBuilder expected = new(
                    "Name: Flamingo" + Environment.NewLine +
                    "Weight: 5" + Environment.NewLine +
                    "Age: 10" + Environment.NewLine +
                    "Can fly: True" + Environment.NewLine +
                    "Leg length: 100" + Environment.NewLine);
            // Assert
            Assert.Equal(expected.ToString(), maybeFlamingo.BirdProperties.ToString());
        }
    }
}
