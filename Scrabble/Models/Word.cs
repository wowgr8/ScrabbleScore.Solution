using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  
  public class Word
  { 
    public string Text {get; set; }
    public char[] Letters {get; set;}


    public Word(string wordPlayed)
    {
      Text = wordPlayed;
      Letters = wordPlayed.ToCharArray();
    }

    

    public int GetScore()
    {
      int score = 0;
      string validatedWord = "";
      try
      {
        foreach(char letter in Letters)
        {
          if (Scores.ContainsKey(letter))
          {
            score += Scores[letter];
            validatedWord += letter;
          }
          else
          {
            Console.WriteLine("Reminder: " + letter + " is not a scrabble letter dummy!");
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }

      if (validatedWord.Length < Letters.Length)
      {
        Console.WriteLine("(score calculated for '" + validatedWord + "')");
      }
      return score;
    }

    private static Dictionary<char, int> Scores = new Dictionary<char, int>() 
    {
      {'a', 1}, 
      {'b', 3}, 
      {'c', 3}, 
      {'d', 2}, 
      {'e', 1}, 
      {'f', 4}, 
      {'g', 2}, 
      {'h', 4},
      {'i', 1}, 
      {'j', 8}, 
      {'k', 5}, 
      {'l', 1}, 
      {'m', 3},
      {'n', 1}, 
      {'o', 1}, 
      {'p', 3}, 
      {'q', 10}, 
      {'r', 1},
      {'s', 1}, 
      {'t', 1}, 
      {'u', 1}, 
      {'v', 4}, 
      {'w', 4}, 
      {'x', 8}, 
      {'y', 4}, 
      {'z', 10}
    };
  }
}