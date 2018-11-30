
namespace WordMaster
{
  public class WordCounter
  {
    public string _word;
    public string _sentence;
    public int _counter = 0;

    public WordCounter(string inputWord, string inputSentence)
    {
      _word = inputWord;
      _sentence = inputSentence;
      _counter = 0;
    }

    public string GetWord()
    {
      return _word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public string GetWordCounter()
    {
      return "Your input word was " + _word+ " and your input sentence was " + _sentence ;
    }
    public bool MatchesWord(string word)
    {
      return word == _word;
    }

    public bool MatchesSentence(string sentence)
    {
      return sentence == _sentence;
    }

    public string WordCounterCheck()
    {
      string[] Arr = _sentence.Split(' ');
      
      foreach(string word in Arr)
      {
        if(word == _word)
        {
          _counter++;
        }
      }
      return _word + " appears" + _counter + " times in the sentence.";
    }



    public bool OutputMessage(string message)
    {
      string newMessage = _word + "appears 1 time";
      return newMessage == message;
    }

    
  }
}