using JPGM;
using static System.Console;

var game1 = new GodOfGambler();
WriteLine("Game ID: {0}, {1}", game1.Id, game1.Spin(1));

var game2 = new Gemlinks();
WriteLine("Game ID: {0}, {1}, {2}", game2.Id, game2.Spin(1), game2.Jackpot(1));
