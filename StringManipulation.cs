using System.Text;

namespace Lab2 {
    public class StringManipulation {
        public void DemoStringOperations() {
            string str = "Hello";
            string newStr = " World";
            string newerStr = " from C#";
            Console.WriteLine(str);
            Console.WriteLine(str + newStr);
            Console.WriteLine(str + newStr + newerStr);

            string mutStr = "StringBuilder Content: Hello";
            StringBuilder s1 = new StringBuilder(mutStr);
            Console.WriteLine(s1);
            s1.Append(" World");
            Console.WriteLine(s1);
            s1.Append(" from C#");
            Console.WriteLine(s1);
        }

        public void ReverseWordsInString() {
            Console.WriteLine("Give me a sentence and I will reverse it:");
            string sentence = Console.ReadLine();

            List<string> myList = new List<string>(sentence.Split(" ").Reverse());
            string result = String.Join(" ", myList.ToArray());
            Console.WriteLine(result);
        }
    }
}