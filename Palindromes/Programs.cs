using System;
using Palindromes.Models;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Write a palindrome: ");
      string userInput = Console.ReadLine();

      PalCheck palCheck = new PalCheck();

      bool result = palCheck.IsPalindrome(userInput);

      Console.WriteLine(result);
    }
  }
}