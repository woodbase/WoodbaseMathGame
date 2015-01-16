using Woodbase.MatchGame.Core.Interfaces;

namespace Woodbase.MatchGame.Core.Src
{
    public class Result : IResult
    {
        public int Value { get; set; }
        public bool Correct { get; set; }
    }
}