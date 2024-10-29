using System;
namespace test
{
    class Test{ 
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= 2)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.Write(NextPrime(number));
            }

            
        }
        static int NextPrime(int n)
        {
            if (IsPrime(n))
            {
                return n;
            }
            return NextPrime(n + 1);
        }

        static bool IsPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (IsDivisor(n, i)) return false;
            }
            return true;
        }

        static bool IsDivisor(int n, int d)
        {
            if (n % d == 0) return true;
            return false;
        }
    }
}