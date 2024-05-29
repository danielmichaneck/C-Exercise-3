using Persons;

namespace Tests
{
    public class EncapsulationTests
    {
        [Fact]
        public void Should_Create_Person()
        {
            var personHandler = new PersonHandler();
            bool expected = true;
            try
            {
                var person = personHandler.CreatePerson(30, "Arthas", "Menethil", 190, 90);
            }
            catch
            {
                expected = false;
            }
            Assert.True(expected);
        }

        [Fact]
        public void Should_Create_Person_Directly()
        {
            Person person;
            bool expected = true;
            try
            {
                person = new Person("Orgrim Doomhammer");
            }
            catch
            {
                expected = false;
            }
            Assert.True(expected);
        }

        [Fact]
        public void Should_NOT_Create_Person_Null_Last_Name()
        {
            var personHandler = new PersonHandler();
            bool expected = true;
            try
            {
                var person = personHandler.CreatePerson(100, "Thrall", "", 200, 100);
            }
            catch
            {
                expected = false;
            }
            Assert.False(expected);
        }

        [Fact]
        public void Should_NOT_Create_Person_Too_Long_Last_Name()
        {
            var personHandler = new PersonHandler();
            bool expected = true;
            try
            {
                var person = personHandler.CreatePerson(60, "Tyrande", "Whisperwind", 210, 120);
            }
            catch
            {
                expected = false;
            }
            Assert.False(expected);
        }

        [Fact]
        public void Should_NOT_Create_Person_Too_Short_First_Name()
        {
            var personHandler = new PersonHandler();
            bool expected = true;
            try
            {
                var person = personHandler.CreatePerson(10, "A", "BC", 10, 10);
            }
            catch
            {
                expected = false;
            }
            Assert.False(expected);
        }

        [Fact]
        public void Should_NOT_Create_Person_Too_Young()
        {
            var personHandler = new PersonHandler();
            bool expected = true;
            try
            {
                var person = personHandler.CreatePerson(-1, "Anduin", "Wrynn", 1, 2);
            }
            catch
            {
                expected = false;
            }
            Assert.False(expected);
        }
    }
}