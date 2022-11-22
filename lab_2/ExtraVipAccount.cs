using System;

namespace Lab2
{
    public class ExtraVipAccount : GameAccount
    {
        public ExtraVipAccount(string userName, int curretRating) : base(userName, curretRating) { }


        public override void WinGame(GameAccount Loser, BaseGame game, int GameRating)
        {
            if (game.GetRating() < 0) { Console.WriteLine("Game rating must be positive!"); return;}
            if (game.GetRating() >= CurrentRating) { Console.WriteLine("Game rating is too high"); return; }

            CurrentRating += 2 * game.GetRating();
            GameHistory story = new GameHistory(this, Loser, 2 * game.GetRating(), GamesHistory.Count);
            GamesHistory.Add(story);
        }
    }
}
