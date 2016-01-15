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
		public static Int32 gcd(Int32 a, Int32 b)
		{
			if (b == 0) { return a; }
			return gcd(b, a % b);
		}
	
		public static UInt32 gcd(UInt32 a, UInt32 b)
		{
			if (b == 0) { return a; }
			return gcd(b, a % b);
		}
	
		public static Int64 gcd(Int64 a, Int64 b)
		{
			if (b == 0) { return a; }
			return gcd(b, a % b);
		}
	
		public static UInt64 gcd(UInt64 a, UInt64 b)
		{
			if (b == 0) { return a; }
			return gcd(b, a % b);
		}
	
		public static Single gcd(Single a, Single b)
		{
			if (b == 0) { return a; }
			return gcd(b, a % b);
		}
	
		public static Double gcd(Double a, Double b)
		{
			if (b == 0) { return a; }
			return gcd(b, a % b);
		}
	
		public static Decimal gcd(Decimal a, Decimal b)
		{
			if (b == 0) { return a; }
			return gcd(b, a % b);
		}
	
		public static BigInteger gcd(BigInteger a, BigInteger b)
		{
			if (b == 0) { return a; }
			return gcd(b, a % b);
		}
	}
}