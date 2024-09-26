namespace week2
{
    public class TypeConversion(double d) : ConversionOperations(d)
    {
        public double D { get; } = d;

        public override void DemoTypeConversion()
        {
            int DD = (int)D;
            double ddd = DD;
            Console.WriteLine($"Explicit conversion: {DD}");
            Console.WriteLine($"Implicit conversion: {ddd}");

            bool isInteger = false;
            while (!isInteger)
            {
                try
                {
                    Console.WriteLine("Please enter a valid integer");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int inputInt))
                    {
                        Console.WriteLine($"Successfully converted to integer {inputInt}");
                        isInteger = true;
                    }
                    else
                    {
                        int inputToInt32 = Convert.ToInt32(input);
                        Console.WriteLine(inputToInt32);
                        throw new ArgumentException();
                    }
                }
                catch
                {
                    Console.WriteLine("That is not a valid integer, please try again.");
                }
            }
        }
    }

    public abstract class ConversionOperations(double d)
    {
        public double D { get; } = d;
        public abstract void DemoTypeConversion();
    }
}
