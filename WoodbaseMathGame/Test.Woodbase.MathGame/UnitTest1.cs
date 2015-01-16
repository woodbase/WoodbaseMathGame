using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Woodbase.MatchGame.Core.Src;

namespace Test.Woodbase.MathGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionSuggestion()
        {
            var addtion = new Addition(2,3);
            var results = addtion.GetSuggestions(5, 20).ToList();

            Assert.AreEqual(4, results.Where(x => x.Correct==false).ToList().Count());
            Assert.AreEqual(1, results.Where(x=>x.Correct).ToList().Count());
        }
    }
}
