using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes.Models
{
  public class PalCheck
  {
    public bool IsPalindrome(string userInput)
    {
      userInput = userInput.ToLower();
      char[] newList = userInput.ToCharArray();
      
      List<char> revList = new List<char>();

      int t = (newList.Length - 1);

      for (int index = 0; index < newList.Length; index++)
      {
        revList.Add(newList[t]);
        t--;
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
