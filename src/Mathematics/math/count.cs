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
    public static int numDigits(int n)
    {
      n = abs(n);

      if (n < 10)
      {
        return 1;
      }
      else
      {
        return (int)Math.Floor(Math.Log10(n) + 1);
      }
    }
  }
}
