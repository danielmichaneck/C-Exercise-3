using Persons;

namespace Tests
{
    [TestClass]
    public class EncapsulationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var personHandler = new PersonHandler();
            var personHandler2 = new PersonHandler();

            // Act
            personHandler.CreatePerson(10, "asdf", "hjkl", 0, 0);
            personHandler2.CreatePerson(10, "asdf", "hjkl", 0, 0);

            // Assert
            Assert.AreEqual(personHandler, personHandler2);
        }
    }
}