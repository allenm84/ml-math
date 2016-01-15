using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace System.Advanced
{
  public delegate long fInt64(long n);

  public static partial class math
  {
    static readonly fInt64[] sCollatzChainTable;
    static math()
    {
      sCollatzChainTable = new fInt64[2];
      sCollatzChainTable[0] = (x => x / 2L);
      sCollatzChainTable[1] = (x => (3L * x) + 1L);
    }

    public static IEnumerable<long> collatz(this long n)
    {
      var i = n;
      int c;

      while (i != 1)
      {
        c = (int)(i % 2);
        yield return i;
        i = sCollatzChainTable[c](i);
      }
    }

    public static IEnumerable<uint> digits(this uint n)
    {
      while (n > 0u)
      {
        yield return n % 10u;
        n /= 10u;
      }
    }

    public static IEnumerable<ulong> digits(this ulong n)
    {
      while (n > 0ul)
      {
        yield return n % 10ul;
        n /= 10ul;
      }
    }
  }
}
