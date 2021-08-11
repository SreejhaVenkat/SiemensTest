using Microsoft.VisualStudio.TestTools.UnitTesting;
using SiemensTest;

namespace TestProject1
{
    [TestClass]
    public class PlatformTypeTests
    {
        [TestMethod]
        [DataRow("Windows", "Hi, I am from Windows")]
        [DataRow("Android", "Hi, I am from Android")]
        [DataRow("iOS", "Hi, I am from iOS")]
        [DataRow("", "")]
        public void GetMessage_MultipleInputs_ReturnsOutput(string testInput, string expectedOutput)
        {

            var platFormClass = new PlatformType();

            var message = platFormClass.GetMessage(testInput);
            Assert.AreEqual(expectedOutput, message);

        }


    }

}
