namespace week2
{
    public class ListOperations(List<int> list) : ListBaseOperations(list)
    {
        List<int> myList = list;

        public override void InsertItems()
        {
            string status = "Not Done";
            while (status != "Done")
            {
                DisplayList();
                Console.WriteLine("Give me some integers to add to my list.");
                string input = Console.ReadLine();
                try
                {
                    if (input == "Done")
                    {
                        status = "Done";
                        return;
                    }
                    var userInput = (string input) => Int32.Parse(input);
                    myList.Add(userInput(input));
                    DisplayList();
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid integer");
                }
            }
        }

        public override void DeleteItems()
        {
            string status = "Not Done";
            while (status != "Done")
            {
                DisplayList();
                Console.WriteLine("Please type the value you would like to remove.");
                string input = Console.ReadLine();
                try
                {
                    if (input == "Done")
                    {
                        status = "Done";
                        return;
                    }
                    int userInput = Int32.Parse(input);
                    bool indexOf = myList.IndexOf(userInput) != -1;
                    if (indexOf)
                    {
                        myList.Remove(userInput);
                        Console.WriteLine($"Removed item {userInput} from list");
                    }
                    else
                    {
                        Console.WriteLine($"Integer {userInput} was not in the list.");
                    }
                    DisplayList();
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid integer");
                }
            }
        }

        public override void SearchItem()
        {
            string status = "Not Done";
            while (status != "Done")
            {
                DisplayList();
                Console.WriteLine("Please type the value you would like to know the index of.");
                string input = Console.ReadLine();
                try
                {
                    if (input == "Done")
                    {
                        status = "Done";
                        return;
                    }
                    int userInput = Int32.Parse(input);
                    var indexOf = (int input) => myList.IndexOf(input);
                    int index = indexOf(userInput);
                    // bool isIndex = myList.IndexOf(userInput) != -1;
                    if (index != -1)
                    {
                        // int indexOfInput = myList.FindIndex(userInput);
                        Console.WriteLine($"{userInput} is at index {indexOf(userInput)}");
                    }
                    else
                    {
                        Console.WriteLine($"Integer {userInput} was not in the list.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid integer");
                }
            }
        }

        public override void DisplayList()
        {
            Console.WriteLine($"The current list is: ");
            Console.WriteLine($"[{string.Join(", ", myList)}]");
        }
    }

    public abstract class ListBaseOperations(List<int> list)
    {
        List<int> myList = list;
        public abstract void InsertItems();
        public abstract void SearchItem();
        public abstract void DeleteItems();
        public abstract void DisplayList();
    }
}
