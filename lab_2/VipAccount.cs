
namespace Lab2
{
    public class VipAccount : GameAccount
    {
        public VipAccount(string UserName, int CurretRating) : base(UserName, CurretRating) { }


        public override void WinGame(GameAccount Loser, BaseGame game, int GameRating)
        {
            CurrentRating += 2 * game.GetRating();
            GameHistory story = new GameHistory(this, Loser, 2 * game.GetRating(), GamesHistory.Count);
            GamesHistory.Add(story);
        }


        public override void LoseGame(GameAccount Winner, BaseGame game, int GameRating)
        {
            CurrentRating -= game.GetRating() / 2;
            GameHistory story = new GameHistory(Winner, this, game.GetRating() / 2, GamesHistory.Count);
            GamesHistory.Add(story);
        }
    }
}
