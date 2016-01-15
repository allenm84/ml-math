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
    public static IEnumerable<int[]> compositions(int n)
    {
      /*
      def accelAsc(n):
          a = [0 for i in range(n + 1)]
          k = 1
          a[0] = 0
          y = n - 1
          while k != 0:
              x = a[k - 1] + 1
              k -= 1
              while 2*x <= y:
                  a[k] = x
                  y -= x
                  k += 1
              l = k + 1
              while x <= y:
                  a[k] = x
                  a[l] = y
                  yield a[:k + 2]
                  x += 1
                  y -= 1
              a[k] = x + y
              y = x + y - 1
              yield a[:k + 1]
     */

      var a = Enumerable.Repeat(0, n + 1).ToArray();
      var k = 1;
      a[0] = 0;
      var y = n - 1;
      while (k != 0)
      {
        var x = a[k - 1] + 1;
        --k;
        while ((2 * x) <= y)
        {
          a[k] = x;
          y -= x;
          ++k;
        }
        var l = k + 1;
        while (x <= y)
        {
          a[k] = x;
          a[l] = y;
          yield return a.Take(k + 2).ToArray();
          x += 1;
          y -= 1;
        }
        a[k] = x + y;
        y = x + y - 1;
        yield return a.Take(k + 1).ToArray();
      }
    }
  }
}
