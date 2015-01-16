namespace Woodbase.MatchGame.Core.Interfaces
{
    public interface IResult
    {
        int Value { get; set; }
        bool Correct { get; set; }
    }
}