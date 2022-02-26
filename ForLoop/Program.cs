using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will not skateboard in the halls.

            
            for(int i = 0; i < 10; i++) //paneb lause kordama 10 korda. i = 0 on iteratsiooni algus. i < 10 on tsükli lõpp. i++ = i + 1 on samm.
            {
                Console.WriteLine($"{i+1}. I will not skateboard in the halls.".ToUpper()); //ToUpper --> kuvab suurtähtetega
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
