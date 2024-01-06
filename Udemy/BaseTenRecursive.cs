using System.Diagnostics.Metrics;

namespace VisualStudioConsoleApp;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Put in string: ");
        int input = Int32.Parse(Console.ReadLine());
        Console.WriteLine(BaseTwo(input, ""));
    }
   

    private static string BaseTwo(int num, string result)
    {
        if (num == 0)
        {
            return result;
        }

        result = num % 2 + result;
        return BaseTwo(num / 2, result);
    }
}