namespace week2
{
    public class ListOperations
    {
        List<int> myList = new List<int> { 1, 3, 5, 7, 9 };

        public void InsertItems()
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
                    int userInput = Int32.Parse(input);
                    myList.Add(userInput);
                    DisplayList();
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid integer");
                }
            }
        }

        public void DeleteItems()
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

        public void SearchItem()
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
                    int indexOf = myList.IndexOf(userInput);
                    bool isIndex = myList.IndexOf(userInput) != -1;
                    if (isIndex)
                    {
                        // int indexOfInput = myList.FindIndex(userInput);
                        Console.WriteLine($"{userInput} is at index {indexOf}");
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

        private void DisplayList()
        {
            Console.WriteLine($"The current list is: ");
            Console.WriteLine($"[{string.Join(", ", myList)}]");
        }
    }
}
