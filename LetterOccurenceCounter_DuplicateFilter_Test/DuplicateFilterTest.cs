using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace LetterOccurenceCounter_DuplicateFilter_Test
{
    [TestClass]
    public class DuplicateFilterTest
    {
        [TestMethod]
        public void Filter_DuplicateFilter_ReturnFilteredString()
        {
            //Arrange
            var str = "aaaaabbccc";
            var expectedResult = "abc";
            //Act
            var actualResult = new DuplicateFilter().Filter(str);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}