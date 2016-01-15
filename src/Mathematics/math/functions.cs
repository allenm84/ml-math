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
    /// <summary>Euler's totient function</summary>
    public static int phi(int n)
    {
      if (n <= 1) { return n == 1 ? 1 : 0; }
      var phi = n;

      if (n % 2 == 0)
      {
        phi /= 2;
        n /= 2;
        while (n % 2 == 0) { n /= 2; }
      }
      if (n % 3 == 0)
      {
        phi -= phi / 3;
        n /= 3;
        while (n % 3 == 0) { n /= 3; }
      }

      for (var p = 5; p * p <= n; )
      {
        if (n % p == 0)
        {
          phi -= phi / p;
          n /= p;
          while (n % p == 0) { n /= p; }
        }
        p += 2;

        if (p * p > n) { break; }
        if (n % p == 0)
        {
          phi -= phi / p;
          n /= p;
          while (n % p == 0) { n /= p; }
        }
        p += 4;
      }

      if (n > 1) { phi -= phi / n; }
      return phi;
    }
  }
}
