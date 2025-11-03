namespace array_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("|" + numbers[i] + "|");
                }
        }
    }

}
