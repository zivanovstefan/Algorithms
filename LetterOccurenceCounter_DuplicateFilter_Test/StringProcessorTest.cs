using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace LetterOccurenceCounter_DuplicateFilter_Test
{
    [TestClass]
    public class StringProcessorTest
    {
        [TestMethod]
        public void Process_StringProcessing_ReturnResultForLetterOccurenceCounter()
        {
            //Arrange
            string word = "testword";
            string option = "a";
            var expectedResult = new LetterOccurrenceCounter().Count(word);
            //Act
            var actualResult = new StringProcessor().OptionProcess(word, option);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Process_StringProcessing_ReturnResultForDuplicateFilter()
        {
            //Arrange
            string word = "teestwooord";
            string option = "b";
            var expectedResult = new DuplicateFilter().Filter(word);
            //Act
            var actualResult = new StringProcessor().OptionProcess(word, option);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Process_StringProcessing_ReturnErrorMessage()
        {
            //Arrange
            string word = "testword";
            string option = "c";
            var expectedResult = "Your choice is not valid";
            //Act
            var actualResult = new StringProcessor().OptionProcess(word, option);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}