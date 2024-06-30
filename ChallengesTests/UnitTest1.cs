

namespace ChallengesTests
{
    public class UnitTest1
    {
        [Fact]
        public void CommonElements_ShouldReturnCommonElements()
        {
            // Arrange
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] result = Program.CommonElements(array1, array2);

            // Assert
            int[] expected = { 3, 4, 5 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CommonElements_ShouldReturnEmptyArray_WhenNoCommonElements()
        {
            // Arrange
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };

            // Act
            int[] result = Program.CommonElements(array1, array2);

            // Assert
            int[] expected = { };
            Assert.Equal(expected, result);
        }
    }
}