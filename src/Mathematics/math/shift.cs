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
    public static int rotateShift(int value, int shift)
    {
      int len = (int)Math.Log10(value) + 1;
      shift %= len;
      if (shift < 0) shift += len;
      int pow = (int)Math.Pow(10, shift);
      return (value % pow) * (int)Math.Pow(10, len - shift) + value / pow;
    }
  }
}
