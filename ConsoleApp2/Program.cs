// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        int i = 0;
        Console.WriteLine("Hello, World!");
        Console.WriteLine(i);
        Console.WriteLine(max(new []{3, 20, 7, 11, 15}));
    }

    static double avg(int[] arr)
    {
        double sum = 0;
        int counter = 0;
        foreach (int i in arr)
        {
            sum += i;
            counter++;
        }

        return sum / counter;
    }


    static int max(int[] arr)
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
