using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woodbase.MatchGame.Core
{
    public class Addition
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Result { get; set; }

        public Addition(int a, int b)
        {
            A = a;
            B = b;
            Result = A + B;
        }

        public IEnumerable<int> GetSuggestions(int seed, int rightResult)
        {
            var suggestions = new List<int> {rightResult};

            for (var n = 1; n < seed; n++)
            {
                var next = 
            }
        }
    }
}
