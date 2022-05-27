
namespace Program
{
    class prog
    {
        static void Main()
        {
            string [] data = {"a","b","c","d"};
            string [] data1 = {"1","2","3","4"};
            // concatenate(data,data1);
            recombine(data,3);

        }
        public static void concatenate(string [] data,string [] data1){
            foreach (string X in data){
                foreach (string I in data1){
                    Console.WriteLine($"{X}{I}");
                }
            }
        }
        public static void recombine(string [] data,int elm)
        {
            
        }
    }
}