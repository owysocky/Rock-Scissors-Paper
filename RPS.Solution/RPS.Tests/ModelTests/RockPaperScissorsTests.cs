using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RSP;

namespace RSP.Tests
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void IsWinner_CheckForWinPlayer1_True()
    {
      Game testWinner = new Game();
      Assert.AreEqual(true, testWinner.IsWinner(2,1));
    }

    [TestMethod]
    public void IsWinner_CheckForLoosePlayer1_True()
    {
      Game testWinner = new Game();
      Assert.AreEqual(false, testWinner.IsWinner(3,1));
    }

    [TestMethod]
    public void IsWinner_CheckForDraw_True()
    {
      Game testDraw = new Game();
      Assert.AreEqual(true, testDraw.IsDraw(3,3));
    }

  }
}
