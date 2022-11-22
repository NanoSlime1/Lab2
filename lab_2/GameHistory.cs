using System;

namespace Lab2
{
    public class GameHistory
    {
        private int GameID;
        private GameAccount _winner;
        private GameAccount _loser;
        private int GameRating;

        public string GetPlayerOneName() { return _winner.GetUserName(); }
        public string GetPlayerTwoName() { return _loser.GetUserName(); }
        
        public int GetRating() { return GameRating; }
        public void SetRating(int Rating) { GameRating = Rating; }
        
        public int GetGameID() { return GameID; }

        public GameHistory(GameAccount Winner, GameAccount Loser, int RatingGame, int index)
        {
            _winner = Winner;
            _loser = Loser;
            GameRating = RatingGame;
            GameID = index;
        }

        public void ShowInfo()
        { 
            Console.Write("Game ID: " + GameID + "\tWinner: " + _winner.GetUserName() + "\tLoser: " + _loser.GetUserName() + "\n");
        }
    }
}