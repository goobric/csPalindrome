// check if number is a palindrome when reversed

using System;

class Program
{
  static bool IsPalindrome(int number)
  {
    int originalNumber = number;
    int reversedNumber = 0;

    while (number > 0)
    {
      int digit = number % 10;
      reversedNumber = reversedNumber * 10 + digit;
      number /= 10;
    }
    return originalNumber == reversedNumber;
  }

  static void Main(string[] args)
  {
    Console.WriteLine("Enter a number: ");
    int number = int.Parse(Console.ReadLine());

    if (IsPalindrome(number))
    {
      Console.WriteLine($"{number} is a Palindrome");
    }
    else
    {
      Console.WriteLine($"{number} is not a palindrome :-( ");
    }
  }
}