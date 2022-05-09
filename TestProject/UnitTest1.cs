using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsoleApp.TechnicalTests;

namespace TestProject
{
    [TestClass]
    public class StringOperationTests
    {
        [TestMethod]
        public void ReverseStringBasicTest()
        {
            StringOperations stringOperations = new StringOperations();
            string reversedString = stringOperations.ReverseString("The fox jumped over the wall");

            Assert.AreEqual("llaw eht revo depmuj xof ehT", reversedString);
        }

        [TestMethod]
        public void ReverseStringWithNumbersTest()
        {
            StringOperations stringOperations = new StringOperations();
            string reversedString = stringOperations.ReverseString("20 foxes jumped over the wall, only 10 got over");

            Assert.AreEqual("revo tog 01 ylno ,llaw eht revo depmuj sexof 02", reversedString);
        }

        [TestMethod]
        public void ReverseStringWithSpecialCharactersTest()
        {
            StringOperations stringOperations = new StringOperations();
            string reversedString = stringOperations.ReverseString("The @fox jumped over the wall! Where?");

            Assert.AreEqual("?erehW !llaw eht revo depmuj xof@ ehT", reversedString);
        }
    }
}