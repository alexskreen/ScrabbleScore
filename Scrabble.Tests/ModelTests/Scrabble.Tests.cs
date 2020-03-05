 using Microsoft.VisualStudio.TestTools.UnitTesting;
 using ScrabbleWord.Models;

 namespace ScrabbleWord.Test
 {
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]
        public void RemoveSpecialCharacters_Testk_ReturnK()
        {
            Game testGame = new Game("k3!");
            Assert.AreEqual("K", testGame.RemoveSpecialCharacters("k3!"));

        }
        
        [TestMethod]
        public void ScrabbleCount_TestK_Return5()
        {
            Game testGame = new Game("K");
            Assert.AreEqual(5, testGame.GameCount());

        }

        [TestMethod]
        public void ScrabbleCount_TestJX_Return16()
        {
            Game testGame = new Game("JX");
            Assert.AreEqual(16, testGame.GameCount());

        }

        [TestMethod]
        public void ScrabbleCount_TestQZ_Return20()
        {
            Game testGame = new Game("QZ");
            Assert.AreEqual(20, testGame.GameCount());

        }

        [TestMethod]
        public void ScrabbleCount_TestDG_Return4()
        {
            Game testGame = new Game("DG");
            Assert.AreEqual(4, testGame.GameCount());

        }

        [TestMethod]
        public void ScrabbleCount_TestBCMP_Return12()
        {
            Game testGame = new Game("BCMP");
            Assert.AreEqual(12, testGame.GameCount());

        }
        [TestMethod]
        public void ScrabbleCount_TestFHVWY_Return20()
        {
            Game testGame = new Game("FHVWY");
            Assert.AreEqual(20, testGame.GameCount());

        }

        [TestMethod]
        public void ScrabbleCount_TestLNRST_Return5()
        {
            Game testGame = new Game("LNRST");
            Assert.AreEqual(5, testGame.GameCount());

        }

        [TestMethod]
        public void ScrabbleCount_TestAEIOU_Return5()
        {
            Game testGame = new Game("LNRST");
            Assert.AreEqual(5, testGame.GameCount());

        }
    } 
 }