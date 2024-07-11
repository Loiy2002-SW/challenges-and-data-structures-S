

using challenges_and_data_structures.Data_Structures.LinkedList;

namespace ChallengesTests
{
    public class UnitTest1
    {


        //Linked list tests:
        [Fact]
        public void Remove_NodeFromEnd_RemovesCorrectNode()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Head = new Node(1) { Next = new Node(2) { Next = new Node(3) { Next = new Node(4) } } };

            // Act
            list.Remove(4);

            // Assert
            var current = list.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Assert.Equal(3, current.Data);
        }

        [Fact]
        public void PrintList_PrintsCorrectly()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Head = new Node(1) { Next = new Node(2) { Next = new Node(3) { Next = new Node(4) } } };

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                list.PrintList();
                var result = sw.ToString().Trim();

                // Assert
                Assert.Equal("Head -> 1 -> 2 -> 3 -> 4 -> Null", result);
            }
        }

        //[Fact]
        //public void TestSingleWord()
        //{
        //    string input = "Hello";
        //    string expectedOutput = "Hello";
        //    string actualOutput = Program.ReverseWords(input);
        //    Assert.Equal(expectedOutput, actualOutput);
        //}

        //[Fact]
        //public void ReverseWords_WithMultipleWords_ReturnsWordsInReverseOrder()
        //{
        //    // Arrange
        //    string input = "Hello World";
        //    string expected = "World Hello";

        //    // Act
        //    string actual = Program.ReverseWords(input);

        //    // Assert
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void ReverseWords_WithNullInput_ReturnsEmptyString()
        //{
        //    // Arrange
        //    string input = null;
        //    string expected = "";

        //    // Act
        //    string actual = Program.ReverseWords(input);

        //    // Assert
        //    Assert.Equal(expected, actual);
        //}

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