using System.Collections.Generic;

namespace TA4
{
    class program
    {
        public static void Main()
        {
            var val = new List<int>();
            val.Add(1);
            val.Add(2);
            val.Add(3);
            val.Add(4);
            val.Add(5);

            foreach(int i in val)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(val.Count);
        }
    }
}