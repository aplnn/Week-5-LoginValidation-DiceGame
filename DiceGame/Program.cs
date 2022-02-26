using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja ksutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, on mängu võitja
            //*täringuid visatakse 3 korda
            //programm kuulutab võitja

            
            Random rnd = new Random();

            int cpuRandom;
            int userRandom;

            int cpuScore = 0;
            int userScore = 0;

                       
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Katse {i+1}.");
                
                cpuRandom = rnd.Next(1, 7);
                userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                if (cpuRandom < userRandom)
                {
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    cpuScore = cpuScore + 0;
                    userScore = userScore + 0;
                }

                Console.WriteLine($"Arvuti skoor on {cpuScore}. Kasutaja skoor on {userScore}.");
            }

            if (cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
            }
            else if (cpuScore < userScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
            }
            else
            {
                Console.WriteLine("Viik!");
            }
                        
            
        }
    }
}
