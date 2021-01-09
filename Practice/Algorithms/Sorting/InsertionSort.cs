﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Algorithms.Sorting
{
    public class InsertionSort
    {
        public int[] Sort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                var j = i - 1;
                var current = input[i];
                while(j >= 0 &&  current < input[j])
                {
                    input[j + 1] = input[j];
                    j--;
                }

                input[j+ 1 ] = current;

            }

            return input;
        }
    }
}
