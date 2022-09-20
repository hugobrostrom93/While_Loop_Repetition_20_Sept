namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var whileloopar = new WhileLoopar();
            //whileloopar.GuessMyNumber();
            //whileloopar.AskUserForANumber();
            //whileloopar.NestledLoops();
            whileloopar.BreakTheLoop(404);
        }

        class WhileLoopar
        {
            public void GuessMyNumber(int max = 10)
            {
                Random randomGenerator = new Random();
                var slumpTal = randomGenerator.Next(1, max + 1);
                Console.WriteLine(slumpTal);
                int gissning = 0;

                while (gissning != slumpTal)
                {
                    Console.WriteLine($"Gissa ett tal mellan 1 och {max}:");
                    var input = Console.ReadLine();

                    _ = int.TryParse(input, out gissning);
                }

                while (gissning == slumpTal)
                {
                    Console.WriteLine("Grattis du gissade rätt!");
                    break;
                }
            }


            public void AskUserForANumber(int max = 100)
            {
                Console.WriteLine($"Välj ett tall mellan 1 och {max}");
                int svar = Convert.ToInt32(Console.ReadLine());

                if (svar > max)
                {
                    Console.WriteLine($"Ditt tal är för stort! Du måste ange ett tal som är mellan 1 och {max}");
                } else if (svar < 0)
                {
                    Console.WriteLine($"Ditt tal är för litet! Du måste ange ett tal som är mellan 1 och {max}");
                } else if (svar > 0 && svar < max)
                {
                    Console.WriteLine("Perfekt!");
                }
            }

            public void NestledLoops(int max = 3)
            {
                int loopOne = 0;
                while (loopOne++ < max)
                {
                    int loopTwo = 0;
                    while (loopTwo++ < max)
                    {
                        Console.WriteLine($"Loop värde: {loopOne}:{loopTwo}");
                    }
                }
            }

            public void BreakTheLoop(int breaker)
            {
                int val = 0;
                while (val++ < 999)
                {
                    Console.WriteLine(val);
                    if (val == breaker) break; // Varför funkar if här men inte while. Vad är skillnaden?
                }

            }


        }
    }
}