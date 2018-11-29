namespace WordMaster
{
  public class WordCounter
  {
    public string UserInputWord = "cat";
    public string UserInputSentence = "The cat house";
    public int counter = 0;


    public bool MatchesWord(string word)
    {
      return word == UserInputWord;
    }

    public bool MatchesSentence(string sentence)
    {
      return sentence == UserInputSentence;
    }

    public bool CreateWordArray(string sentence)
    {
      string[] Arr = UserInputSentence.Split(' ');
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
      string newMessage = UserInputWord + "appears 1 time";
      return newMessage == message;
    }

    
  }
}