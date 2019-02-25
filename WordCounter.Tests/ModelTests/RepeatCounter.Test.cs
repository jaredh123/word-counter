using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void userWordTestString()
    {
      string userWord = "testWord";
      bool result = userWord is string;
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void userSentenceTestNull()
    {
      string userSentence = "testSenstence";
      bool result = userSentence.Length > 0;
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void userSentenceTestString()
    {
      string userSentence = "testSenstence";
      bool result = userSentence is string;
      Assert.AreEqual(true, result);
    }
  }
}
