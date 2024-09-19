namespace week2 {
public class MathOperations {
    public static void CalculateProductWithOverflow() {
        bool isValid = false;
        while (!isValid) {
            try {
                        Console.WriteLine("Enter first number");
        string firstString = Console.ReadLine();
        int firstInt = int.Parse(firstString);
        Console.WriteLine("Enter second number");
        string secondString = Console.ReadLine();
        int secondInt = int.Parse(secondString);
        unchecked
        {
        int result = firstInt + secondInt;
        if (result<0) {
            Console.WriteLine($"Unchecked result: {result.ToString()} (Overflow occurred)");
        } else {
        Console.WriteLine($"Unchecked result: {result.ToString()}");
        }
        }
        checked
        {
        int result = firstInt + secondInt;
        Console.WriteLine($"Checked result: {result.ToString()}");
        }
        isValid = true;
        } catch (OverflowException) {
            Console.WriteLine($"Overflow occurred");
        }
        }
    }
}   
    
}
