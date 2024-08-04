

//using challenges_and_data_structures.Data_Structures.LinkedList;
//using Xunit;


//namespace ChallengesTests
//{
//    public class MergeSortedLinkedListsTests
//    {
   

//        [Fact]
//        public void TestMergingWhenOneListIsEmpty()
//        {
//            var list1 = CreateLinkedList(1, 3, 5);
//            var list2 = new LinkedList(); // Empty list

//            var mergedList = LinkedList.MergeSortedLists(list1, list2);

//            Assert.Equal("Head -> 1 -> 3 -> 5 -> Null", LinkedListToString(mergedList));
//        }

//        [Fact]
//        public void TestMergingWhenBothListsAreEmpty()
//        {
//            var list1 = new LinkedList(); // Empty list
//            var list2 = new LinkedList(); // Empty list

//            var mergedList = LinkedList.MergeSortedLists(list1, list2);

//            Assert.Equal("Head -> Null", LinkedListToString(mergedList));
//        }

//        [Fact]
//        public void TestMergingExampleLists()
//        {
//            var list1 = CreateLinkedList(2, 5, 10);
//            var list2 = CreateLinkedList(3, 15, 20);

//            var mergedList = LinkedList.MergeSortedLists(list1, list2);

//            Assert.Equal("Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null", LinkedListToString(mergedList));
//        }

//        private LinkedList CreateLinkedList(params int[] values)
//        {
//            var list = new LinkedList();
//            foreach (var value in values)
//            {
//                list.Add(value);
//            }
//            return list;
//        }

//        private string LinkedListToString(LinkedList list)
//        {
//            Node current = list.Head;
//            string result = "Head";
//            while (current != null)
//            {
//                result += $" -> {current.Data}";
//                current = current.Next;
//            }
//            result += " -> Null";
//            return result;
//        }
//    }
//}