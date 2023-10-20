using System;

namespace uppgift_4_8
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sträng");
            string sträng = Console.ReadLine();

            Console.WriteLine("Skriv in två tecken att leta efter");
            string tecken = Console.ReadLine();

            char tecken1 = tecken[0];
            char tecken2 = tecken[1];
            bool teckenfinns = false;  

            for (int i = 0; i < sträng.Length; i++)
            {
                if (sträng[i ]== tecken1 || sträng[i] == tecken2)
                {
                    teckenfinns = true;
                }
            }
            if (teckenfinns)
            {
                Console.WriteLine("Tecken finns");
            }
            else
            {
                Console.WriteLine("Tecken finns inte");
            }
            Console.ReadKey();
        }
    }
}
