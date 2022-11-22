using System;

namespace Lab2
{
    public class TestAccount : GameAccount
    {
        public TestAccount(string UserName, int CurretRating) : base(UserName, CurretRating) { }

        public override void LoseGame(GameAccount Winner, BaseGame game, int GameRating)
        {
            if (game.GetRating() < 0) { Console.WriteLine("Game rating must be positive!"); return;}
            if (game.GetRating() >= CurrentRating) { Console.WriteLine("Game rating is too high"); return;}

            CurrentRating -= 0;
            GameHistory story = new GameHistory(Winner, this, 0, GamesHistory.Count);
            GamesHistory.Add(story);
        }

        public override void WinGame(GameAccount Loser, BaseGame game, int GameRating)
        {
            if (game.GetRating() < 0) { Console.WriteLine("Game rating must be positive!"); }
            if (game.GetRating() >= CurrentRating) { Console.WriteLine("Game rating is too high"); }

            CurrentRating += 0;
            GameHistory story = new GameHistory(this, Loser, 0, GamesHistory.Count);
            GamesHistory.Add(story);
        }
    }
}

