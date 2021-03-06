using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Scrabble Score!");
      Console.WriteLine("Enter a word to see its score:");
      string entered = Console.ReadLine().ToLower();
      Word objWord = new Word(entered);
      Console.WriteLine("The Scrabble score for '" + entered + "' is: " + objWord.GetScore());
    }
  }
}