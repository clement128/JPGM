using JPGM;
using static System.Console;

var game1 = new GodOfGambler();
WriteLine("Game ID: {0}, {1}", game1.Id, game1.Spin(1));

var game2 = new Gemlinks();
WriteLine("Game ID: {0}, {1}, {2}", game2.Id, game2.Spin(1), game2.Jackpot(1));




(int, int) SpinApi(IGameModule<int, int> game)
{
    var spinResult = game.Spin(Random.Shared.Next());
    var jackPotResult = 0;
    if (game is IJackpotGameModule<int, int, int> jackpot)
    {
        jackPotResult = jackpot.Jackpot(Random.Shared.Next());
    }
    return (spinResult, jackPotResult);
}


SpinApi(game1);
SpinApi(game2);
