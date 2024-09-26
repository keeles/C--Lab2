namespace week2
{
    public class MathOperations(int integerOne, int integerTwo)
    {
        public int IntegerOne { get; } = integerOne;
        public int IntegerTwo { get; } = integerTwo;
        public int result;

        public void CalculateProductWithOverflow()
        {
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    unchecked
                    {
                        var result = (int a, int b) => a + b;
                        if (result(IntegerOne, IntegerTwo) < 0)
                        {
                            Console.WriteLine(
                                $"Unchecked result: {result(IntegerOne, IntegerTwo).ToString()} (Overflow occurred)"
                            );
                        }
                        else
                        {
                            Console.WriteLine(
                                $"Unchecked result: {result(IntegerOne, IntegerTwo).ToString()}"
                            );
                        }
                    }
                    checked
                    {
                        var result = (int IntegerOne, int IntegerTwo) => IntegerOne + IntegerTwo;
                        Console.WriteLine(
                            $"Checked result: {result(IntegerOne, IntegerTwo).ToString()}"
                        );
                    }
                    isValid = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Overflow occurred");
                    isValid = true;
                }
            }
        }
    }
}
