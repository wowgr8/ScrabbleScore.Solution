using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

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
  }
}