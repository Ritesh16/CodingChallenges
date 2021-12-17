using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.MinNumberofMovestoSeatEveryone
{
    public class CodeFile
    {
        public int MinMovesToSeat(int[] seats, int[] students)
        {
            var result = 0;
            Array.Sort(seats);
            Array.Sort(students);

            for (int i = 0; i < seats.Length; i++)
            {
                result += Math.Abs(seats[i] - students[i]);
            }

            return result;
        }
    }
}
