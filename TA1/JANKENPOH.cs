using System;

public  class janken
{
    private delegate void func();
    private static int userScore = 0;
    private static int cpuScore = 0;

    
    private static string? ans = "";
    private static string comans= "";
    private static string winner = "";

    public static void u_win()
    {
        userScore++;
        winner = "user";
    }
    public static void u_lost()
    {
        cpuScore++;
        winner = "cpu";           
    }
    public static void draw()
    {
        winner = "no one";           
    }
    static func _u_win = new func(u_win);
    static func _u_lost = new func(u_lost);
    static func _draw = new func(draw);

    
    
    
    public janken()
    {
        var conclusion = new Dictionary<string, func>(){
        {"rock,rock",_draw},{"scissors,scissors",_draw},{"paper,paper",_draw},            
        {"rock,scissors",_u_win},{"scissors,paper",_u_win},{"paper,rock",_u_win},
        {"scissors,rock",_u_lost},{"paper,scissors",_u_lost},{"rock,paper",_u_lost},
        };        
        Random rand = new Random();
        string [] choice = {"rock","paper","scissors"};
        string [] exitwords = {"stop","end","exit","cls"};
        bool go = true; 
        while (go)
        {
            Console.Write("Janken poh :");
            try{ans = Console.ReadLine();}
            catch(ArgumentNullException){}

            catch(ArgumentOutOfRangeException){}
            comans = choice[rand.Next(2)];
            if (exitwords.Contains(ans)){go = false; break;}
            
            Console.WriteLine($"cpu :{comans}");
            if (conclusion.Keys.Contains($"{ans},{comans}")){conclusion[$"{ans},{comans}"]();}
            else {draw();}
            Console.WriteLine($"{winner} wins (user: {userScore}, cpu : {cpuScore})");    
        }

    }

    
    
}
