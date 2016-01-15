using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace System.Advanced
{
  public static partial class math
  {
		public static bool isPalindrome(SByte v)
		{
		  return isPalindrome(v.ToString());
		}
	
		public static bool isPalindrome(Byte v)
		{
		  return isPalindrome(v.ToString());
		}
	
		public static bool isPalindrome(Int16 v)
		{
		  return isPalindrome(v.ToString());
		}
	
		public static bool isPalindrome(UInt16 v)
		{
		  return isPalindrome(v.ToString());
		}
	
		public static bool isPalindrome(Int32 v)
		{
		  return isPalindrome(v.ToString());
		}
	
		public static bool isPalindrome(UInt32 v)
		{
		  return isPalindrome(v.ToString());
		}
	
		public static bool isPalindrome(Int64 v)
		{
		  return isPalindrome(v.ToString());
		}
	
		public static bool isPalindrome(UInt64 v)
		{
		  return isPalindrome(v.ToString());
		}
	
		public static bool isPalindrome(BigInteger v)
		{
		  return isPalindrome(v.ToString());
		}
	
		public static bool isPalindrome(string str)
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