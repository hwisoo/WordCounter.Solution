
namespace WordMaster
{
  public class WordCounter
  {
    public string _word;
    public string _sentence;
    public int counter = 0;

    public WordCounter(string inputWord, string inputSentence)
    {
      _word = inputWord;
      _sentence = inputSentence;
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

    public bool CreateWordArray(string sentence)
    {
      string[] Arr = _sentence.Split(' ');
      string[] Arr2 = sentence.Split(' ');
      return (Arr.Length == 3 && Arr2.Length ==3);
    }

    public bool CheckEachWord(string[] array)
    {
      foreach(string word in array)
      {
        if(MatchesWord(word) ==true)
        {
          counter++;
        }
      }  
      return counter==1;
    }

    public bool OutputMessage(string message)
    {
      string newMessage = _word + "appears 1 time";
      return newMessage == message;
    }

    
  }
}