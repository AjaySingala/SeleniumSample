using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestSample
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestFoo()
        {
            // Arrange
            var name = "Ajay Singala";
            var expected = "AJAY";

            // Act
            var result = name.Substring(0, 4).ToUpper();

            // Assert
            Assert.AreEqual<string>(expected, result);
        }
    }
}
