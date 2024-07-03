

namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {

            string test1 = "csharp is programming language";
            Console.WriteLine($"Input: {test1}");
            Console.WriteLine($"Output: {ReverseWords(test1)}");

            Console.WriteLine("======================================================");

            string test2 = "Reverse the words in this sentence";
            Console.WriteLine($"Input: {test2}");
            Console.WriteLine($"Output: {ReverseWords(test2)}");

            Console.WriteLine("======================================================");

            string test3 = "challenges and data structures";
            Console.WriteLine($"Input: {test3}");
            Console.WriteLine($"Output: {ReverseWords(test3)}");

            Console.ReadKey();

        }

        public static string ReverseWords(string words)
        {
            if (string.IsNullOrEmpty(words)) return "";


            string[] ArrayOfWords = words.Split(" ");
            int ArrayLength = ArrayOfWords.Length;

            string[] ReversedWords = new string[ArrayLength];

            for (int i = 0; i < ArrayLength; i++) 
                ReversedWords[ArrayLength - i -1] = ArrayOfWords[i];
            
            return string.Join(" ", ReversedWords);
        }


    }

}
