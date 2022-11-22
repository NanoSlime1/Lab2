using System;

namespace Lab2
{
    public class OnlyWinGame : BaseGame
    {
        public override void Game(GameAccount winner, GameAccount loser, int rating)
        {
            if (rating < 0)
            {
                Console.WriteLine("Game rating must be positive!");
            }

            if (rating > 0 && loser.GetRating() - rating > 0)
            {
                GameHistory history = new GameHistory(winner, loser, rating, GameHistories.Count);
                GameHistories.Add(history);

                winner.WinGame(loser, this, GameCount);
                GameHistories[GameHistories.Count - 1].SetRating(0);

                loser.LoseGame(winner, this, GameCount);
                GameHistories[GameHistories.Count - 1].SetRating(rating);
                winner.SetGamesCount(winner.GetGamesCount() + 1);
                loser.SetGamesCount(loser.GetGamesCount() + 1);
                GameCount++;
            }
        }
    }
}

