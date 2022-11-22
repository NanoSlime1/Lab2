using System;
using System.Collections.Generic;

namespace Lab2
{
    public class GameAccount
    {
        public GameAccount(string userName, int rating = 0, int gamesCount = 0)
        {
            UserName = userName;
                
            CurrentRating = rating < 1 ? 1 : rating;
            GamesCount = gamesCount;
        }
            
        protected string UserName;
        protected int CurrentRating;
        protected int GamesCount;
        protected List<GameHistory> GamesHistory = new List<GameHistory>();
            
        public int GetRating() { return CurrentRating;}
        public void SetRating(int Value) { CurrentRating = Value < 0 ? 0 : Value ;}

        public int GetGamesCount() { return GamesCount;}
        public void SetGamesCount(int Value) { GamesCount = Value < 0 ? 0 : Value;}
            
        public string GetUserName() { return UserName;}

        public virtual void WinGame(GameAccount Loser, BaseGame game, int GameRating)
        {
            if (CurrentRating < GameRating || Loser.GetRating() < GameRating)
            {
                Console.WriteLine("Player " + UserName + "(" + CurrentRating + ")" + " and player " + Loser.GetUserName() + "(" + Loser.GetRating() + ")" + " cannot play with rating " + GameRating);
                return;
            }
            
            Loser.SetGamesCount(Loser.GetGamesCount() + 1);
            GamesCount++;
                
            CurrentRating += GameRating;
            Loser.SetRating(Loser.GetRating() - GameRating);

            GamesHistory.Add( new GameHistory(this, Loser, GameRating, GamesHistory.Count));
        }
            
        public virtual void LoseGame(GameAccount Winner, BaseGame game, int GameRating)
        {            
            if (CurrentRating < GameRating || Winner.GetRating() < GameRating)
            {
                Console.WriteLine("Player " + UserName + "(" + CurrentRating + ")" + " and player " + Winner.GetUserName() + "(" + Winner.GetRating() + ")" + " cannot play with rating " + GameRating);
                return;
            }
            
            Winner.SetGamesCount(Winner.GetGamesCount() + 1);
            GamesCount++;
                
            CurrentRating -= GameRating;
            Winner.SetRating(Winner.GetRating() + GameRating);
            
            GamesHistory.Add(new GameHistory(Winner, this, GameRating, GamesHistory.Count));
        }

        public void ShowPlayerInfo()
        {
            Console.WriteLine("Player: " + UserName + "\t\tRating: " + CurrentRating + "\tGames quantity: " + GamesCount);
        }            


        public void ShowHistory()
        {
            Console.WriteLine("\nGame history: ");
            foreach (GameHistory History in GamesHistory)
            {
                History.ShowInfo();
            }
        }
    }
}