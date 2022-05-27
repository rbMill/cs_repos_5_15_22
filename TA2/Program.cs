using System.Collections;


namespace IORead
{
    class main1
    {
        public static void Main()
        {
            int[] vals = GetPrimes();
            Console.WriteLine(vals[19]);
        }

        public static int[] GetPrimes(int len = 100, bool print = false)
        {
            int[] primes = {2,3,5,7,11,13,17,23,29,31};
            
            int[] prime_nums = new int[len];
            if (print){
            Console.WriteLine("Start!");
            }
            
            bool is_prime;
            int ci = 0;
            for (int i = 1; ci < len; i++)
            {
                is_prime = true;
                foreach(var x in primes)
                {
                    if (i%x == 0 && i != x){is_prime = false; break;}
                }
                if (is_prime){
                    if (print){
                    Console.WriteLine(i);}
                    prime_nums[ci] = i;
                    ci++;
                }
            }    
            if (print){
            Console.WriteLine("Done!");
            }
            return prime_nums;
        }
        }
    }


