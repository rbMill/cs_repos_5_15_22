using System;
// using System.Ling;


namespace Program
{
    class Program
    {
        static bool flag = true;
        static int x = 0;
        static int mp = 1;
        static int lim = 10000;
        static void Main ()
        {
            Dictionary<int[], object> position = new Dictionary<int[], object>();

        }
        
        static void Loop()
        {
            for (int i = 0;flag && i < lim; i++)
            {
                if (x <= 0){mp = 1;}
                else if (x >= 51){mp = -1;}
                Console.WriteLine(String.Concat(Enumerable.Repeat("_",x))+"*");
                x+=mp;
            }
        }
    }
}