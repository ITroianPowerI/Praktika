﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracktika3
{
    static public class ArrayExtension
    {
        public static int[] Sortirovka(this int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
