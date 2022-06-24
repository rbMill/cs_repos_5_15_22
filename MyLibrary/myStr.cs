

namespace MyLibrary
{
    public static class myString
    {
        public static string coke(int val)
        {
            return val.ToString();
        }
    }

    public class Relational
    {
        static int i = 0;
        static Relational()
        {
            i+=1;
            Console.WriteLine(i);
        }
    }
}