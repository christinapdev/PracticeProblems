using System.Numerics;

namespace ExtraLongFactorial;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Convert.ToInt32(powerSum(100,3)));
    }

    /*
     * Complete the 'powerSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER X
     *  2. INTEGER N
     */

    public static int powerSum(int X, int N)
    {
        return helper(X, N, 1);
    }

    private static int helper(double total, int power, int number)
    {
        double val = total - Math.Pow(number, power);
        if(val == 0) //we have reached the sum
        {
            return 1;
        }
        else if(val < 0)
        {
            return 0;
        }
        return helper(val, power, number+1) + helper(total, power, number + 1);
    }
}
