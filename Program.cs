namespace Topic_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Enter the minimum value: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter the maximum value: ");
            int max = int.Parse(Console.ReadLine());

            Console.Write("Random numbers: ");
            for (int i = 0; i < 5; i++)
            {
                int randomValue = rand.Next(min, max + 1);
                Console.Write(randomValue + " ");
            }

            Console.WriteLine();
        }
    }
}
