using System.Diagnostics.Metrics;

namespace VisualStudioConsoleApp;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Put in string: ");
        string input = Console.ReadLine();
       
        Console.WriteLine(StringReverse(input));
    }

    public static string StringReverse(string str)
    {
        if(str == "")
        return "";
        return StringReverse(str.Substring(1, str.Length -1)) + str.Substring(0, 1);
        //take StringReverse() from call stack and concatenate on the part you want to the stack. 
    } 
}