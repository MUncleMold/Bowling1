namespace Bowling1

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Game game = new Game();
            Assert.IsNotNull(game);
            game.addThrow(5);
            game.addThrow(4);
            Assert.AreEqual(9, game.score());
        }
    }
}