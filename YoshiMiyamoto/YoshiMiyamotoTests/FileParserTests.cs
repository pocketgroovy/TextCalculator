using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YoshiMiyamoto.Tests
{
    [TestClass()]
    public class FileParserTests
    {
        private string filePath = @"../test2.txt";

        [TestMethod()]
        public void getLinesTest()
        {
            FileParser parser = new FileParser(filePath);
            string[] result = parser.getLines();

            Assert.AreEqual("6;3;4;Multiplication",result[0]);
        }

        [TestMethod()]
        public void getContentsTest()
        {
            FileParser parser = new FileParser(filePath);
            string result = parser.getContents();

            Assert.AreEqual("6;3;4;Multiplication\n1;2;3;Addition\n2;1;1;Division\n", result);
        }
    }
}