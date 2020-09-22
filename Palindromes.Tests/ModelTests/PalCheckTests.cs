using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalCheckTests
  {
    [TestMethod]
    public void IsPalindrome_IsNotAPalindrome_False()
    {
      PalCheck palCheck = new PalCheck();
      Assert.AreEqual(false , palCheck.IsPalindrome("hello"));
    }
    [TestMethod]
    public void IsPalindrome_IsAPalindrome_True()
    {
      PalCheck palCheck = new PalCheck();
      Assert.AreEqual(true , palCheck.IsPalindrome("racecar"));
    }
  }
}