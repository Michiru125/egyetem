using System;

namespace Magassag
{
    class Program
    {
        static void Main(string[] args)
        {
            #region első próbálkozás
            /*
            int N;
            N = int.Parse(Console.ReadLine());

            if (1<= N && N <= 100)
            {
                Console.WriteLine("jó lesz, jöhetnek az adatok");
            }
            else
            {
                Console.WriteLine("nem tetszik.");
            }
            */
            #endregion

            int N;
            bool jo;
            do
            {
                jo = int.TryParse(Console.ReadLine(),out N);
                jo = jo && (1 <= N && N <= 100);
            } while (!jo);
            
            int[] H = new int[N];
            for (int i = 0; i < N; i++)
            {
              string[] sor = Console.ReadLine().Split(' ');
                Console.WriteLine(sor[0]);
                H[i] = int.Parse(sor[1]);
            }

            

            Console.WriteLine("Ez jó lesz: " + N);
            Console.WriteLine("IGEN");
        }
    }
}
