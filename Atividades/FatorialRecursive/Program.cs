class Program
{
    public static void Main()
    {
        int fact, num;
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        if (!Int32.TryParse(input, out num))
        {
            Console.WriteLine("Numero inválido.");
            return;
        }
        Program obj = new Program();

        // calling recursive function   
        fact = factorial(num);

        Console.WriteLine("Factorial of {0} is {1}", num, fact);
    }

    // recursive function 
    static int factorial(int num)
    {
        // termination condition
        if (num == 0)
            return 1;
        else
        {
            Console.Write($"{num} * ");
            // recursive call
            return num * factorial(num - 1);
        }
    }
}