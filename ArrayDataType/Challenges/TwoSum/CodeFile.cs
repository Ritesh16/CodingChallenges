using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataType.Challenges.TwoSum
{
    public class CodeFile
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var output = new int[2];
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var secondNumber = target - nums[i];
                if (map.ContainsKey(nums[i]))
                {
                    output[0] = map[nums[i]];
                    output[1] = i;
                    break;
                }

                map.Add(secondNumber, i);
            }


            return output;
        }
    }
}
