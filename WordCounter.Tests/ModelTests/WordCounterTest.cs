using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordMaster.Models;
using System.Collections.Generic;
using System;

namespace WordMaster.TestTools
{
  [TestClass]
  public class WordCounterTests
  {

    [TestMethod]
    public void WordCounter_Constructor_Returns_WordCounter()
    {
      string word = "word";
      string sentence ="word word";
      WordCounter wordCounter = new WordCounter(word, sentence);
      Assert.AreEqual(typeof(WordCounter), wordCounter.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      //Arrange
      string word = "word";
      string sentence ="word word";
      WordCounter wordCounter = new WordCounter(word, sentence);
    
      //Act
      string result = wordCounter.GetWord();

      //Assert
      Assert.AreEqual(word, result);
    }

        [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      //Arrange
      string word = "word";
      string sentence ="word word";
      WordCounter wordCounter = new WordCounter(word, sentence);
    
      //Act
      string result = wordCounter.GetSentence();

      //Assert
      Assert.AreEqual(sentence, result);
    }

    [TestMethod]
    public void GetWordCounter_ReturnsMessage_String()
    {
      //Arrange
      string word = "word";
      string sentence ="word word";
      WordCounter wordCounter = new WordCounter(word, sentence);
      string message = "Your input word was " + "word" + " and your input sentence was " + "word word";
     
      //Act
      string result = wordCounter.GetWordCounter();
    
      //Assert
      Assert.AreEqual(message, result);
    }

    [TestMethod]
    public void WordCounterCheck_Int()
    {

    //Arrange
    string word = "word";
    string sentence ="word word";
    WordCounter wordCounter = new WordCounter(word, sentence); 

    //Act
    int result = wordCounter.WordCounterCheck(); 

    //Assert
    Assert.AreEqual(2, result);
    }  
  }
}