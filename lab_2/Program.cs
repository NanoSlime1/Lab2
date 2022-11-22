using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtraVipAccount Player1 = new ExtraVipAccount("WhoAmI", 100);
            TestAccount Player2 = new TestAccount("Crown", 100);
            VipAccount Player3 = new VipAccount("David", 1000);

            SimpleGame game = new SimpleGame();
            
            
            Console.WriteLine(Player1.GetUserName() + ": " + Player1.GetRating());
            Console.WriteLine(Player2.GetUserName() + ": " + Player2.GetRating());
            Console.WriteLine(Player3.GetUserName() + ": " + Player3.GetRating());

            game.Game(Player1, Player3, 44);
            game.GetStats();
            Console.WriteLine("\n" + Player1.GetUserName() + ": " + Player1.GetRating());
            Console.WriteLine(Player2.GetUserName() + ": " + Player2.GetRating());
            Console.WriteLine(Player3.GetUserName() + ": " + Player3.GetRating());

            game.Game(Player3, Player3, 22);
            game.GetStats();
            Console.WriteLine("\n" + Player1.GetUserName() + ": " + Player1.GetRating());
            Console.WriteLine(Player2.GetUserName() + ": " + Player2.GetRating());
            Console.WriteLine(Player3.GetUserName() + ": " + Player3.GetRating());

            game.Game(Player2, Player3, 14);
            game.GetStats();
            Console.WriteLine("\n" + Player1.GetUserName() + ": " + Player1.GetRating());
            Console.WriteLine(Player2.GetUserName() + ": " + Player2.GetRating());
            Console.WriteLine(Player3.GetUserName() + ": " + Player3.GetRating());

            game.Game(Player3, Player1, 5);
            game.GetStats();
            Console.WriteLine("\n" + Player1.GetUserName() + ": " + Player1.GetRating());
            Console.WriteLine(Player2.GetUserName() + ": " + Player2.GetRating());
            Console.WriteLine(Player3.GetUserName() + ": " + Player3.GetRating());

            game.Game(Player3, Player2, 10);
            game.GetStats();
            Console.WriteLine("\n" + Player1.GetUserName() + ": " + Player1.GetRating());
            Console.WriteLine(Player2.GetUserName() + ": " + Player2.GetRating());
            Console.WriteLine(Player3.GetUserName() + ": " + Player3.GetRating());

            game.Game(Player2, Player1, 30);
            game.GetStats();
            Console.WriteLine("\n" + Player1.GetUserName() + ": " + Player1.GetRating());
            Console.WriteLine(Player2.GetUserName() + ": " + Player2.GetRating());
            Console.WriteLine(Player3.GetUserName() + ": " + Player3.GetRating());

            Console.WriteLine("\n" + Player1.GetUserName());
            Player1.ShowHistory();
            
            Console.WriteLine("\n" + Player2.GetUserName());
            Player2.ShowHistory();

            Console.WriteLine("\n" + Player3.GetUserName());
            Player3.ShowHistory();
        }
    }
}