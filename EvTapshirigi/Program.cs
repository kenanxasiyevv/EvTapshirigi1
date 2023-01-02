namespace EvTapshirigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Massivin uzunlugunu daxil et: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            Console.WriteLine($"cem: {sum}  say: {count}");
        }
       
    }
}
