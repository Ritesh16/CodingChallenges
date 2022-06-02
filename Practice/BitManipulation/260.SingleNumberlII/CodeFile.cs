using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice.BitManipulation._260.SingleNumberlII
{
    public class CodeFile
    {
		public int[] SingleNumber(int[] nums)
		{
			var xor = nums.Aggregate(0, (x, y) => x ^ y);
			int bit = 1, n1 = 0, n2 = 0;
			while ((xor & 1) == 0)
			{
				bit <<= 1;
				xor >>= 1;
			}
			foreach (var n in nums)
			{
				if ((n & bit) == 0)
				{
					n1 ^= n;
				}
				else
				{
					n2 ^= n;
				}
			}
			return new[] { n1, n2 };
		}
	}
}
