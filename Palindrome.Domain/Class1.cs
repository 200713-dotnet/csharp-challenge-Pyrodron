using System;

namespace Palindrome.Domain
{
    public class Class1 {
      public bool IsPalindrome(string str) {
        if (str.Length % 2 != 0) {
          return false;
        }

        int j = str.Length - 1;
        for (int i = 0; i < str.Length / 2; i++) {
          if (str[i] != str[j--]) {
            return false;
          }
        }

        return true;
      }
    }
}
