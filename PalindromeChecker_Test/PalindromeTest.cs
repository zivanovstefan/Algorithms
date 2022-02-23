using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace PalindromeChecker_Test
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void Check_IsPalindrome_True()
        {
            //Arrange
            var word = "abba";
            var expectedResult = true;
            //Act
            var actualResult = new PalindromeChecker().Check(word);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Check_IsPalindrome_False()
        {
            //Arrange
            var word = "palindrome";
            var expectedResult = false;
            //Act
            var actualResult = new PalindromeChecker().Check(word);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}