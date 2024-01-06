   static void Main(string[] args)
    {   
        Console.Write("Put in string: ");
        string input = Console.ReadLine();
        Console.WriteLine(IsPalandrome(input).ToString());
    }
   

    public static bool IsPalandrome(string str)
    {
        int length = str.Length;
        if(length == 0 || length == 1)
        {
            return true;
        }
        if(str.StartsWith(str.Substring(length -1)))
        {
            return IsPalandrome(str.Substring(1, length -2));
        }
        
        return false;
    } 