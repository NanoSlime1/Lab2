using System;

namespace Lab2
{
    public class SimpleGame : BaseGame
    {
        public override void Game(GameAccount winner, GameAccount loser, int rating)
        {
            if (rating < 0) { Console.WriteLine("Game rating must be positive!");  return;}
            if (loser.GetRating() - rating < 0){ Console.WriteLine("Not enough loser rating"); return;}
            
            GameHistory story = new GameHistory(winner, loser, rating, GameHistories.Count);
            GameHistories.Add(story);

            winner.WinGame(loser, this, GameCount);
            loser.LoseGame(winner, this, GameCount);

            winner.SetGamesCount(winner.GetGamesCount() + 1);
            loser.SetGamesCount(loser.GetGamesCount() + 1);
            GameCount++;
        }
    }
}

