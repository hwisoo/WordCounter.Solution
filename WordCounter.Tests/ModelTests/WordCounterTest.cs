using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordMaster;

namespace WordMaster.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
     public void MatchesWord_True()
    {
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(true, testWordCounter.MatchesWord("cat"));
    }

     [TestMethod]
    public void DoesNotMatchWord_False()
    {
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(false, testWordCounter.MatchesWord("fish"));
    }

    [TestMethod]
     public void MatchesSentence_True()
    {
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(true, testWordCounter.MatchesSentence("The cat house"));
    }

     [TestMethod]
    public void DoesNotMatchSentence_False()
    {
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(false, testWordCounter.MatchesSentence("The dog house"));
    }

    [TestMethod]
    public void CreateWordArray_True()
    {
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(true, testWordCounter.CreateWordArray("The cat house"));
    }

     [TestMethod]
    public void CreateWordArray_False()
    {
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(false, testWordCounter.CreateWordArray("The cat dog house"));
    }

     [TestMethod]
    public void CheckEachWord_True()
    {
      WordCounter testWordCounter = new WordCounter();
      string[] TestArray = new string[] { "The", "cat", "house" };
      Assert.AreEqual(true, testWordCounter.CheckEachWord(TestArray));
    }

    [TestMethod]
    public void CheckEachWord_False()
    {
      WordCounter testWordCounter = new WordCounter();
      string[] TestArray2 = new string[] { "The", "dog", "house" };
      Assert.AreEqual(false, testWordCounter.CheckEachWord(TestArray2));
    }

    [TestMethod]
    public void OutputMessage_True()
    {
      WordCounter testWordCounter = new WordCounter();
      string testWord = "cat";
      string testMessage = testWord;
      Assert.AreEqual(true, testWordCounter.OutputMessage(testMessage+ "appears 1 time"));
    }

     [TestMethod]
    public void OutputMessage_False()
    {
      WordCounter testWordCounter = new WordCounter();
      string testWord2 = "dog";
      string testMessage2 = testWord2;
      Assert.AreEqual(false, testWordCounter.OutputMessage(testMessage2 + "appears 1 time"));
    }
  }
}