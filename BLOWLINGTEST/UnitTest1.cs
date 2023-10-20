using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bowling1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicTest()
        {
            Game game = new Game();
            Assert.IsNotNull(game);
            game.addThrow(5);
            game.addThrow(4);
            Assert.AreEqual(9, game.score());
        }
       
        [TestMethod]

        public void TestAll()
        {
            Game game = new Game();
            Assert.IsNotNull(game);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            game.addThrow(4);
            Assert.AreEqual(80, game.score());

        }

        [TestMethod]
        public void SpareTest()
        {
            Game game = new Game();
            Assert.IsNotNull(game);
            game.addThrow(5);
            game.addThrow(5);
            game.addThrow(5);
            game.addThrow(4);   
            Assert.AreEqual(24, game.score());
        }
        [TestMethod]
        public void StrikeTest()
        {
            Game game = new Game();
            Assert.IsNotNull(game);
            game.addThrow(10);
            game.addThrow(4);
            game.addThrow(4);
            Assert.AreEqual(26, game.score());
        }
        [TestMethod]

        public void PrikolniiTest()
        {
            Game game = new Game();
            Assert.IsNotNull(game);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(5);
            game.addThrow(4);
            Assert.AreEqual(263, game.score());

        }

        [TestMethod]

        public void PrikolniiTest2()
        {
            Game game = new Game();
            Assert.IsNotNull(game);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            game.addThrow(10);
            Assert.AreEqual(300, game.score());

        }

    }
}
