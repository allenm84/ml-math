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
    public static SByte clamp(SByte val, SByte minVal, SByte maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static Byte clamp(Byte val, Byte minVal, Byte maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static Int16 clamp(Int16 val, Int16 minVal, Int16 maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static UInt16 clamp(UInt16 val, UInt16 minVal, UInt16 maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static Int32 clamp(Int32 val, Int32 minVal, Int32 maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static UInt32 clamp(UInt32 val, UInt32 minVal, UInt32 maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static Int64 clamp(Int64 val, Int64 minVal, Int64 maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static UInt64 clamp(UInt64 val, UInt64 minVal, UInt64 maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static Single clamp(Single val, Single minVal, Single maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static Double clamp(Double val, Double minVal, Double maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static Decimal clamp(Decimal val, Decimal minVal, Decimal maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }

    public static BigInteger clamp(BigInteger val, BigInteger minVal, BigInteger maxVal)
    {
      return math.max(minVal, math.min(val, maxVal));
    }
  }
}
