namespace week2 {

    public class TypeConversion {
        public static void DemoTypeConversion() {
            double d = 345.67;
            int dd = (int)d;
            double ddd = dd;
            Console.WriteLine($"Explicit conversion: {dd}");
            Console.WriteLine($"Implicit conversion: {ddd}");

            bool isInteger = false;
            while (!isInteger) {
            try {
            Console.WriteLine("Please enter a valid integer");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int inputInt)) {
            Console.WriteLine($"Successfully converted to integer {inputInt}");
            isInteger = true;
            } else {
                int inputToInt32 = Convert.ToInt32(input);
                Console.WriteLine(inputToInt32);
                throw new ArgumentException();
            }
            } catch {
                Console.WriteLine("That is not a valid integer, please try again.");
            }
            }
        }
    }
}