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
	  public static IEnumerable<Int32> divisors(Int32 x)
    {
      Int32 product = 1;
      for (Int32 factor = 1; product <= x; factor++, product = factor * factor)
      {
        if (x % factor == 0)
        {
          yield return factor;
          if (product != x)
          {
            yield return x / factor;
          }
        }
      }
    }
	
	  public static IEnumerable<UInt32> divisors(UInt32 x)
    {
      UInt32 product = 1;
      for (UInt32 factor = 1; product <= x; factor++, product = factor * factor)
      {
        if (x % factor == 0)
        {
          yield return factor;
          if (product != x)
          {
            yield return x / factor;
          }
        }
      }
    }
	
	  public static IEnumerable<Int64> divisors(Int64 x)
    {
      Int64 product = 1;
      for (Int64 factor = 1; product <= x; factor++, product = factor * factor)
      {
        if (x % factor == 0)
        {
          yield return factor;
          if (product != x)
          {
            yield return x / factor;
          }
        }
      }
    }
	
	  public static IEnumerable<UInt64> divisors(UInt64 x)
    {
      UInt64 product = 1;
      for (UInt64 factor = 1; product <= x; factor++, product = factor * factor)
      {
        if (x % factor == 0)
        {
          yield return factor;
          if (product != x)
          {
            yield return x / factor;
          }
        }
      }
    }
	}
}