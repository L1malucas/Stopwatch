namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            // int timeInput = 0;
            // Start(timeInput);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("0 = Sair");

            string data = Console.ReadLine()!.ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int timeInput = Int32.Parse(data.Substring(0, data.Length - 1));

            if (timeInput == 0)
            {
                System.Environment.Exit(0);
            }

            if (type == 's')
            {
                PreStart(timeInput);
            }
            else if (type == 'm')
            {
                timeInput *= 60;
                PreStart(timeInput);
            }
        }

        static void PreStart(int timeInput)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(timeInput);
        }


        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}