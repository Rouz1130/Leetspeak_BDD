using System.Collections.Generic;

namespace Leetspeak
{
  public class Speak
  {
    public string Translate(string phrase)
    {
      char[] inputPhrase = phrase.ToCharArray();
      for (var i = 0; i < inputPhrase.Length; i += 1)
      {
        if (inputPhrase[i] == 'e' || inputPhrase[i] == 'E')
        {
          inputPhrase[i] = '3';
        }
        else if (inputPhrase[i] == 'o' || inputPhrase[i] == 'O')
        {
          inputPhrase[i] = '0';
        }
        else if (inputPhrase[i] == 'I')
        {
          inputPhrase[i] = '1';
        }
        else if (inputPhrase[i] == 's' && i != 0)
        {
          inputPhrase[i] = 'z';
        }
      }
      string result = string.Join("", inputPhrase);
      return result;
    }
  }
}
