using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {

    [TestMethod]
    public void WordConstructor_CreateInstanceOfWord_Word()
    {
      //Arrange
      string sample = "wordyword";

      //Act
      Word newWord = new Word(sample);

      //Assert
      Assert.AreEqual(typeof(Word),newWord.GetType());
    }

    [TestMethod]
    public void WordConstructor_SetTextProperty_wordyword()
    {
      //Arrange
      string sample = "wordyword";

      //Act
      Word newWord = new Word(sample);

      // Assert
      Assert.AreEqual(newWord.Text,"wordyword");
    }

    [TestMethod]
    public void WordConstructor_SetLettersProperty_w()
    {
      //Arrange
      string sample = "word";
      
      //Act
      Word newWord = new Word(sample);

      // Assert
      Assert.AreEqual(newWord.Letters.Length,4);
    }
  }
}