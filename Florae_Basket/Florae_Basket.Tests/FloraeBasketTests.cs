using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Florae_Basket;

namespace Florae_Basket.Tests
{
    [TestClass]
    public class FloraeBasketTests
    {
        [TestMethod]
        //Unit test for the Optimal String Alignment method in the word search, written by Brady Smith
        public void OSA_TEST_METHOD()
        {
            //arrange
            string eng = "sweet violet";
            string lat = "Viola odorata";
            string bot = "Violaceae";
            string not = "";
            string entry1 = "sweet violet";
            string entry2 = "Viola odor";
            string entry3 = "Violaceaeba";
            int expected = 24;
            int expected2 = 14;
            int expected3 = 14;
            Word_Search search = new Word_Search(eng, lat, bot, not);

            //act
            int result = search.OSA(eng, entry1, eng.Length, entry1.Length);
            int result2 = search.OSA(lat, entry2, lat.Length, entry2.Length);
            int resutl3 = search.OSA(bot, entry3, bot.Length, entry3.Length);

            //assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2, result2);
            Assert.AreEqual(expected3, resutl3);
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
            bool goodActual = ctrl.verifyInfo(goodFirst, goodLast, goodUsername, goodPassword, goodaccType);
            bool goodExpected = true;

            bool badActual = ctrl.verifyInfo(badFirst, badLast, badUsername, badPassword, badAccType);
            bool badExpected = false;

            // assert
            Assert.AreEqual(goodExpected, goodActual);
            Assert.AreEqual(badExpected,badActual);
        }
    }
}
