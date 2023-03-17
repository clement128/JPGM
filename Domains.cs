namespace JPGM;

interface IGameModule<in TArgs, out TResult>
{
    string Id { get; }
    TResult Spin(TArgs args);
}

interface IJackpotGameModule<in TArgs, out TResult, out TJackpotResult> : IGameModule<TArgs, TResult>
{
    TJackpotResult Jackpot(TArgs args);
}

class GodOfGambler : IGameModule<int, int>
{
    public string Id => "GodOfGambler";
    public int Spin(int args) => args * 2;
}

class Gemlinks : IJackpotGameModule<int, int, int>
{
    public string Id => "Gemlinks";
    public int Spin(int args) => args * 2;
    public int Jackpot(int args) => args * 3;
}
