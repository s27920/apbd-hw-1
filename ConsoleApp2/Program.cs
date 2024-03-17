// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GetAvg(new []{3, 7, 11, 15, 20}));
    }

    static double GetAvg(int[] arr)
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
}
