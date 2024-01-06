using System.Numerics;

namespace ExtraLongFactorial;

class Program
{
    static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(findFactorialRecursive(input));
        Console.WriteLine(findFactorialIterative(input));
        Console.WriteLine(findFactorialRecursiveTwo(input));
    }

    public static int findFactorialRecursiveTwo(int number)
    {
        if(number == 2) return 2;
        return findFactorialRecursiveTwo(number -1)  * number;
    }

    public static int findFactorialRecursive(int number)
    {
        int counter = number;
        return helper(number, counter);
    }

    private static int helper(int number, int counter)
    {
        while(counter > 1)
        {
            counter--;
            number *= counter;
            helper(number, counter);
        }
        return number; 
    }

    public static int findFactorialIterative(int number)
    {
        for(int i = number; i > 1; i--)
        {
            number *= (i - 1);
        }
        return number;
    }
}
