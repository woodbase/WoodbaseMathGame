using System;
using System.Collections.Generic;
using System.Linq;
using Woodbase.MatchGame.Core.Interfaces;

namespace Woodbase.MatchGame.Core.Src
{
    public class Addition
    {
        public int A { get; set; }
        public int B { get; set; }
        public IResult Result { get; set; }

        public Addition(int a, int b)
        {
            A = a;
            B = b;
            Result = new Result() { Value = A + B, Correct = true };
        }

        public IEnumerable<IResult> GetSuggestions(int seed, int rangeMax)
        {
            var rnd = new Random();
            var intResult = Convert.ToInt32(Result.Value);
            var intArray = Enumerable.Range(0, rangeMax).OrderBy(x => rnd.Next()).Where(y => y != intResult).Distinct().Take(seed - 1).ToArray();

            var res = intArray.Select(x => new Result() {Value = x, Correct = false}).ToList<IResult>();
            res.Add(Result);

            return res.OrderBy(x=>rnd.Next());
        }
    }
}
