using System.IO;

namespace IORead
{
    class main {
        
        
        public static void Main()
        {
            string path = @"hisoka.txt";
            string message = "Sug Ma Dik\n";
            for (int i = 0; i < 8; i++){
            message = message + message;
            }
            File.WriteAllText(path,message);
        }
        public main()
        {
            Console.Write("Choyushi");
        }
    }
}