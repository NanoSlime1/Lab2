
using System.Collections.Generic;

namespace Lab2
{
    public abstract class BaseGame
    {
        public virtual int GetRating() => GameHistories[GameHistories.Count - 1].GetRating();

        protected int GameCount = 0;
        protected List<GameHistory> GameHistories = new List<GameHistory>();

        public abstract void Game(GameAccount winner, GameAccount loser, int rating);

        public void GetStats()
        {
            for (int i = 0; i < GameHistories.Count; i++)
            {
                GameHistories[i].ShowInfo();
            }
        }
    }
}