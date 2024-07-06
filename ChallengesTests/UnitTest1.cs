

namespace ChallengesTests
{
    public class UnitTest1
    {

        [Fact]
        public void TestSingleWord()
        {
            string input = "Hello";
            string expectedOutput = "Hello";
            string actualOutput = Program.ReverseWords(input);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void ReverseWords_WithMultipleWords_ReturnsWordsInReverseOrder()
        {
            // Arrange
            string input = "Hello World";
            string expected = "World Hello";

            // Act
            string actual = Program.ReverseWords(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseWords_WithNullInput_ReturnsEmptyString()
        {
            // Arrange
            string input = null;
            string expected = "";

            // Act
            string actual = Program.ReverseWords(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        // These for Challenge 6 A
        //[Fact]
        //public void CommonElements_ShouldReturnCommonElements()
        //{
        //    // Arrange
        //    int[] array1 = { 1, 2, 3, 4, 5 };
        //    int[] array2 = { 3, 4, 5, 6, 7 };

        //    // Act
        //    int[] result = Program.CommonElements(array1, array2);

        //    // Assert
        //    int[] expected = { 3, 4, 5 };
        //    Assert.Equal(expected, result);
        //}

        //[Fact]
        //public void CommonElements_ShouldReturnEmptyArray_WhenNoCommonElements()
        //{
        //    // Arrange
        //    int[] array1 = { 1, 2, 3 };
        //    int[] array2 = { 4, 5, 6 };

        //    // Act
        //    int[] result = Program.CommonElements(array1, array2);

        //    // Assert
        //    int[] expected = { };
        //    Assert.Equal(expected, result);
        //}
    }
}