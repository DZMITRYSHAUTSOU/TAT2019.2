using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dev_2.tests
{
    [TestClass]
    public class StringAnalyzerTests
    {
        #region RepetitiveOnlyMethod
        [TestMethod]
        public void RepetitiveString_aaaa_result_true()
        {
            //Arrange
            string testString = "aaaa";
            StringAnalyzer analyzer = new StringAnalyzer("");

            //Act
            bool result = analyzer.IsSequenceRepetitiveOnly(testString);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RepetitiveString_aaab_result_false()
        {
            //Arrange
            string testString = "aaab";
            StringAnalyzer analyzer = new StringAnalyzer("");

            //Act
            bool result = analyzer.IsSequenceRepetitiveOnly(testString);

            //Assert
            Assert.IsFalse(result);
        }
        #endregion

        #region UniqueOnlyMethod
        [TestMethod]
        public void UniqueString_abcd_result_true()
        {
            //Arrange
            string testString = "abcd";
            StringAnalyzer analyzer = new StringAnalyzer("");

            //Act
            bool result = analyzer.IsSequenceUniqueOnly(testString);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UniqueString_abcc_result_false()
        {
            //Arrange
            string testString = "abcc";
            StringAnalyzer analyzer = new StringAnalyzer("");

            //Act
            bool result = analyzer.IsSequenceUniqueOnly(testString);

            //Assert
            Assert.IsFalse(result);
        }
        #endregion

        #region LongestUniqueSubstringMethod
        [TestMethod]
        public void LongestUniqueSubstring_aaaa_result_a()
        {
            //Arrange
            string testString = "aaaa";
            string expected = "a";
            StringAnalyzer analyzer = new StringAnalyzer(testString);

            //Act
            string result = analyzer.GetUniqueSymbolSequence();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LongestUniqueSubstring_aaba_result_ab()
        {
            //Arrange
            string testString = "aaba";
            string expected = "ab";
            StringAnalyzer analyzer = new StringAnalyzer(testString);

            //Act
            string result = analyzer.GetUniqueSymbolSequence();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LongestUniqueSubstring_abcd_result_abcd()
        {
            //Arrange
            string testString = "abcd";
            string expected = "abcd";
            StringAnalyzer analyzer = new StringAnalyzer(testString);

            //Act
            string result = analyzer.GetUniqueSymbolSequence();

            //Assert
            Assert.AreEqual(expected, result);
        }
#endregion

        #region LongestRepetitiveDigitSubstringMethod
        [TestMethod]
        public void LongestRepetitiveDigitSubstring_aaaa_result_StringEmpty()
        {
            //Arrange
            string testString = "aaaa";
            string expected = "";
            StringAnalyzer analyzer = new StringAnalyzer(testString);

            //Act
            string result = analyzer.GetRepetitiveDigitSequence();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LongestRepetitiveDigitSubstring_1121_result_1111()
        {
            //Arrange
            string testString = "1121";
            string expected = "11";
            StringAnalyzer analyzer = new StringAnalyzer(testString);

            //Act
            string result = analyzer.GetRepetitiveDigitSequence();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LongestRepetitiveDigitSubstring_1111_result_1111()
        {
            //Arrange
            string testString = "1111";
            string expected = "1111";
            StringAnalyzer analyzer = new StringAnalyzer(testString);

            //Act
            string result = analyzer.GetRepetitiveDigitSequence();

            //Assert
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region LongestRepetitiveLetterSubstringMethod
        [TestMethod]
        public void LongestRepetitiveLetterSubstring_1111_result_StringEmpty()
        {
            //Arrange
            string testString = "1111";
            string expected = "";
            StringAnalyzer analyzer = new StringAnalyzer(testString);

            //Act
            string result = analyzer.GetRepetitiveLetterSequence();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LongestRepetitiveLetterSubstring_aaaa_result_aaaa()
        {
            //Arrange
            string testString = "aaaa";
            string expected = "aaaa";
            StringAnalyzer analyzer = new StringAnalyzer(testString);

            //Act
            string result = analyzer.GetRepetitiveLetterSequence();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LongestRepetitiveLetterSubstring_aaaba_result_aaa()
        {
            //Arrange
            string testString = "aaaba";
            string expected = "aaa";
            StringAnalyzer analyzer = new StringAnalyzer(testString);

            //Act
            string result = analyzer.GetRepetitiveLetterSequence();

            //Assert
            Assert.AreEqual(expected, result);
        }
        #endregion
    }
}