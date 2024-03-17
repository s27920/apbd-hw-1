// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GetMax(new []{3, 20, 7, 11, 15}));
    }
    

    static int GetMax(int[] arr)
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
