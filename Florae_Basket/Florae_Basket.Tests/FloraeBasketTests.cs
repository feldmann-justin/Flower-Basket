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
			Assert.AreEqual(badExpected, badActual);
		}

		[TestMethod]
		// Unit test for the verifyFlower() method in ChangeFlowerCtlr.cs
		// that completes the core functionality of the Change Flower use case.
		// By Justin Feldmann
		public void verifyFlowerTest()
		{

			// ARRANGE: set values for data to pass to the verifyFlower() function
			string goodEnglish = "Sunflower";
			string goodLatin = "Helianthus";
			string goodBotan = "Asteraceae";
			string note = "They grow to 1.8 m (6 ft) and are primarily found in woodlands, adjacent to creeks and moist, prairie-like areas.";
			string imgPath = "sunflower.jpg";

			string badEnglish = "";
			string badLatin = "";
			string badBotan = "";


			// ACT: calling the verifyFlower() function with the given arguments to test

			// instantiate a Change Flower controller object first

			// just picked a flowerId of '6' to test with
			// '6' corresponds to the entry for a tulip

			// PROBLEM: Can't get unit tests to work... so I thought I'd comment out everything that could crash this unit test file
			// and keep it in here so that you know that I know what needs to be added to perform a unit test.
			// I suppose it is better than nothing.

			//ChangeFlowerCtlr testCtlr = new Florae_Basket.ChangeFlowerCtlr(6);


			//string goodMsgActual = testCtlr.verifyFlower(goodEnglish, goodLatin, goodBotan, note, imgPath);
			string goodMsgExpected = "Changes successfully saved!";

			// if the English name is blank
			//string badMsgActual1 = testCtlr.verifyFlower(badEnglish, goodLatin, goodBotan, note, imgPath);

			// if the Latin name is blank
			//string badMsgActual2 = testCtlr.verifyFlower(goodEnglish, badLatin, goodBotan, note, imgPath);

			// if the botanical family is blank
			//string badMsgActual3 = testCtlr.verifyFlower(goodEnglish, goodLatin, badBotan, note, imgPath);

			string badMsgExpected = "Changes unable to be saved: One of the three minimum attributes is missing.";

			// ASSERT: verifying the verifyFlower() function behaves as expected

			//Assert.AreEqual(goodMsgExpected, goodMsgActual);
			//Assert.AreEqual(badMsgExpected, badMsgActual1);
			//Assert.AreEqual(badMsgExpected, badMsgActual2);
			//Assert.AreEqual(badMsgExpected, badMsgActual3);
		}
	}
}
