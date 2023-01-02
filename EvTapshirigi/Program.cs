namespace EvTapshirigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, -3, 9, 10 };
            int sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length ; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            Console.Write($"cem {sum} say {count}");
        }
       
    }
}