using System.Diagnostics.Metrics;

namespace VisualStudioConsoleApp;

class Program
{
    static void Main(string[] args)
    {   //      c  n  r
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(fibonacciIterative(input));
        Console.WriteLine(fibonacciRecursive(input));
    }
    
    public static int fibonacciIterative(int number)
    {
        Queue<int> fibSeq = new Queue<int>();

        fibSeq.Enqueue(0);
        fibSeq.Enqueue(1);
        var counter = 3;
        var first = 0;
        var second = 1;
        while(counter <= number + 1)
        {   
            fibSeq.Enqueue(fibSeq.ElementAt(first) + fibSeq.ElementAt(second));
            second++;
            first++;
            counter++;
        }
        return fibSeq.ElementAt(number);
    }

    public static int fibonacciRecursive(int number) //3 return 2
    {
        if (number < 2) return number;
        return fibonacciRecursive(number-1) + fibonacciRecursive(number - 2);
    }
}