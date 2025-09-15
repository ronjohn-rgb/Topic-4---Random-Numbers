namespace Topic_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int max, min, die1, die2, sum;

            //Number 1.
            Console.Write("Enter the minimum value: ");
            if (!Int32.TryParse(Console.ReadLine(), out min));
            {
                Console.WriteLine("Error minimum value, setting minimum to 1");
                min = 1;
            }

            Console.Write("Enter the maximum value: ");
            if (!Int32.TryParse(Console.ReadLine(), out max));
            {
                Console.WriteLine("Error maximum value, setting maximum to 10");
                max = 10;
            }

            Console.Write("Random numbers: ");
            for (int i = 0; i < 5; i++)
            {
                int randomValue = rand.Next(min, max + 1);
                Console.Write(randomValue + " ");
            }

            Console.WriteLine();

            //Number 2.

            die1 = rand.Next(1, 7);

            die2 = rand.Next(1, 7);

            sum = die1 + die2;

            Console.WriteLine($"First die: {die1}");
            Console.WriteLine($"Second die: {die2}");
            Console.WriteLine($"Sum of rolls: {sum}");
        }
    }
}
