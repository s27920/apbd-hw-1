// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        int i = 0;
        Console.WriteLine("Hello, World!");
        Console.WriteLine(i);
        Console.WriteLine(GetMax(new []{3, 20, 7, 11, 15}));
        Console.WriteLine(GetAvg(new []{3, 7, 11, 15, 20}));
    }
    
    
    static int GetMax(int[] arr)
    {
        int evenNewerName = Int32.MinValue;
        foreach (int num in arr)
        {
            if (num >= evenNewerName)
            {
                evenNewerName = num;
            }
        }

        return evenNewerName;
    }

    static double GetAvg(int[] arr)

    {
        int max = Int32.MinValue;
        foreach (int num in arr)
        {
            if (num >= max)
            {
                max = num;
            }
        }

        return max;
    }
}
