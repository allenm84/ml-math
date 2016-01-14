using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace System.Advanced
{
  public static partial class Extensions
  {
    public static bool isPalindrome(this SByte v)
    {
      return v.ToString().isPalindrome();
    }

    public static bool isPalindrome(this Byte v)
    {
      return v.ToString().isPalindrome();
    }

    public static bool isPalindrome(this Int16 v)
    {
      return v.ToString().isPalindrome();
    }

    public static bool isPalindrome(this UInt16 v)
    {
      return v.ToString().isPalindrome();
    }

    public static bool isPalindrome(this Int32 v)
    {
      return v.ToString().isPalindrome();
    }

    public static bool isPalindrome(this UInt32 v)
    {
      return v.ToString().isPalindrome();
    }

    public static bool isPalindrome(this Int64 v)
    {
      return v.ToString().isPalindrome();
    }

    public static bool isPalindrome(this UInt64 v)
    {
      return v.ToString().isPalindrome();
    }

    public static bool isPalindrome(this BigInteger v)
    {
      return v.ToString().isPalindrome();
    }

    public static bool isPalindrome(this string str)
    {
      int i = 0;
      int j = str.Length - 1;

      while (i < j)
      {
        if (str[i] != str[j])
        {
          return false;
        }

        i++;
        j--;
      }

      return true;
    }
  }
}
