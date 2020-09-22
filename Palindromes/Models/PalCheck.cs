using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes.Models
{
  public class PalCheck
  {
    public bool IsPalindrome(string userInput)
    {
      List<string> newList = userInput.Split("").ToList();
      List<string> revList = new List<string>();

      for (int index = newList.Count; index > 0; index--)
      {
        revList.Add(newList[index]);
      }
      
      string newString = String.Join("", revList);
      if (newString == userInput)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
