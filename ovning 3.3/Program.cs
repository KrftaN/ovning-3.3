namespace övning_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int hourlyRate = 80;
            const int maxDailyRate = 950;

            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int hours = int.Parse(Console.ReadLine());

            int cost = hours * hourlyRate;

            if (cost > maxDailyRate)
            {
                cost = maxDailyRate;
            }

            Console.WriteLine($"Det kommer att kosta {cost} kronor att hyra bilen i {hours} timmar.");
        }
    }
}
