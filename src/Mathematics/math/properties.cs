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
    public static int ntriangle(int n)
    {
      return ((n * (n + 1)) / 2);
    }

    public static int nsquare(int n)
    {
      return (n * n);
    }

    public static int npentagon(int n)
    {
      return ((n * ((3 * n) - 1)) / 2);
    }

    public static bool isPentagonal(long x)
    {
      var n = (Math.Sqrt((24.0 * x) + 1.0) + 1.0) / 6.0;
      return (n > 0) && (n == Math.Floor(n));
    }

    public static int nhexagon(int n)
    {
      return (n * ((2 * n) - 1));
    }

    public static bool isHexagonal(long x)
    {
      var n = (Math.Sqrt((8.0 * x) + 1.0) + 1.0) / 4.0;
      return (n > 0) && (n == Math.Floor(n));
    }

    public static int nheptagon(int n)
    {
      return (n * ((5 * n) - 3)) / 2;
    }

    public static int foctagon(int n)
    {
      return (n * ((3 * n) - 2));
    }
  }
}
