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

        [TestMethod]
        // unit testing for addUserCtrl verify user method. Written by Kade Walter
        public void addUserVerify_Test()
        {
            // arrange
            string goodFirst = "Kade";
            string goodLast = "Walter";
            string goodUsername = "kadwalt";
            string goodPassword = "kadwalt";
            string goodaccType = "Administrator";

            string badFirst = "";
            string badLast = "";
            string badUsername = "";
            string badPassword = "";
            string badAccType = "";

            // act 
            addUserCtrl ctrl = new addUserCtrl();
            bool goodActual = ctrl.verify(goodFirst, goodLast, goodUsername, goodPassword, goodaccType);
            bool goodExpected = true;

            bool badActual = ctrl.verify(badFirst, badLast, badUsername, badPassword, badaccType);
            bool badExpected = false;

            // assert
            Assert.AreEqual(goodExpected, goodActual);
            Assert.AreEqual(badExpected,badActual);
        }
    }
}
