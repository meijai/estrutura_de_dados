namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"The factorial of {x} is {factorial(x)}");
            Console.ReadKey();
        }

        static int factorial(int number)
        {
            if (number == 1)
            {
                return (1); /* exiting condition */
            }
            else
            {
                return (number * factorial(number - 1));
            }
        }
    }
}