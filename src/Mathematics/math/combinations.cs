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
    /// <summary>
    /// Counts the number of different possible ways to make up a value given
    /// coins.  For example, to find out how to make $1.00 using only
    /// $0.05 and $0.10, you could pass in value="100" and coints="5,10". 100 cents
    /// is the same as $1.00.
    /// </summary>
    /// <param name="value">The value to get to (in the same unit as the coins).</param>
    /// <param name="coins">The coin values.</param>
    /// <returns>The number of ways to get to the value using the coins.</returns>
    public static int coinChangeCount(int value, int[] coins)
    {
      var table = new Dictionary<int, Dictionary<int, int>>();
      return coinchange(value, coins.Length - 1, ref coins, ref table);
    }

    private static int coinchange(int n, int m, ref int[] S, ref Dictionary<int, Dictionary<int, int>> table)
    {
      if (n == 0) { return 1; }
      if (n < 0) { return 0; }
      if (m < 0 && n >= 1) { return 0; }

      Dictionary<int, int> mtable;
      if (!table.TryGetValue(n, out mtable))
      {
        mtable = new Dictionary<int, int>();
        table[n] = mtable;
      }

      int cnt;
      if (!mtable.TryGetValue(m, out cnt))
      {
        cnt = coinchange(n, m - 1, ref S, ref table) + coinchange(n - S[m], m, ref S, ref table);
        mtable[m] = cnt;
      }

      return cnt;
    }
  }
}
