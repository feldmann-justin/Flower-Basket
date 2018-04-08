using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Florae_Basket;

namespace Florae_Basket.Tests
{
    [TestClass]
    public class FloraeBasketTests
    {
        [TestMethod]
        public void OSA_TEST_METHOD()
        {
            string eng = "";
            string lat = "";
            string bot = "";
            string not = "";
            string entry = "violet";
            Word_Search search = new Word_Search(eng, lat, bot, not);

            int result = search.OSA(eng, lat, eng.Length, entry.Length);
            
            
        }
    }
}
