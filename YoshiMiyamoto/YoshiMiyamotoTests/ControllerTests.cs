using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YoshiMiyamoto.Tests
{
    [TestClass()]
    public class ControllerTests
    {
        private string filePath = @"../test2.txt";

        [TestMethod()]
        public void requestFileContentsTest()
        {
            Controller controller = new Controller(filePath);
            string result = controller.requestFileContents();
            Assert.AreEqual("6;3;4;Multiplication\n1;2;3;Addition\n2;1;1;Division\n", result);
        }

        [TestMethod()]
        public void requestProcessTest()
        {
            Controller controller = new Controller(filePath);
            double[] result = controller.requestProcess();
            double[] expected = new double[] { 72, 6, 2 };
            CollectionAssert.AreEqual(expected,result);
        }
    }
}